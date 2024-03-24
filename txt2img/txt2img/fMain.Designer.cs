namespace txt2img
{
    partial class fMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.bnExit = new System.Windows.Forms.Button();
            this.bnDraw = new System.Windows.Forms.Button();
            this.bnFile = new System.Windows.Forms.Button();
            this.bnPrint = new System.Windows.Forms.Button();
            this.tlpView = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.tlpSettingsControls = new System.Windows.Forms.TableLayoutPanel();
            this.bnSettingsLoad = new System.Windows.Forms.Button();
            this.bnSettingsSave = new System.Windows.Forms.Button();
            this.tlpText = new System.Windows.Forms.TableLayoutPanel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tlpTextControls = new System.Windows.Forms.TableLayoutPanel();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.cmbTextEncoding = new System.Windows.Forms.ComboBox();
            this.tlpPreview = new System.Windows.Forms.TableLayoutPanel();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.tlpVK = new System.Windows.Forms.TableLayoutPanel();
            this.bnVKHome = new System.Windows.Forms.Button();
            this.bnVKUp = new System.Windows.Forms.Button();
            this.bnVKDown = new System.Windows.Forms.Button();
            this.bnVKEnd = new System.Windows.Forms.Button();
            this.tlpViewMode = new System.Windows.Forms.TableLayoutPanel();
            this.cbTextView = new System.Windows.Forms.CheckBox();
            this.cbPreView = new System.Windows.Forms.CheckBox();
            this.cbSettingsView = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.tlpView.SuspendLayout();
            this.tlpSettings.SuspendLayout();
            this.tlpSettingsControls.SuspendLayout();
            this.tlpText.SuspendLayout();
            this.tlpTextControls.SuspendLayout();
            this.tlpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.tlpVK.SuspendLayout();
            this.tlpViewMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 0);
            this.tlpMain.Controls.Add(this.tlpView, 0, 2);
            this.tlpMain.Controls.Add(this.tlpViewMode, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1046, 467);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMenu
            // 
            this.tlpMenu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMenu.ColumnCount = 6;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMenu.Controls.Add(this.bnExit, 0, 0);
            this.tlpMenu.Controls.Add(this.bnDraw, 2, 0);
            this.tlpMenu.Controls.Add(this.bnFile, 1, 0);
            this.tlpMenu.Controls.Add(this.bnPrint, 3, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(1, 1);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(1044, 32);
            this.tlpMenu.TabIndex = 0;
            // 
            // bnExit
            // 
            this.bnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnExit.Location = new System.Drawing.Point(1, 1);
            this.bnExit.Margin = new System.Windows.Forms.Padding(0);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(96, 30);
            this.bnExit.TabIndex = 0;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnDraw
            // 
            this.bnDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnDraw.Location = new System.Drawing.Point(195, 1);
            this.bnDraw.Margin = new System.Windows.Forms.Padding(0);
            this.bnDraw.Name = "bnDraw";
            this.bnDraw.Size = new System.Drawing.Size(96, 30);
            this.bnDraw.TabIndex = 1;
            this.bnDraw.Text = "Draw";
            this.bnDraw.UseVisualStyleBackColor = true;
            this.bnDraw.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnFile
            // 
            this.bnFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnFile.Location = new System.Drawing.Point(98, 1);
            this.bnFile.Margin = new System.Windows.Forms.Padding(0);
            this.bnFile.Name = "bnFile";
            this.bnFile.Size = new System.Drawing.Size(96, 30);
            this.bnFile.TabIndex = 1;
            this.bnFile.Text = "File";
            this.bnFile.UseVisualStyleBackColor = true;
            this.bnFile.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnPrint
            // 
            this.bnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnPrint.Location = new System.Drawing.Point(292, 1);
            this.bnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(96, 30);
            this.bnPrint.TabIndex = 1;
            this.bnPrint.Text = "Print";
            this.bnPrint.UseVisualStyleBackColor = true;
            this.bnPrint.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // tlpView
            // 
            this.tlpView.ColumnCount = 3;
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpView.Controls.Add(this.tlpSettings, 2, 0);
            this.tlpView.Controls.Add(this.tlpText, 0, 0);
            this.tlpView.Controls.Add(this.tlpPreview, 1, 0);
            this.tlpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpView.Location = new System.Drawing.Point(1, 67);
            this.tlpView.Margin = new System.Windows.Forms.Padding(0);
            this.tlpView.Name = "tlpView";
            this.tlpView.RowCount = 2;
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpView.Size = new System.Drawing.Size(1044, 399);
            this.tlpView.TabIndex = 1;
            // 
            // tlpSettings
            // 
            this.tlpSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpSettings.ColumnCount = 1;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Controls.Add(this.pgSettings, 0, 1);
            this.tlpSettings.Controls.Add(this.tlpSettingsControls, 0, 0);
            this.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettings.Location = new System.Drawing.Point(696, 0);
            this.tlpSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 2;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.Size = new System.Drawing.Size(348, 367);
            this.tlpSettings.TabIndex = 2;
            // 
            // pgSettings
            // 
            this.pgSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSettings.Location = new System.Drawing.Point(1, 34);
            this.pgSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pgSettings.Size = new System.Drawing.Size(346, 332);
            this.pgSettings.TabIndex = 0;
            this.pgSettings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgSettings_PropertyValueChanged);
            // 
            // tlpSettingsControls
            // 
            this.tlpSettingsControls.ColumnCount = 2;
            this.tlpSettingsControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSettingsControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSettingsControls.Controls.Add(this.bnSettingsLoad, 0, 0);
            this.tlpSettingsControls.Controls.Add(this.bnSettingsSave, 1, 0);
            this.tlpSettingsControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettingsControls.Location = new System.Drawing.Point(1, 1);
            this.tlpSettingsControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSettingsControls.Name = "tlpSettingsControls";
            this.tlpSettingsControls.RowCount = 1;
            this.tlpSettingsControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSettingsControls.Size = new System.Drawing.Size(346, 32);
            this.tlpSettingsControls.TabIndex = 1;
            // 
            // bnSettingsLoad
            // 
            this.bnSettingsLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSettingsLoad.Location = new System.Drawing.Point(0, 0);
            this.bnSettingsLoad.Margin = new System.Windows.Forms.Padding(0);
            this.bnSettingsLoad.Name = "bnSettingsLoad";
            this.bnSettingsLoad.Size = new System.Drawing.Size(173, 32);
            this.bnSettingsLoad.TabIndex = 0;
            this.bnSettingsLoad.Text = "Load";
            this.bnSettingsLoad.UseVisualStyleBackColor = true;
            this.bnSettingsLoad.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnSettingsSave
            // 
            this.bnSettingsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnSettingsSave.Location = new System.Drawing.Point(173, 0);
            this.bnSettingsSave.Margin = new System.Windows.Forms.Padding(0);
            this.bnSettingsSave.Name = "bnSettingsSave";
            this.bnSettingsSave.Size = new System.Drawing.Size(173, 32);
            this.bnSettingsSave.TabIndex = 0;
            this.bnSettingsSave.Text = "Save";
            this.bnSettingsSave.UseVisualStyleBackColor = true;
            this.bnSettingsSave.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // tlpText
            // 
            this.tlpText.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpText.ColumnCount = 1;
            this.tlpText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpText.Controls.Add(this.tbText, 0, 1);
            this.tlpText.Controls.Add(this.tlpTextControls, 0, 0);
            this.tlpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpText.Location = new System.Drawing.Point(0, 0);
            this.tlpText.Margin = new System.Windows.Forms.Padding(0);
            this.tlpText.Name = "tlpText";
            this.tlpText.RowCount = 2;
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpText.Size = new System.Drawing.Size(348, 367);
            this.tlpText.TabIndex = 4;
            // 
            // tbText
            // 
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.Location = new System.Drawing.Point(1, 43);
            this.tbText.Margin = new System.Windows.Forms.Padding(0);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.Size = new System.Drawing.Size(346, 323);
            this.tbText.TabIndex = 3;
            // 
            // tlpTextControls
            // 
            this.tlpTextControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpTextControls.ColumnCount = 2;
            this.tlpTextControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpTextControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextControls.Controls.Add(this.tbFile, 1, 0);
            this.tlpTextControls.Controls.Add(this.cmbTextEncoding, 0, 0);
            this.tlpTextControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTextControls.Location = new System.Drawing.Point(1, 1);
            this.tlpTextControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTextControls.Name = "tlpTextControls";
            this.tlpTextControls.RowCount = 1;
            this.tlpTextControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextControls.Size = new System.Drawing.Size(346, 41);
            this.tlpTextControls.TabIndex = 4;
            // 
            // tbFile
            // 
            this.tbFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFile.Location = new System.Drawing.Point(130, 1);
            this.tbFile.Margin = new System.Windows.Forms.Padding(0);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(215, 29);
            this.tbFile.TabIndex = 2;
            // 
            // cmbTextEncoding
            // 
            this.cmbTextEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTextEncoding.FormattingEnabled = true;
            this.cmbTextEncoding.Location = new System.Drawing.Point(1, 1);
            this.cmbTextEncoding.Margin = new System.Windows.Forms.Padding(0);
            this.cmbTextEncoding.Name = "cmbTextEncoding";
            this.cmbTextEncoding.Size = new System.Drawing.Size(128, 30);
            this.cmbTextEncoding.TabIndex = 4;
            this.cmbTextEncoding.SelectedValueChanged += new System.EventHandler(this.cmbTextEncoding_SelectedValueChanged);
            // 
            // tlpPreview
            // 
            this.tlpPreview.ColumnCount = 2;
            this.tlpPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpPreview.Controls.Add(this.pbView, 0, 0);
            this.tlpPreview.Controls.Add(this.tlpVK, 1, 0);
            this.tlpPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPreview.Location = new System.Drawing.Point(348, 0);
            this.tlpPreview.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPreview.Name = "tlpPreview";
            this.tlpPreview.RowCount = 1;
            this.tlpPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPreview.Size = new System.Drawing.Size(348, 367);
            this.tlpPreview.TabIndex = 5;
            // 
            // pbView
            // 
            this.pbView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbView.BackgroundImage")));
            this.pbView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbView.Location = new System.Drawing.Point(0, 0);
            this.pbView.Margin = new System.Windows.Forms.Padding(0);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(252, 367);
            this.pbView.TabIndex = 1;
            this.pbView.TabStop = false;
            // 
            // tlpVK
            // 
            this.tlpVK.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpVK.ColumnCount = 1;
            this.tlpVK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVK.Controls.Add(this.bnVKHome, 0, 0);
            this.tlpVK.Controls.Add(this.bnVKUp, 0, 1);
            this.tlpVK.Controls.Add(this.bnVKDown, 0, 2);
            this.tlpVK.Controls.Add(this.bnVKEnd, 0, 3);
            this.tlpVK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVK.Location = new System.Drawing.Point(252, 0);
            this.tlpVK.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVK.Name = "tlpVK";
            this.tlpVK.RowCount = 5;
            this.tlpVK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpVK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVK.Size = new System.Drawing.Size(96, 367);
            this.tlpVK.TabIndex = 2;
            // 
            // bnVKHome
            // 
            this.bnVKHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnVKHome.BackgroundImage")));
            this.bnVKHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnVKHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnVKHome.Location = new System.Drawing.Point(1, 1);
            this.bnVKHome.Margin = new System.Windows.Forms.Padding(0);
            this.bnVKHome.Name = "bnVKHome";
            this.bnVKHome.Size = new System.Drawing.Size(94, 32);
            this.bnVKHome.TabIndex = 0;
            this.bnVKHome.UseVisualStyleBackColor = true;
            this.bnVKHome.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnVKUp
            // 
            this.bnVKUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnVKUp.BackgroundImage")));
            this.bnVKUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnVKUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnVKUp.Location = new System.Drawing.Point(1, 34);
            this.bnVKUp.Margin = new System.Windows.Forms.Padding(0);
            this.bnVKUp.Name = "bnVKUp";
            this.bnVKUp.Size = new System.Drawing.Size(94, 32);
            this.bnVKUp.TabIndex = 0;
            this.bnVKUp.UseVisualStyleBackColor = true;
            this.bnVKUp.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnVKDown
            // 
            this.bnVKDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnVKDown.BackgroundImage")));
            this.bnVKDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnVKDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnVKDown.Location = new System.Drawing.Point(1, 67);
            this.bnVKDown.Margin = new System.Windows.Forms.Padding(0);
            this.bnVKDown.Name = "bnVKDown";
            this.bnVKDown.Size = new System.Drawing.Size(94, 32);
            this.bnVKDown.TabIndex = 0;
            this.bnVKDown.UseVisualStyleBackColor = true;
            this.bnVKDown.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnVKEnd
            // 
            this.bnVKEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnVKEnd.BackgroundImage")));
            this.bnVKEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnVKEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnVKEnd.Location = new System.Drawing.Point(1, 100);
            this.bnVKEnd.Margin = new System.Windows.Forms.Padding(0);
            this.bnVKEnd.Name = "bnVKEnd";
            this.bnVKEnd.Size = new System.Drawing.Size(94, 32);
            this.bnVKEnd.TabIndex = 0;
            this.bnVKEnd.UseVisualStyleBackColor = true;
            this.bnVKEnd.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // tlpViewMode
            // 
            this.tlpViewMode.ColumnCount = 3;
            this.tlpViewMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpViewMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpViewMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpViewMode.Controls.Add(this.cbTextView, 0, 0);
            this.tlpViewMode.Controls.Add(this.cbPreView, 1, 0);
            this.tlpViewMode.Controls.Add(this.cbSettingsView, 2, 0);
            this.tlpViewMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewMode.Location = new System.Drawing.Point(1, 34);
            this.tlpViewMode.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewMode.Name = "tlpViewMode";
            this.tlpViewMode.RowCount = 1;
            this.tlpViewMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewMode.Size = new System.Drawing.Size(1044, 32);
            this.tlpViewMode.TabIndex = 2;
            // 
            // cbTextView
            // 
            this.cbTextView.AutoSize = true;
            this.cbTextView.Checked = true;
            this.cbTextView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTextView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTextView.Location = new System.Drawing.Point(3, 3);
            this.cbTextView.Name = "cbTextView";
            this.cbTextView.Size = new System.Drawing.Size(342, 26);
            this.cbTextView.TabIndex = 0;
            this.cbTextView.Text = "Text";
            this.cbTextView.UseVisualStyleBackColor = true;
            this.cbTextView.CheckedChanged += new System.EventHandler(this.cbTextView_CheckedChanged);
            // 
            // cbPreView
            // 
            this.cbPreView.AutoSize = true;
            this.cbPreView.Checked = true;
            this.cbPreView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPreView.Location = new System.Drawing.Point(351, 3);
            this.cbPreView.Name = "cbPreView";
            this.cbPreView.Size = new System.Drawing.Size(342, 26);
            this.cbPreView.TabIndex = 0;
            this.cbPreView.Text = "Preview";
            this.cbPreView.UseVisualStyleBackColor = true;
            this.cbPreView.CheckedChanged += new System.EventHandler(this.cbTextView_CheckedChanged);
            // 
            // cbSettingsView
            // 
            this.cbSettingsView.AutoSize = true;
            this.cbSettingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSettingsView.Location = new System.Drawing.Point(699, 3);
            this.cbSettingsView.Name = "cbSettingsView";
            this.cbSettingsView.Size = new System.Drawing.Size(342, 26);
            this.cbSettingsView.TabIndex = 0;
            this.cbSettingsView.Text = "Settings";
            this.cbSettingsView.UseVisualStyleBackColor = true;
            this.cbSettingsView.CheckedChanged += new System.EventHandler(this.cbTextView_CheckedChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 467);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fMain";
            this.Text = "txt2img";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            this.tlpView.ResumeLayout(false);
            this.tlpSettings.ResumeLayout(false);
            this.tlpSettingsControls.ResumeLayout(false);
            this.tlpText.ResumeLayout(false);
            this.tlpText.PerformLayout();
            this.tlpTextControls.ResumeLayout(false);
            this.tlpTextControls.PerformLayout();
            this.tlpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.tlpVK.ResumeLayout(false);
            this.tlpViewMode.ResumeLayout(false);
            this.tlpViewMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpMain;
        public System.Windows.Forms.TableLayoutPanel tlpMenu;
        public System.Windows.Forms.Button bnExit;
        public System.Windows.Forms.Button bnDraw;
        public System.Windows.Forms.TableLayoutPanel tlpView;
        public System.Windows.Forms.PropertyGrid pgSettings;
        public System.Windows.Forms.Button bnFile;
        public System.Windows.Forms.PictureBox pbView;
        public System.Windows.Forms.TextBox tbFile;
        public System.Windows.Forms.TableLayoutPanel tlpSettings;
        public System.Windows.Forms.TableLayoutPanel tlpSettingsControls;
        public System.Windows.Forms.Button bnSettingsLoad;
        public System.Windows.Forms.Button bnSettingsSave;
        public System.Windows.Forms.TextBox tbText;
        public System.Windows.Forms.TableLayoutPanel tlpText;
        public System.Windows.Forms.ComboBox cmbTextEncoding;
        public System.Windows.Forms.TableLayoutPanel tlpTextControls;
        public System.Windows.Forms.Button bnPrint;
        public System.Windows.Forms.TableLayoutPanel tlpViewMode;
        public System.Windows.Forms.TableLayoutPanel tlpPreview;
        public System.Windows.Forms.TableLayoutPanel tlpVK;
        public System.Windows.Forms.Button bnVKHome;
        public System.Windows.Forms.Button bnVKUp;
        public System.Windows.Forms.Button bnVKDown;
        public System.Windows.Forms.Button bnVKEnd;
        private System.Windows.Forms.CheckBox cbTextView;
        private System.Windows.Forms.CheckBox cbPreView;
        private System.Windows.Forms.CheckBox cbSettingsView;
    }
}

