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
		End Sub
	End Class
End Namespace
