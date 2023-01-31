using Currency_Exchange_Office.financialTransaction;
using Currency_Exchange_Office.mainForm;
using Microsoft.Extensions.DependencyInjection;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange_Office.client
{
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(openTransactionForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        void openTransactionForm()
        {
            Application.Run(new financialTransactionForm());
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
            Application.Run(new Desposit_Form(Program.ServiceProvider.GetRequiredService<IServicesManager>()));
        }

       

        private void button7_Click(object sender, EventArgs e)
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
