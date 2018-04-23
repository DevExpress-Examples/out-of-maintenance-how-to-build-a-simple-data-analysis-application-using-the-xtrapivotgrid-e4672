Namespace XtraPivotGridTutorial
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.xtraPivotGridTutorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New NwindDataSet.nwindDataSet()
            Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldFreight1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipCity1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShipperCompany1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.xtraPivotGridTutorialViewTableAdapter = New NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xtraPivotGridTutorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.xtraPivotGridTutorialBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderDate1, Me.fieldCategoryName1, Me.fieldProductName1, Me.fieldUnitPrice1, Me.fieldQuantity1, Me.fieldPrice1, Me.fieldExtendedPrice1, Me.fieldFreight1, Me.fieldSalesPerson1, Me.fieldShipCountry1, Me.fieldShipCity1, Me.fieldShipperCompany1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(1012, 541)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' xtraPivotGridTutorialBindingSource
            ' 
            Me.xtraPivotGridTutorialBindingSource.DataMember = "XtraPivotGridTutorialView"
            Me.xtraPivotGridTutorialBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldOrderDate1
            ' 
            Me.fieldOrderDate1.AreaIndex = 0
            Me.fieldOrderDate1.Caption = "Order Date"
            Me.fieldOrderDate1.FieldName = "OrderDate"
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            Me.fieldCategoryName1.FieldName = "CategoryName"
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "Product Name"
            Me.fieldProductName1.FieldName = "ProductName"
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' fieldUnitPrice1
            ' 
            Me.fieldUnitPrice1.AreaIndex = 2
            Me.fieldUnitPrice1.Caption = "Unit Price"
            Me.fieldUnitPrice1.FieldName = "UnitPrice"
            Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
            ' 
            ' fieldQuantity1
            ' 
            Me.fieldQuantity1.AreaIndex = 3
            Me.fieldQuantity1.Caption = "Quantity"
            Me.fieldQuantity1.FieldName = "Quantity"
            Me.fieldQuantity1.Name = "fieldQuantity1"
            ' 
            ' fieldPrice1
            ' 
            Me.fieldPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPrice1.AreaIndex = 0
            Me.fieldPrice1.Caption = "Price"
            Me.fieldPrice1.FieldName = "Price"
            Me.fieldPrice1.Name = "fieldPrice1"
            ' 
            ' fieldExtendedPrice1
            ' 
            Me.fieldExtendedPrice1.AreaIndex = 4
            Me.fieldExtendedPrice1.Caption = "Extended Price"
            Me.fieldExtendedPrice1.FieldName = "ExtendedPrice"
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            ' 
            ' fieldFreight1
            ' 
            Me.fieldFreight1.AreaIndex = 5
            Me.fieldFreight1.Caption = "Freight"
            Me.fieldFreight1.FieldName = "Freight"
            Me.fieldFreight1.Name = "fieldFreight1"
            ' 
            ' fieldSalesPerson1
            ' 
            Me.fieldSalesPerson1.AreaIndex = 6
            Me.fieldSalesPerson1.Caption = "Sales Person"
            Me.fieldSalesPerson1.FieldName = "SalesPerson"
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            ' 
            ' fieldShipCountry1
            ' 
            Me.fieldShipCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShipCountry1.AreaIndex = 0
            Me.fieldShipCountry1.Caption = "Ship Country"
            Me.fieldShipCountry1.FieldName = "ShipCountry"
            Me.fieldShipCountry1.Name = "fieldShipCountry1"
            ' 
            ' fieldShipCity1
            ' 
            Me.fieldShipCity1.AreaIndex = 7
            Me.fieldShipCity1.Caption = "Ship City"
            Me.fieldShipCity1.FieldName = "ShipCity"
            Me.fieldShipCity1.Name = "fieldShipCity1"
            ' 
            ' fieldShipperCompany1
            ' 
            Me.fieldShipperCompany1.AreaIndex = 8
            Me.fieldShipperCompany1.Caption = "Shipper Company"
            Me.fieldShipperCompany1.FieldName = "ShipperCompany"
            Me.fieldShipperCompany1.Name = "fieldShipperCompany1"
            ' 
            ' xtraPivotGridTutorialViewTableAdapter
            ' 
            Me.xtraPivotGridTutorialViewTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1012, 541)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "XtraPivotGridTutorial.Step1"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xtraPivotGridTutorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As NwindDataSet.nwindDataSet
        Private xtraPivotGridTutorialViewTableAdapter As NwindDataSet.nwindDataSetTableAdapters.XtraPivotGridTutorialViewTableAdapter
        Private xtraPivotGridTutorialBindingSource As System.Windows.Forms.BindingSource
        Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldFreight1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipCountry1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipCity1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShipperCompany1 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

