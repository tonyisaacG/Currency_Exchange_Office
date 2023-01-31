using Currency_Exchange_Office.client;
using Currency_Exchange_Office.financialTransaction;
using Currency_Exchange_Office.treaders;
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

namespace Currency_Exchange_Office.mainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openClientForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }
        void openClientForm()
        {
            Application.Run(new clientForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(opentreaderForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void opentreaderForm()
        {
            Application.Run(new traderForm());
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(opentraderForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void opentraderForm()
        {
            Application.Run(new traderForm());
        }

    }
}
