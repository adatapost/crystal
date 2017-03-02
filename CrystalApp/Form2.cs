using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TestReport rep = new CrystalApp.TestReport();
            rep.SetDataSource(Invoice.Invoices());
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
