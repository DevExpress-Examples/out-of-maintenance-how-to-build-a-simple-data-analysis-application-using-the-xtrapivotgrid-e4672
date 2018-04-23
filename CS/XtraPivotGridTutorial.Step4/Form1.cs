using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
