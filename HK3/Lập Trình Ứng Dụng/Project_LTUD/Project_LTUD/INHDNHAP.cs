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
    public partial class INHDNHAP : Form
    {
        public INHDNHAP()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = txtmancc.Text;
            para.Add(val);

            rpthdnhap n = new rpthdnhap();
            n.DataDefinition.ParameterFields["@MANHACC"].ApplyCurrentValues(para);
            crystalReportViewer1.ReportSource = n;
        }
    }
}
