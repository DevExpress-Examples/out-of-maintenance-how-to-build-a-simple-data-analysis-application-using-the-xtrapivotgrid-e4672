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
            compositeLink1.ShowPreview();
        }

        private void exportToXLSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                compositeLink1.ExportToXlsx(saveFileDialog1.FileName);
            }
        }
        

       
    }
}
