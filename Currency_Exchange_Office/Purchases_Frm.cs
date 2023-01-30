using Currency_Exchange_Office.mainForm;
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
    public partial class Purchases_Frm : Form
    {
        public Purchases_Frm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openTraderForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void openTraderForm()
        {
            Application.Run(new traderForm());
        }
    }
}
