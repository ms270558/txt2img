using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt2img
{
    public class Settings
    {
        public Dictionary<String, String> dValues;

        public Settings()
        {
            dValues = new Dictionary<String, String>();
            MemberInfo[] members = typeof(Settings).GetMembers();

            foreach (MemberInfo mi in members)
            {
                object[] attributes = mi.GetCustomAttributes(true);

                if (attributes.Length != 0)
                {
                    foreach (object attribute in attributes)
                    {
                        DisplayNameAttribute da = attribute as DisplayNameAttribute;
                        if (da != null) dValues.Add(da.DisplayName, "");
                    }
                }
            }
        }

        public void PropertiesSet(Settings src)
        {
            width = src.width;
            height = src.height;
            sFont = src.sFont;
            imgType = src.imgType;
        }

        public void PropertySet(string name, string value)
        {
            switch (name)
            {
                case "board_ver": width = UshortValue(value); break;
                case "board_type": height = UshortValue(value); break;
                case "font": sFont = value; break;
                case "image_type": imgType = value; break;
            }
        }

        
        public void PropertiesSet(List<string> ls)
        {
            int i;

            for (i = 0; i < ls.Count; i++)
            {
                string[] sa = ls[i].Split(new char[] { '=' });
                if (sa.Length == 2)
                {
                    switch (sa[0].ToLower().Trim())
                    {
                        case "board_ver": width = UshortValue(sa[1]); break;
                        case "board_type": height = UshortValue(sa[1]); break;
                        case "font": sFont = sa[1]; break;
                        case "image_type": imgType = sa[1]; break;

                    }
                }
            }
        }

        public ushort UshortValue(string s)
        {
            ushort v = 0;
            ushort.TryParse(s, out v);
            return v;
        }

        public short ShortValue(string s)
        {
            short v = 0;
            short.TryParse(s, out v);
            return v;
        }


        //-----------------------------------------------

        public ushort Width = 500; // первая версия
        [DisplayName("width"), Description("width [pixels]"), Category("common")]
        public ushort width
        {
            get { return Width; }
            set { Width = value; dValues["width"] = value.ToString(); }
        }

        public ushort Height = 1500; // первая версия
        [DisplayName("height"), Description("height [pixels]"), Category("common")]
        public ushort height
        {
            get { return Height; }
            set { Height = value; dValues["height"] = value.ToString(); }
        }

        private string sysFont = "Arial;9,75;Regular";
        [DisplayName("font")]
        [Description("print font")]
        [Category("common")]
        [Browsable(true)]
        [Editor(typeof(FontEditor), typeof(UITypeEditor))]

        public string sFont
        {
            get { return sysFont; }
            set { sysFont = value; dValues["font"] = value; }
        }

        private string sImgType;
        [DisplayName("image_type")]
        [Description("image_type")]
        [Category("common")]
        [TypeConverter(typeof(ImageListConverter))]

        public string imgType
        {
            get { return sImgType; }
            set { sImgType = value; dValues["image_type"] = value; }
        }
    }

    class FontEditor : UITypeEditor
    {
        public FontEditor()
        {
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal; //чтобы было [...]
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            string sFileName = (string)value;

            FontDialog dlg = new FontDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sFileName = dlg.Font.Name + ";" + dlg.Font.Size.ToString() + ";" + dlg.Font.Style.ToString();
            }

            return sFileName;
        }
    }

    public class ImageListConverter : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true; // display drop
        }

        public override bool  GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true; // drop-down vs combo
        }

        public override StandardValuesCollection         GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new string[] { "bmp", "jpg", "png" });
        }
    }

}
