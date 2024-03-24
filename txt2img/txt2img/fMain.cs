// print .txt to image series utility 
// image size,  image format and printer font are selected in settings
// program compiled in vs2012 for .NET 4.5
// v.0.1 (C) mihsan 2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Xml;

namespace txt2img
{
    public partial class fMain : Form
    {

        public string sFileName = "img";
        public string sFilePath = "";
        public int fileIndex = 0;

        Settings settings;

        public fMain()
        {
            InitializeComponent();
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            SettingsRead();
            pgSettings.SelectedObject = settings;

            TextInit();

            CbShowColumns();
            //tbFile.Text = sFileName;
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsWrite();
        }

        private void rbViewText_CheckedChanged(object sender, EventArgs e)
        {
            CbShowColumns();
        }

        private void cbTextView_CheckedChanged(object sender, EventArgs e)
        {
            CbShowColumns();
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Button bn = (Button)sender;

            switch (bn.Name)
            {
                case "bnExit": Close(); break;
                case "bnFile": GetFile(); break;
                case "bnDraw": Draw(0); break;
                case "bnPrint": Print(); break;

                case "bnVKHome": Draw(0); break;
                case "bnVKUp": DrawPrev(); break;
                case "bnVKDown": DrawNext(); break;
                case "bnVKEnd": DrawLast(); break;

            }
        }


        public void CbShowColumns()
        {
            int n = 0;
            if (cbSettingsView.Checked)
            {
                tlpView.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlpView.ColumnStyles[0].Width = 0;
                tlpView.ColumnStyles[1].SizeType = SizeType.Absolute;
                tlpView.ColumnStyles[1].Width = 0;
                tlpView.ColumnStyles[2].SizeType = SizeType.Percent;
                tlpView.ColumnStyles[2].Width = 100;
            }
            else
            {
                if (cbTextView.Checked) n |= 1;
                if (cbPreView.Checked) n |= 2;

                switch ((n & 0x03))
                {
                    case 1:
                        tlpView.ColumnStyles[0].SizeType = SizeType.Percent;
                        tlpView.ColumnStyles[0].Width = 100;
                        tlpView.ColumnStyles[1].SizeType = SizeType.Absolute;
                        tlpView.ColumnStyles[1].Width = 0;
                        break;

                    case 2:
                        tlpView.ColumnStyles[0].SizeType = SizeType.Absolute;
                        tlpView.ColumnStyles[0].Width = 0;
                        tlpView.ColumnStyles[1].SizeType = SizeType.Percent;
                        tlpView.ColumnStyles[1].Width = 100;
                        break;

                    case 3:
                        tlpView.ColumnStyles[0].SizeType = SizeType.Percent;
                        tlpView.ColumnStyles[0].Width = 100;
                        tlpView.ColumnStyles[1].SizeType = SizeType.Percent;
                        tlpView.ColumnStyles[1].Width = 100;
                        break;
                }
                tlpView.ColumnStyles[2].SizeType = SizeType.Absolute;
                tlpView.ColumnStyles[2].Width = 0;
            }
        }



        //=================================================== text

        public string[] saTextEncoding = new string[] 
        {
           "UTF8",
           "W1251",
           "DOS",
           "KOI8"
        };


        public Encoding textEncoding = Encoding.UTF8;
        public byte[] text;

        public void TextInit()
        {
            cmbTextEncoding.Items.Clear();
            cmbTextEncoding.Items.AddRange(saTextEncoding);
            cmbTextEncoding.SelectedIndex = 0;

            ChangeSysFont();

        }

        private void cmbTextEncoding_SelectedValueChanged(object sender, EventArgs e)
        {
            string se = cmbTextEncoding.SelectedItem.ToString();
            try
            {
                textEncoding = GetDefaulEncoding();

                ShowFile();
            }
            catch { };
        }

        public Encoding GetDefaulEncoding()
        {
            Encoding enc;

            switch (cmbTextEncoding.SelectedItem.ToString())
            {
                case "W1251": enc = Encoding.GetEncoding(1251); break;
                case "KOI8": enc = Encoding.GetEncoding(20866); break;
                case "DOS": enc = Encoding.GetEncoding(866); break;
                default: enc = Encoding.UTF8; break;
            }
            return enc;
        }

        public void GetFile()
        {
            string sfn = "";

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sfn = dlg.FileName;
                //Readfile
                tbFile.Text = sfn;
                text = File.ReadAllBytes(sfn);

                ShowFile();
            }
        }


        public void ShowFile()
        {
            String sTxt = new String(textEncoding.GetChars(text));
            sTxt = CleanText(sTxt);
            tbText.Text = sTxt;
            Draw(0);
        }


        public string CleanText(String sn)
        {
            string s = sn.Replace(".", ". ");
            s = s.Replace(",", ", ");

            int ns = s.Length;
            int idx = s.IndexOf("  ");
            while (idx >= 0)
            {
                s = s.Replace("  ", " ");
                idx = s.IndexOf("  ");
                if (ns == s.Length) break;
                ns = s.Length;
            }
            
            s = s.Replace("\r", "");
            s = s.Replace("\n", "\r\n");

            return s;
        }

        //=================================================== image

        Font printFont = new Font("Courier new", 14);
        List<String> drawPages;

        public void ChangeSysFont()
        {
            string[] sfpa = settings.sFont.Split(new char[] { ';' });
            int snp = sfpa.Length;
            float fSize;
            Font f;

            if (snp == 3)
            {
                if (float.TryParse(sfpa[1], out fSize))
                {
                    if (sfpa[2].ToLower() == "bold")
                        f = new Font(sfpa[0], fSize, FontStyle.Bold);
                    else
                        f = new Font(sfpa[0], fSize, FontStyle.Regular);
                    printFont = f;
                }
            }
        }



        public void Print()
        {
            string sfn;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sfn = dlg.FileName;
                int idx = sfn.LastIndexOf('\\');
                sFilePath = sfn.Substring(0, idx);
                sFileName = sfn.Substring(idx + 1);
                fileIndex = 1;

                PrintFile();
            }
        }

        int drawPageNum = 0;

        public void Draw(int pgNum)
        {
            try
            {
                ChangeSysFont();

                // Construct a new Rectangle .

                StringFormat format1 = new StringFormat();
                format1.LineAlignment = StringAlignment.Near;
                format1.Alignment = StringAlignment.Near;

                drawPages = SplitStringToPages(format1);

                if (pgNum < drawPages.Count)
                {
                    drawPageNum = pgNum;
                    pbView.BackgroundImage = DrawPage(drawPages[pgNum], format1);
                }
            }
            catch (Exception e)
            {
            }
        }


        public void DrawPrev()
        {
            if (drawPageNum > 0) Draw(drawPageNum - 1);
        }


        public void DrawNext()
        {
            Draw(drawPageNum + 1);
        }

        public void DrawLast()
        {
            Draw(drawPages.Count-1);
        }


        public void PrintFile()
        {
            string sImageFileName;

            try
            {
                ChangeSysFont();

                // Construct a new Rectangle .

                StringFormat format1 = new StringFormat();
                format1.LineAlignment = StringAlignment.Near;
                format1.Alignment = StringAlignment.Near;

                List<String> ls = SplitStringToPages(format1);
                for (int i = 0; i < ls.Count; i++)
                {
                    sImageFileName = sFilePath + "\\" + sFileName + i.ToString() + "." + settings.imgType;
                    if (File.Exists(sImageFileName)) File.Delete(sImageFileName);
                    Bitmap bitmap = DrawPage(ls[i], format1);

                    bitmap.Save(sImageFileName);
                }
            }
            catch (Exception e)
            {
            }
        }

        public Bitmap DrawPage(string s, StringFormat format1)
        {
            Rectangle displayRectangle = new Rectangle(new Point(0, 0), new Size(settings.width, settings.height));
            Bitmap bitmap = new Bitmap(settings.width, settings.height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = graphics.MeasureString(s, printFont, settings.width, format1);

            if (stringSize.Height < (settings.height + 16))
            {
                graphics.Dispose();

                bitmap = new Bitmap((int)(stringSize.Width), (int)(stringSize.Height), System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                graphics = Graphics.FromImage(bitmap);
                graphics.Clear(Color.White);
            }

            graphics.DrawString(s, printFont, Brushes.Black, (RectangleF)displayRectangle, format1);
            return bitmap;
        }


        public List<String> SplitStringToPages(StringFormat format1)
        {
            Bitmap bitmap = new Bitmap(settings.width, settings.height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            List<String> ls = new List<string>();
            string[] sa = tbText.Text.Split(' ');
            string s = sa[0];

            for (int i = 1; i < sa.Length; i++)
            {
                SizeF stringSize = new SizeF();
                stringSize = graphics.MeasureString(s + sa[i], printFont, settings.width, format1);
                if (stringSize.Height > settings.height)
                {
                    ls.Add(s);
                    s = sa[i];
                }
                else
                    s += " " + sa[i];
            }
            ls.Add(s);

            return ls;
        }

        //=================================================== settings load/save

        public string sConfigFileName;
        public XmlDocument xmlConfig;

        public void SettingsRead()
        {
            sConfigFileName = Application.StartupPath + "\\txt2img.ini";
            if (File.Exists(sConfigFileName))
            {
                LoadXmlSettings(sConfigFileName);
                List<string> ls = SettingsList(xmlConfig);
                settings.PropertiesSet(ls);
            }
            pgSettings.Refresh();

        }

        public bool LoadXmlSettings(string sFileName)
        {
            xmlConfig = new XmlDocument();
            XmlDeclaration dcl = xmlConfig.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlConfig.AppendChild(dcl);
            XmlElement root = xmlConfig.CreateElement("Config");
            xmlConfig.AppendChild(root);

            if (sConfigFileName != null)
            {
                if (File.Exists(sConfigFileName))
                {
                    xmlConfig.Load(sConfigFileName);
                    return true;
                }
            }
            return false;
        }


        public void SettingsWrite()
        {
            Dictionary<string, string> dProps = new Dictionary<string, string>();

            sConfigFileName = Application.StartupPath + "\\txt2img.ini";
            settings.PropertiesSet(settings); //update dictionary
            dProps = settings.dValues;
            //----------------------------- write dictionary
            if (dProps.Count > 0)
            {
                xmlConfig = new XmlDocument();
                XmlDeclaration dcl = xmlConfig.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlConfig.AppendChild(dcl);
                XmlElement root = xmlConfig.CreateElement("Config");
                xmlConfig.AppendChild(root);

                XmlNode xl = xmlConfig.SelectSingleNode("Config");
                xl.RemoveAll();

                string[] sk = dProps.Keys.ToArray<string>();

                for (int i = 0; i < sk.Length; i++)
                {
                    XmlElement xe = xmlConfig.CreateElement("Item");
                    xe.SetAttribute("name", sk[i]);
                    xe.SetAttribute("value", dProps[sk[i]]);
                    xl.AppendChild(xe);
                }

                if (File.Exists(sConfigFileName)) File.Delete(sConfigFileName);
                xmlConfig.Save(sConfigFileName);
            }
        }

        public List<string> SettingsList(XmlDocument xmlConfig)
        {
            string snn, snv;
            XmlNodeList xl = xmlConfig.SelectNodes("Config");
            XmlNodeList xcl = xl[0].ChildNodes; // items
            List<string> ls = new List<string>();

            foreach (XmlNode xn in xcl)
            {
                XmlAttributeCollection xac = xn.Attributes; // item attributes
                snn = snv = "";// пара имя-значение

                foreach (XmlAttribute xa in xac)
                {
                    switch (xa.Name)
                    {
                        case "name":
                            snn = xa.Value; break;
                        case "value":
                            snv = xa.Value; break;
                    }
                }
                ls.Add(snn + "=" + snv);
            }

            return ls;
        }

        private void pgSettings_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            GridItem gi = ((PropertyGrid)s).SelectedGridItem;

            settings.PropertySet(gi.Label, gi.Value.ToString());

            pgSettings.Refresh();

            ChangeSysFont();

        }

    }
}
