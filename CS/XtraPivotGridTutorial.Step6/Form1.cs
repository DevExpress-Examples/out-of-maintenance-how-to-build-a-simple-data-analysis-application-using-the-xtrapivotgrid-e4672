using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraCharts;

namespace XtraPivotGridTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xtraPivotGridTutorialViewTableAdapter.Fill(nwindDataSet.XtraPivotGridTutorialView);
            pivotGridControl1.BestFit();
            pivotGridControl1.FieldsCustomization(splitContainerControl1.Panel1);
            pivotGridControl1.CollapseAll();
          
        }

        private void pivotGridControl1_ShowingCustomizationForm(object sender, DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs e)
        {
            e.ParentControl = splitContainerControl1.Panel1;
        }


        private void previewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CompositeLink compositeLink = CreateCompositeLink(pivotGridControl1, chartControl1);
            compositeLink.ShowPreview();
        }

        private void exportToXLSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                CompositeLink compositeLink = CreateCompositeLink(pivotGridControl1, chartControl1);
                compositeLink.ExportToXlsx(saveFileDialog1.FileName);
            }
        }

        CompositeLink CreateCompositeLink(PivotGridControl pivotGridControl, ChartControl chartControl)
        {
            CompositeLink compositeLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pivotLink = new PrintableComponentLink();
            pivotLink.Component = pivotGridControl;
            PrintableComponentLink chartLink = new PrintableComponentLink();
            chartLink.Component = chartControl;
            compositeLink.Links.AddRange(new object[] { pivotLink, chartLink });
            return compositeLink;
        }

        

       
    }
}
