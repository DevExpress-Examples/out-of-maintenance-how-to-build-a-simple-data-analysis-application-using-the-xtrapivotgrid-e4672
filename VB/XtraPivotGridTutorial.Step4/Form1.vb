Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

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

		Private Sub pivotGridControl1_ShowingCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs) Handles pivotGridControl1.ShowingCustomizationForm
			e.ParentControl = splitContainerControl1.Panel1
		End Sub
	End Class
End Namespace
