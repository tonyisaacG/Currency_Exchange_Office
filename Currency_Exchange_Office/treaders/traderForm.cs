using Currency_Exchange_Office.mainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange_Office.treaders
{
    public partial class traderForm : Form
    {
        public traderForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openSalesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void openSalesForm()
        {


            Application.Run(new Sales_Frm());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openPurchasesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void openPurchasesForm()
        {


            Application.Run(new Purchases_Frm());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void openMainForm()
        {


            Application.Run(new MainForm());

        }
    }
    }
