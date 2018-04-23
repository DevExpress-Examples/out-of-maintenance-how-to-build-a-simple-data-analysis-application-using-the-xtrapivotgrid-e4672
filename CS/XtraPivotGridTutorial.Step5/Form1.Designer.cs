namespace XtraPivotGridTutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel1 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xtraPivotGridTutorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new NwindDataSet.nwindDataSet();
            this.xtraPivotGridTutorialViewTableAdapter = new NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFreight1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipperCompany1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFreightPercentage = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Year";
            this.fieldOrderDate.DisplayFolder = "Dimensions\\Dates";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate1.AreaIndex = 1;
            this.fieldOrderDate1.Caption = "Quarter";
            this.fieldOrderDate1.DisplayFolder = "Dimensions\\Dates";
            this.fieldOrderDate1.ExpandedInFieldsGroup = false;
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            this.fieldOrderDate1.ValueFormat.FormatString = "Quarter {0}";
            this.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldOrderDate2
            // 
            this.fieldOrderDate2.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate2.AreaIndex = 2;
            this.fieldOrderDate2.Caption = "Month";
            this.fieldOrderDate2.DisplayFolder = "Dimensions\\Dates";
            this.fieldOrderDate2.ExpandedInFieldsGroup = false;
            this.fieldOrderDate2.FieldName = "OrderDate";
            this.fieldOrderDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderDate2.Name = "fieldOrderDate2";
            this.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2";
            this.fieldOrderDate2.Visible = false;
            // 
            // fieldOrderDate3
            // 
            this.fieldOrderDate3.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate3.AreaIndex = 3;
            this.fieldOrderDate3.Caption = "Day";
            this.fieldOrderDate3.DisplayFolder = "Dimensions\\Dates";
            this.fieldOrderDate3.FieldName = "OrderDate";
            this.fieldOrderDate3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
            this.fieldOrderDate3.Name = "fieldOrderDate3";
            this.fieldOrderDate3.UnboundFieldName = "fieldOrderDate3";
            this.fieldOrderDate3.Visible = false;
            // 
            // fieldShipCountry1
            // 
            this.fieldShipCountry1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldShipCountry1.AreaIndex = 0;
            this.fieldShipCountry1.Caption = "Ship Country";
            this.fieldShipCountry1.DisplayFolder = "Dimensions\\Geography";
            this.fieldShipCountry1.FieldName = "ShipCountry";
            this.fieldShipCountry1.Name = "fieldShipCountry1";
            this.fieldShipCountry1.Visible = false;
            // 
            // fieldShipCity1
            // 
            this.fieldShipCity1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldShipCity1.AreaIndex = 1;
            this.fieldShipCity1.Caption = "Ship City";
            this.fieldShipCity1.DisplayFolder = "Dimensions\\Geography";
            this.fieldShipCity1.FieldName = "ShipCity";
            this.fieldShipCity1.Name = "fieldShipCity1";
            this.fieldShipCity1.Visible = false;
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category";
            this.fieldCategoryName1.DisplayFolder = "Dimensions\\Products";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product";
            this.fieldProductName1.DisplayFolder = "Dimensions\\Products";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // xtraPivotGridTutorialBindingSource
            // 
            this.xtraPivotGridTutorialBindingSource.DataMember = "XtraPivotGridTutorialView";
            this.xtraPivotGridTutorialBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraPivotGridTutorialViewTableAdapter
            // 
            this.xtraPivotGridTutorialViewTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Collapsed = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(732, 541);
            this.splitContainerControl1.SplitterPosition = 312;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.pivotGridControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(415, 541);
            this.splitContainerControl2.SplitterPosition = 326;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.xtraPivotGridTutorialBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName1,
            this.fieldProductName1,
            this.fieldUnitPrice1,
            this.fieldQuantity1,
            this.fieldPrice1,
            this.fieldExtendedPrice1,
            this.fieldFreight1,
            this.fieldSalesPerson1,
            this.fieldShipCountry1,
            this.fieldShipCity1,
            this.fieldShipperCompany1,
            this.fieldOrderDate,
            this.fieldOrderDate1,
            this.fieldOrderDate2,
            this.fieldOrderDate3,
            this.fieldOrderDate4,
            this.fieldDiscount,
            this.fieldFreightPercentage});
            pivotGridGroup1.Caption = "Calendar";
            pivotGridGroup1.Fields.Add(this.fieldOrderDate);
            pivotGridGroup1.Fields.Add(this.fieldOrderDate1);
            pivotGridGroup1.Fields.Add(this.fieldOrderDate2);
            pivotGridGroup1.Fields.Add(this.fieldOrderDate3);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            pivotGridGroup2.Caption = "Ship Info";
            pivotGridGroup2.Fields.Add(this.fieldShipCountry1);
            pivotGridGroup2.Fields.Add(this.fieldShipCity1);
            pivotGridGroup2.Hierarchy = null;
            pivotGridGroup2.ShowNewValues = true;
            pivotGridGroup3.Caption = "Product Info";
            pivotGridGroup3.Fields.Add(this.fieldCategoryName1);
            pivotGridGroup3.Fields.Add(this.fieldProductName1);
            pivotGridGroup3.Hierarchy = null;
            pivotGridGroup3.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2,
            pivotGridGroup3});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues;
            this.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.pivotGridControl1.OptionsDataField.AreaIndex = 0;
            this.pivotGridControl1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(415, 326);
            this.pivotGridControl1.TabIndex = 2;
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldUnitPrice1.AreaIndex = 0;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.DisplayFolder = "Dimensions\\Products";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            this.fieldUnitPrice1.Visible = false;
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity1.AreaIndex = 1;
            this.fieldQuantity1.Caption = "Quantity";
            this.fieldQuantity1.DisplayFolder = "Measures";
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            this.fieldQuantity1.Visible = false;
            // 
            // fieldPrice1
            // 
            this.fieldPrice1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPrice1.AreaIndex = 0;
            this.fieldPrice1.Caption = "Amount";
            this.fieldPrice1.CellFormat.FormatString = "C0";
            this.fieldPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPrice1.DisplayFolder = "Measures";
            this.fieldPrice1.FieldName = "Price";
            this.fieldPrice1.Name = "fieldPrice1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.Caption = "Extended Amount";
            this.fieldExtendedPrice1.CellFormat.FormatString = "C0";
            this.fieldExtendedPrice1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice1.DisplayFolder = "Measures";
            this.fieldExtendedPrice1.FieldName = "ExtendedPrice";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            this.fieldExtendedPrice1.Visible = false;
            // 
            // fieldFreight1
            // 
            this.fieldFreight1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldFreight1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFreight1.AreaIndex = 2;
            this.fieldFreight1.Caption = "Freight";
            this.fieldFreight1.CellFormat.FormatString = "C0";
            this.fieldFreight1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFreight1.DisplayFolder = "Measures";
            this.fieldFreight1.FieldName = "Freight";
            this.fieldFreight1.Name = "fieldFreight1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.DisplayFolder = "Dimensions";
            this.fieldSalesPerson1.FieldName = "SalesPerson";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            this.fieldSalesPerson1.Visible = false;
            // 
            // fieldShipperCompany1
            // 
            this.fieldShipperCompany1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldShipperCompany1.AreaIndex = 0;
            this.fieldShipperCompany1.Caption = "Shipper Company";
            this.fieldShipperCompany1.DisplayFolder = "Dimensions";
            this.fieldShipperCompany1.FieldName = "ShipperCompany";
            this.fieldShipperCompany1.Name = "fieldShipperCompany1";
            this.fieldShipperCompany1.Visible = false;
            // 
            // fieldOrderDate4
            // 
            this.fieldOrderDate4.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate4.AreaIndex = 4;
            this.fieldOrderDate4.Caption = "Date";
            this.fieldOrderDate4.DisplayFolder = "Dimensions\\Dates";
            this.fieldOrderDate4.FieldName = "OrderDate";
            this.fieldOrderDate4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldOrderDate4.Name = "fieldOrderDate4";
            this.fieldOrderDate4.UnboundFieldName = "fieldOrderDate4";
            this.fieldOrderDate4.Visible = false;
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 1;
            this.fieldDiscount.Caption = "Discount";
            this.fieldDiscount.CellFormat.FormatString = "C0";
            this.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDiscount.DisplayFolder = "Measures";
            this.fieldDiscount.FieldName = "DiscountAmount";
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.UnboundExpression = "Abs([fieldExtendedPrice1] - [fieldPrice1])";
            this.fieldDiscount.UnboundFieldName = "fieldDiscountAmount";
            this.fieldDiscount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // fieldFreightPercentage
            // 
            this.fieldFreightPercentage.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldFreightPercentage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldFreightPercentage.AreaIndex = 2;
            this.fieldFreightPercentage.Caption = "Freight %";
            this.fieldFreightPercentage.CellFormat.FormatString = "P";
            this.fieldFreightPercentage.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFreightPercentage.DisplayFolder = "Measures";
            this.fieldFreightPercentage.FieldName = "FreightPercentage";
            this.fieldFreightPercentage.Name = "fieldFreightPercentage";
            this.fieldFreightPercentage.UnboundExpression = "[fieldFreight1] / ([fieldFreight1] + [fieldExtendedPrice1])";
            this.fieldFreightPercentage.UnboundFieldName = "fFreightPercentage";
            this.fieldFreightPercentage.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.fieldFreightPercentage.Visible = false;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Title.Text = "Category Product";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Currency;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Title.Text = "Amount Discount Freight";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.MaxVerticalPercentage = 30;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:C2}";
            this.chartControl1.SeriesTemplate.Label = stackedBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.SeriesTemplate.View = stackedBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(415, 210);
            this.chartControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 541);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "XtraPivotGridTutorial.Step5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NwindDataSet.nwindDataSet nwindDataSet;
        private NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter xtraPivotGridTutorialViewTableAdapter;
        private System.Windows.Forms.BindingSource xtraPivotGridTutorialBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFreight1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipCity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipperCompany1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate4;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFreightPercentage;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

