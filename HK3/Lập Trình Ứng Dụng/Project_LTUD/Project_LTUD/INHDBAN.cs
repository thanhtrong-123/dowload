using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Project_LTUD
{
    public partial class INHDBAN : Form
    {
        public INHDBAN()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = txtmakh.Text;
            para.Add(val);

            rpthdban b = new rpthdban();
            b.DataDefinition.ParameterFields["@MAKH"].ApplyCurrentValues(para);
            crystalReportViewer1.ReportSource = b;
        }

        private void INHDBAN_Load(object sender, EventArgs e)
        {

        }
    }
}
