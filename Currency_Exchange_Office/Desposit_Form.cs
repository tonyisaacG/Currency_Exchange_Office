using Currency_Exchange_Office.mainForm;
using Entities;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange_Office
{
    public partial class Desposit_Form : Form
    {
        private readonly IServicesManager servicesManager;
        public Desposit_Form(IServicesManager _servicesManager) :base()
        {
            servicesManager = _servicesManager;
            InitializeComponent();
        }
    
     
        private void button5_Click(object sender, EventArgs e)
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

        private void GetDataClientBtn_Click(object sender, EventArgs e)
        {
            var client = DataClientGroup_Comp.SelectedItem as Client;
            Client_id.Text = client.Client_id.ToString();
            Despt_money_prv.Text = client.Client_money.ToString();
        }

        private void Desposit_Form_Load(object sender, EventArgs e)
        {
            var clients = servicesManager.DespositeService.GetAllClients(false);
            DataClientGroup_Comp.DataSource = clients;
            DataClientGroup_Comp.ValueMember = "Client_id";
            DataClientGroup_Comp.DisplayMember= "Client_name";
        }

        private void Despt_money_add_TextChanged(object sender, EventArgs e)
        {
            // System.FormatException: 'Input string was not in a correct format.'
            decimal prev;
            decimal add;
            decimal.TryParse(Despt_money_prv.Text, out prev);
            decimal.TryParse(Despt_money_add.Text, out add);
            var Diff =  prev-add ;
            if (Diff < 0)
            {
                MessageBox.Show("لا يوجد مالى كافى للسحب");
                Despt_money_now.Clear();
                Despt_money_add.Clear();
            }
            else
            {
                Despt_money_now.Clear();

                if (add>0)
                    Despt_money_now.Text = Diff.ToString();

            }
        }
    }
}
