using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tercera_Tarea_Prog_3.Reportes
{
    public partial class frmReportes : Form
    {
        public frmReportes(ReportDocument rp)
        {
            InitializeComponent();
            
            reportCrystalReportViewer.ReportSource = rp;
           // reportCrystalReportViewer.Refresh();
        }

        private void reportCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
