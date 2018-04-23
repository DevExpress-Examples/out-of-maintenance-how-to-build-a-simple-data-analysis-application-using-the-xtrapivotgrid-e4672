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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.xtraPivotGridTutorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new NwindDataSet.nwindDataSet();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFreight1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipperCompany1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xtraPivotGridTutorialViewTableAdapter = new NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.xtraPivotGridTutorialBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate1,
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
            this.fieldShipperCompany1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1012, 541);
            this.pivotGridControl1.TabIndex = 0;
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
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.AreaIndex = 0;
            this.fieldOrderDate1.Caption = "Order Date";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 2;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.AreaIndex = 3;
            this.fieldQuantity1.Caption = "Quantity";
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            // 
            // fieldPrice1
            // 
            this.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPrice1.AreaIndex = 0;
            this.fieldPrice1.Caption = "Price";
            this.fieldPrice1.FieldName = "Price";
            this.fieldPrice1.Name = "fieldPrice1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.AreaIndex = 4;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "ExtendedPrice";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldFreight1
            // 
            this.fieldFreight1.AreaIndex = 5;
            this.fieldFreight1.Caption = "Freight";
            this.fieldFreight1.FieldName = "Freight";
            this.fieldFreight1.Name = "fieldFreight1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.AreaIndex = 6;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "SalesPerson";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldShipCountry1
            // 
            this.fieldShipCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShipCountry1.AreaIndex = 0;
            this.fieldShipCountry1.Caption = "Ship Country";
            this.fieldShipCountry1.FieldName = "ShipCountry";
            this.fieldShipCountry1.Name = "fieldShipCountry1";
            // 
            // fieldShipCity1
            // 
            this.fieldShipCity1.AreaIndex = 7;
            this.fieldShipCity1.Caption = "Ship City";
            this.fieldShipCity1.FieldName = "ShipCity";
            this.fieldShipCity1.Name = "fieldShipCity1";
            // 
            // fieldShipperCompany1
            // 
            this.fieldShipperCompany1.AreaIndex = 8;
            this.fieldShipperCompany1.Caption = "Shipper Company";
            this.fieldShipperCompany1.FieldName = "ShipperCompany";
            this.fieldShipperCompany1.Name = "fieldShipperCompany1";
            // 
            // xtraPivotGridTutorialViewTableAdapter
            // 
            this.xtraPivotGridTutorialViewTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "XtraPivotGridTutorial.Step1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPivotGridTutorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private NwindDataSet.nwindDataSet nwindDataSet;
        private NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter xtraPivotGridTutorialViewTableAdapter;
        private System.Windows.Forms.BindingSource xtraPivotGridTutorialBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
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
    }
}

