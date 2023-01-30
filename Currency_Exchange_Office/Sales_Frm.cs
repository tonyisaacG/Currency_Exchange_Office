using Currency_Exchange_Office.financialTransaction;
using Currency_Exchange_Office.treaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange_Office
{
    public partial class Sales_Frm : Form
    {
        public Sales_Frm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openTreaderForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();


        }
        void openTreaderForm()
        {
            Application.Run(new traderForm());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openTreaderForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
      
    }
}
