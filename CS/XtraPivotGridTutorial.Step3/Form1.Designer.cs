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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFreight1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipperCompany1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate4 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
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
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
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
            this.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
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
            this.fieldOrderDate3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
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
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pivotGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1012, 541);
            this.splitContainerControl1.SplitterPosition = 312;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.fieldOrderDate4});
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
            this.pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.RowArea;
            this.pivotGridControl1.OptionsDataField.AreaIndex = 2;
            this.pivotGridControl1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(695, 541);
            this.pivotGridControl1.TabIndex = 1;
            this.pivotGridControl1.ShowingCustomizationForm += new DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(this.pivotGridControl1_ShowingCustomizationForm);
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
            this.fieldExtendedPrice1.AreaIndex = 0;
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
            this.fieldFreight1.AreaIndex = 0;
            this.fieldFreight1.Caption = "Freight";
			this.fieldFreight1.CellFormat.FormatString = "C0";
            this.fieldFreight1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFreight1.DisplayFolder = "Measures";
            this.fieldFreight1.FieldName = "Freight";
            this.fieldFreight1.Name = "fieldFreight1";
            this.fieldFreight1.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "XtraPivotGridTutorial.Step3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NwindDataSet.nwindDataSet nwindDataSet;
        private NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter xtraPivotGridTutorialViewTableAdapter;
        private System.Windows.Forms.BindingSource xtraPivotGridTutorialBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
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
    }
}

