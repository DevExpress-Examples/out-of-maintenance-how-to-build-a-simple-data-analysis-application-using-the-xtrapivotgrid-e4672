Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts

Namespace XtraPivotGridTutorial
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            xtraPivotGridTutorialViewTableAdapter.Fill(nwindDataSet.XtraPivotGridTutorialView)
            pivotGridControl1.BestFit()
            pivotGridControl1.FieldsCustomization(splitContainerControl1.Panel1)
            pivotGridControl1.CollapseAll()

        End Sub

        Private Sub pivotGridControl1_ShowingCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs)
            e.ParentControl = splitContainerControl1.Panel1
        End Sub


        Private Sub previewToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles previewToolStripMenuItem.Click
            Dim compositeLink As CompositeLink = CreateCompositeLink(pivotGridControl1, chartControl1)
            compositeLink.ShowPreview()
        End Sub

        Private Sub exportToXLSXToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exportToXLSXToolStripMenuItem.Click
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx"
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName <> "" Then
                Dim compositeLink As CompositeLink = CreateCompositeLink(pivotGridControl1, chartControl1)
                compositeLink.ExportToXlsx(saveFileDialog1.FileName)
            End If
        End Sub

        Private Function CreateCompositeLink(ByVal pivotGridControl As PivotGridControl, ByVal chartControl As ChartControl) As CompositeLink
            Dim compositeLink As New CompositeLink(New PrintingSystem())
            Dim pivotLink As New PrintableComponentLink()
            pivotLink.Component = pivotGridControl
            Dim chartLink As New PrintableComponentLink()
            chartLink.Component = chartControl
            compositeLink.Links.AddRange(New Object() { pivotLink, chartLink })
            Return compositeLink
        End Function




    End Class
End Namespace
