using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    public partial class FormEditareClient : Form
    {
        Clienti client;
        public FormEditareClient(Clienti client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormEditareClient_Load(object sender, EventArgs e)
        {
            tbNumeClient.Text = client.NumeClient;
            tbCNP.Text = Convert.ToString(client.CnpClient);
            tbAdresa.Text = client.Adresa;
            tbNrTelefon.Text = Convert.ToString(client.NrTelefonClient);
            tbNrComanda.Text = Convert.ToString(client.NrComanda);
        }

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            client.NumeClient = tbNumeClient.Text;
            client.CnpClient = double.Parse(tbCNP.Text);
            client.Adresa = tbAdresa.Text;
            client.NrTelefonClient = double.Parse(tbNrTelefon.Text);
            client.NrComanda = Convert.ToInt32(tbNrComanda.Text);
        }
    }
}
