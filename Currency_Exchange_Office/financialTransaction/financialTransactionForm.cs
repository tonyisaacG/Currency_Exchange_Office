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

namespace Currency_Exchange_Office.financialTransaction
{
    public partial class financialTransactionForm : Form
    {
        public financialTransactionForm()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(openDespositForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void openDespositForm()
        {
            Application.Run(new Desposit_Form());
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
