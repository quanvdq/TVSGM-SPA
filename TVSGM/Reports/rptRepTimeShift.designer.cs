namespace Reports
{
    /// <summary>
    /// Summary description for RepCustomer.
    /// </summary>
    partial class rptRepTimeShift
    {
        private DataDynamics.ActiveReports.Detail detail;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptRepTimeShift));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.textBox8 = new DataDynamics.ActiveReports.TextBox();
            this.ghcatalog = new DataDynamics.ActiveReports.GroupHeader();
            this.gfcatalog = new DataDynamics.ActiveReports.GroupFooter();
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.label21 = new DataDynamics.ActiveReports.Label();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.line28 = new DataDynamics.ActiveReports.Line();
            this.line30 = new DataDynamics.ActiveReports.Line();
            this.line32 = new DataDynamics.ActiveReports.Line();
            this.line33 = new DataDynamics.ActiveReports.Line();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.lblPrintTime = new DataDynamics.ActiveReports.Label();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.lblComName = new DataDynamics.ActiveReports.Label();
            this.lblComAddress = new DataDynamics.ActiveReports.Label();
            this.lblComPhone = new DataDynamics.ActiveReports.Label();
            this.lblBillHeader = new DataDynamics.ActiveReports.Label();
            this.lblDateTime = new DataDynamics.ActiveReports.Label();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.label13 = new DataDynamics.ActiveReports.Label();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.label4 = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrintTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox8});
            this.detail.Height = 0.25F;
            this.detail.Name = "detail";
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Height = 0.25F;
            this.textBox1.Left = 0F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "ddo-char-set: 1; text-align: center; font-size: 9pt; font-family: Arial; vertical" +
                "-align: middle; ";
            this.textBox1.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Count;
            this.textBox1.SummaryGroup = "ghcatalog";
            this.textBox1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.textBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox1.Text = "text";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 0.4375F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.TopColor = System.Drawing.Color.Black;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.DataField = "CodeEmp";
            this.textBox2.DistinctField = "11";
            this.textBox2.Height = 0.25F;
            this.textBox2.Left = 0.4375F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "ddo-char-set: 1; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" +
                "lign: middle; ";
            this.textBox2.Text = "textBox1";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.895833F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.RightColor = System.Drawing.Color.Black;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.TopColor = System.Drawing.Color.Black;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.DataField = "NameEmp";
            this.textBox3.Height = 0.25F;
            this.textBox3.Left = 2.3125F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "ddo-char-set: 1; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" +
                "lign: middle; ";
            this.textBox3.Text = "textBox1";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 4.041667F;
            // 
            // textBox8
            // 
            this.textBox8.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.RightColor = System.Drawing.Color.Black;
            this.textBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.TopColor = System.Drawing.Color.Black;
            this.textBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox8.DataField = "TotalTime";
            this.textBox8.Height = 0.25F;
            this.textBox8.Left = 6.364583F;
            this.textBox8.MultiLine = false;
            this.textBox8.Name = "textBox8";
            this.textBox8.OutputFormat = resources.GetString("textBox8.OutputFormat");
            this.textBox8.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 9pt; font-fam" +
                "ily: Arial; vertical-align: middle; ";
            this.textBox8.Text = "textBox1";
            this.textBox8.Top = 0F;
            this.textBox8.Width = 1.229167F;
            // 
            // ghcatalog
            // 
            this.ghcatalog.DataField = "billID";
            this.ghcatalog.Height = 0F;
            this.ghcatalog.Name = "ghcatalog";
            // 
            // gfcatalog
            // 
            this.gfcatalog.Height = 0F;
            this.gfcatalog.Name = "gfcatalog";
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label5,
            this.label21,
            this.label7,
            this.line28,
            this.line30,
            this.line32,
            this.line33,
            this.label9});
            this.pageHeader.Height = 0.2604167F;
            this.pageHeader.Name = "pageHeader";
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.Black;
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.LeftColor = System.Drawing.Color.Black;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.TopColor = System.Drawing.Color.Black;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Height = 0.3125F;
            this.label5.HyperLink = null;
            this.label5.Left = 0F;
            this.label5.LineSpacing = 2F;
            this.label5.Name = "label5";
            this.label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " +
                "font-size: 9.75pt; vertical-align: middle; ";
            this.label5.Text = "TT";
            this.label5.Top = 0F;
            this.label5.Width = 0.4375F;
            // 
            // label21
            // 
            this.label21.Border.BottomColor = System.Drawing.Color.Black;
            this.label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label21.Border.LeftColor = System.Drawing.Color.Black;
            this.label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label21.Border.RightColor = System.Drawing.Color.Black;
            this.label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label21.Border.TopColor = System.Drawing.Color.Black;
            this.label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label21.Height = 0.3125F;
            this.label21.HyperLink = null;
            this.label21.Left = 0.4375F;
            this.label21.Name = "label21";
            this.label21.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " +
                "font-size: 9.75pt; vertical-align: middle; ";
            this.label21.Text = "Mã nhân viên";
            this.label21.Top = 0F;
            this.label21.Width = 1.895833F;
            // 
            // label7
            // 
            this.label7.Border.BottomColor = System.Drawing.Color.Black;
            this.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label7.Border.LeftColor = System.Drawing.Color.Black;
            this.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label7.Border.RightColor = System.Drawing.Color.Black;
            this.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.TopColor = System.Drawing.Color.Black;
            this.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label7.Height = 0.3125F;
            this.label7.HyperLink = null;
            this.label7.Left = 2.3125F;
            this.label7.Name = "label7";
            this.label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " +
                "font-size: 9.75pt; vertical-align: middle; ";
            this.label7.Text = "Tên nhân viên";
            this.label7.Top = 0F;
            this.label7.Width = 4.041667F;
            // 
            // line28
            // 
            this.line28.Border.BottomColor = System.Drawing.Color.Black;
            this.line28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.LeftColor = System.Drawing.Color.Black;
            this.line28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.RightColor = System.Drawing.Color.Black;
            this.line28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.TopColor = System.Drawing.Color.Black;
            this.line28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Height = 0F;
            this.line28.Left = 5.6875F;
            this.line28.LineWeight = 1F;
            this.line28.Name = "line28";
            this.line28.Top = 0.375F;
            this.line28.Width = 0F;
            this.line28.X1 = 5.6875F;
            this.line28.X2 = 5.6875F;
            this.line28.Y1 = 0.375F;
            this.line28.Y2 = 0.375F;
            // 
            // line30
            // 
            this.line30.Border.BottomColor = System.Drawing.Color.Black;
            this.line30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.LeftColor = System.Drawing.Color.Black;
            this.line30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.RightColor = System.Drawing.Color.Black;
            this.line30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.TopColor = System.Drawing.Color.Black;
            this.line30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Height = 0F;
            this.line30.Left = 6.5F;
            this.line30.LineWeight = 1F;
            this.line30.Name = "line30";
            this.line30.Top = 0.375F;
            this.line30.Width = 0F;
            this.line30.X1 = 6.5F;
            this.line30.X2 = 6.5F;
            this.line30.Y1 = 0.375F;
            this.line30.Y2 = 0.375F;
            // 
            // line32
            // 
            this.line32.Border.BottomColor = System.Drawing.Color.Black;
            this.line32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.LeftColor = System.Drawing.Color.Black;
            this.line32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.RightColor = System.Drawing.Color.Black;
            this.line32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.TopColor = System.Drawing.Color.Black;
            this.line32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Height = 0F;
            this.line32.Left = 7.5F;
            this.line32.LineWeight = 1F;
            this.line32.Name = "line32";
            this.line32.Top = 0.5F;
            this.line32.Width = 0F;
            this.line32.X1 = 7.5F;
            this.line32.X2 = 7.5F;
            this.line32.Y1 = 0.5F;
            this.line32.Y2 = 0.5F;
            // 
            // line33
            // 
            this.line33.Border.BottomColor = System.Drawing.Color.Black;
            this.line33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.LeftColor = System.Drawing.Color.Black;
            this.line33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.RightColor = System.Drawing.Color.Black;
            this.line33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.TopColor = System.Drawing.Color.Black;
            this.line33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Height = 0F;
            this.line33.Left = 8.3125F;
            this.line33.LineWeight = 1F;
            this.line33.Name = "line33";
            this.line33.Top = 0.5F;
            this.line33.Width = 0F;
            this.line33.X1 = 8.3125F;
            this.line33.X2 = 8.3125F;
            this.line33.Y1 = 0.5F;
            this.line33.Y2 = 0.5F;
            // 
            // label9
            // 
            this.label9.Border.BottomColor = System.Drawing.Color.Black;
            this.label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Border.LeftColor = System.Drawing.Color.Black;
            this.label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Border.RightColor = System.Drawing.Color.Black;
            this.label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Border.TopColor = System.Drawing.Color.Black;
            this.label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Height = 0.3125F;
            this.label9.HyperLink = null;
            this.label9.Left = 6.364583F;
            this.label9.Name = "label9";
            this.label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " +
                "font-size: 9.75pt; vertical-align: middle; ";
            this.label9.Text = "Tổng công";
            this.label9.Top = 0F;
            this.label9.Width = 1.229167F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblPrintTime});
            this.pageFooter.Height = 0.18F;
            this.pageFooter.Name = "pageFooter";
            // 
            // lblPrintTime
            // 
            this.lblPrintTime.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPrintTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintTime.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPrintTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintTime.Border.RightColor = System.Drawing.Color.Black;
            this.lblPrintTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintTime.Border.TopColor = System.Drawing.Color.Black;
            this.lblPrintTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintTime.Height = 0.18F;
            this.lblPrintTime.HyperLink = null;
            this.lblPrintTime.Left = 0F;
            this.lblPrintTime.Name = "lblPrintTime";
            this.lblPrintTime.Style = "color: Gray; text-align: left; font-weight: normal; font-style: italic; backgroun" +
                "d-color: White; font-size: 9pt; vertical-align: middle; ";
            this.lblPrintTime.Text = "";
            this.lblPrintTime.Top = 0F;
            this.lblPrintTime.Width = 3.90625F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblComName,
            this.lblComAddress,
            this.lblComPhone,
            this.lblBillHeader,
            this.lblDateTime});
            this.reportHeader1.Height = 1.041667F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // lblComName
            // 
            this.lblComName.Border.BottomColor = System.Drawing.Color.Black;
            this.lblComName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComName.Border.LeftColor = System.Drawing.Color.Black;
            this.lblComName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComName.Border.RightColor = System.Drawing.Color.Black;
            this.lblComName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComName.Border.TopColor = System.Drawing.Color.Black;
            this.lblComName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComName.Height = 0.1875F;
            this.lblComName.HyperLink = null;
            this.lblComName.Left = 0F;
            this.lblComName.Name = "lblComName";
            this.lblComName.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9.75pt; vertical" +
                "-align: middle; ";
            this.lblComName.Text = "-:-";
            this.lblComName.Top = 0F;
            this.lblComName.Width = 7.59375F;
            // 
            // lblComAddress
            // 
            this.lblComAddress.Border.BottomColor = System.Drawing.Color.Black;
            this.lblComAddress.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComAddress.Border.LeftColor = System.Drawing.Color.Black;
            this.lblComAddress.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComAddress.Border.RightColor = System.Drawing.Color.Black;
            this.lblComAddress.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComAddress.Border.TopColor = System.Drawing.Color.Black;
            this.lblComAddress.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComAddress.Height = 0.1875F;
            this.lblComAddress.HyperLink = null;
            this.lblComAddress.Left = 0F;
            this.lblComAddress.Name = "lblComAddress";
            this.lblComAddress.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9.75pt; vertic" +
                "al-align: middle; ";
            this.lblComAddress.Text = "-:-";
            this.lblComAddress.Top = 0.1875F;
            this.lblComAddress.Width = 7.59375F;
            // 
            // lblComPhone
            // 
            this.lblComPhone.Border.BottomColor = System.Drawing.Color.Black;
            this.lblComPhone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComPhone.Border.LeftColor = System.Drawing.Color.Black;
            this.lblComPhone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComPhone.Border.RightColor = System.Drawing.Color.Black;
            this.lblComPhone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComPhone.Border.TopColor = System.Drawing.Color.Black;
            this.lblComPhone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblComPhone.Height = 0.1875F;
            this.lblComPhone.HyperLink = null;
            this.lblComPhone.Left = 0F;
            this.lblComPhone.Name = "lblComPhone";
            this.lblComPhone.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 9.75pt; vertic" +
                "al-align: middle; ";
            this.lblComPhone.Text = "-:-";
            this.lblComPhone.Top = 0.375F;
            this.lblComPhone.Width = 7.59375F;
            // 
            // lblBillHeader
            // 
            this.lblBillHeader.Border.BottomColor = System.Drawing.Color.Black;
            this.lblBillHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBillHeader.Border.LeftColor = System.Drawing.Color.Black;
            this.lblBillHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBillHeader.Border.RightColor = System.Drawing.Color.Black;
            this.lblBillHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBillHeader.Border.TopColor = System.Drawing.Color.Black;
            this.lblBillHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBillHeader.Height = 0.3125F;
            this.lblBillHeader.HyperLink = null;
            this.lblBillHeader.Left = 0F;
            this.lblBillHeader.Name = "lblBillHeader";
            this.lblBillHeader.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" +
                "cal-align: bottom; ";
            this.lblBillHeader.Text = "BÁO CÁO TỔNG HỢP SỐ CÔNG NHÂN VIÊN";
            this.lblBillHeader.Top = 0.5625F;
            this.lblBillHeader.Width = 7.59375F;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDateTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDateTime.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDateTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDateTime.Border.RightColor = System.Drawing.Color.Black;
            this.lblDateTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDateTime.Border.TopColor = System.Drawing.Color.Black;
            this.lblDateTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDateTime.Height = 0.1875F;
            this.lblDateTime.HyperLink = null;
            this.lblDateTime.Left = 0F;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-style: italic; fon" +
                "t-size: 9.75pt; vertical-align: middle; ";
            this.lblDateTime.Text = "-:-";
            this.lblDateTime.Top = 0.875F;
            this.lblDateTime.Width = 7.59375F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label13,
            this.label10,
            this.label4});
            this.reportFooter1.Height = 0.5833333F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // label13
            // 
            this.label13.Border.BottomColor = System.Drawing.Color.Black;
            this.label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.LeftColor = System.Drawing.Color.Black;
            this.label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.RightColor = System.Drawing.Color.Black;
            this.label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.TopColor = System.Drawing.Color.Black;
            this.label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Height = 0.34375F;
            this.label13.HyperLink = null;
            this.label13.Left = 0F;
            this.label13.Name = "label13";
            this.label13.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: normal; font-" +
                "size: 10pt; vertical-align: bottom; ";
            this.label13.Text = "Thủ trưởng đơn vị";
            this.label13.Top = 0F;
            this.label13.Width = 2.5625F;
            // 
            // label10
            // 
            this.label10.Border.BottomColor = System.Drawing.Color.Black;
            this.label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.LeftColor = System.Drawing.Color.Black;
            this.label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.RightColor = System.Drawing.Color.Black;
            this.label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.TopColor = System.Drawing.Color.Black;
            this.label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Height = 0.34375F;
            this.label10.HyperLink = null;
            this.label10.Left = 2.5625F;
            this.label10.Name = "label10";
            this.label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: normal; font-" +
                "size: 10pt; vertical-align: bottom; ";
            this.label10.Text = "Kế toán trưởng";
            this.label10.Top = 0F;
            this.label10.Width = 2.5625F;
            // 
            // label4
            // 
            this.label4.Border.BottomColor = System.Drawing.Color.Black;
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.LeftColor = System.Drawing.Color.Black;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.RightColor = System.Drawing.Color.Black;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.TopColor = System.Drawing.Color.Black;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Height = 0.34375F;
            this.label4.HyperLink = null;
            this.label4.Left = 5.125F;
            this.label4.Name = "label4";
            this.label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: normal; font-" +
                "size: 10pt; vertical-align: bottom; ";
            this.label4.Text = "Người lập biểu";
            this.label4.Top = 0F;
            this.label4.Width = 2.5625F;
            // 
            // rptRepTimeShift
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.3F;
            this.PageSettings.Margins.Left = 0.3F;
            this.PageSettings.Margins.Right = 0.1F;
            this.PageSettings.Margins.Top = 0.3F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 8.267716F;
            this.PrintWidth = 7.729167F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.ghcatalog);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.gfcatalog);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrintTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.GroupHeader ghcatalog;
        private DataDynamics.ActiveReports.GroupFooter gfcatalog;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox8;
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Label label9;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.Label label21;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.Line line28;
        private DataDynamics.ActiveReports.Line line30;
        private DataDynamics.ActiveReports.Line line32;
        private DataDynamics.ActiveReports.Line line33;
        private DataDynamics.ActiveReports.PageFooter pageFooter;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.Label lblComName;
        private DataDynamics.ActiveReports.Label lblComAddress;
        private DataDynamics.ActiveReports.Label lblComPhone;
        public DataDynamics.ActiveReports.Label lblBillHeader;
        public DataDynamics.ActiveReports.Label lblDateTime;
        private DataDynamics.ActiveReports.Label lblPrintTime;
        private DataDynamics.ActiveReports.Label label13;
        private DataDynamics.ActiveReports.Label label10;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.TextBox textBox3;
    }
}
