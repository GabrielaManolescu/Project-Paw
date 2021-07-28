using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    public partial class FormClienti : Form
    {
        private const string ConnectionString = "Data Source=bazaDeDate.db";
        private List<Clienti> clienti;
        public FormClienti()
        {
            InitializeComponent();

            clienti = new List<Clienti>();
        }

        //buton AdaugareClienti
        private void btnAdaugareClient_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Formularul contine erori","Eroare",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }

                string numeClient = tbNumeClient.Text;
                 double cnpClient = string.IsNullOrEmpty(tbCNP.Text) ? 0 : double.Parse(tbCNP.Text);
                string adresa = tbAdresa.Text;
                double nrTelefonClient = string.IsNullOrEmpty(tbNrTelefon.Text) ? 0 : double.Parse(tbNrTelefon.Text);
                int nrComanda = string.IsNullOrEmpty(tbNrComanda.Text) ? 0 : int.Parse(tbNrComanda.Text);

            bool validareFormular = true;
            if (tbNumeClient.Text.Trim().Length < 4) {
                errorPro.SetError(tbNumeClient, "Minim 4 litere!");
                validareFormular = false;
            }
            if (cnpClient<13)
            {
                errorPro.SetError(tbCNP, "Inserati 13 cifre!");
                validareFormular = false;
            }
            if (tbAdresa.Text.Trim().Length < 2)
            {
                errorPro.SetError(tbAdresa, "Minim 2 litere!");
                validareFormular = false;
            }
            if (nrTelefonClient < 10)
            {
                errorPro.SetError(tbNrTelefon, "Inserati minim 10 cifre!");
                validareFormular = false;
            }
            if (nrComanda < 0)
            {
                errorPro.SetError(tbNrComanda, "Inserati nr comenzii!");
                validareFormular = false;
            }
            if (!validareFormular)
            {
                MessageBox.Show("Formularul contine erori!", "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            Clienti client = new Clienti(numeClient, cnpClient, adresa, nrTelefonClient, nrComanda);

                //clienti.Add(client);
            AdaugareClientiBD(client);


            tbNumeClient.Text = string.Empty;
            tbCNP.Clear();
            tbAdresa.Text = string.Empty;
            tbNrTelefon.Clear();
            tbNrComanda.Text = string.Empty;

            AfisareClienti();



        }

        
        void AfisareClienti()
        {
            lvClienti.Items.Clear();
            foreach(Clienti c in clienti)
            {
                ListViewItem it = new ListViewItem(c.NumeClient);
                it.SubItems.Add(c.CnpClient.ToString());
                it.SubItems.Add(c.Adresa);
                it.SubItems.Add(c.NrTelefonClient.ToString());
                it.SubItems.Add(c.NrComanda.ToString());
                it.Tag = c;

                lvClienti.Items.Add(it);

            }
        }
        private bool NumeClient()
        {
            return !string.IsNullOrWhiteSpace(tbNumeClient.Text.Trim());
        }

  /*      private void tbNumeClient_Validating(object sender, CancelEventArgs e)
        {
            if (!NumeClient())
            {
              //e.Cancel = true; //prevents the user from changing the focus to another control
                errorPro.SetError((Control)sender, "Numele Clientului nu este completat");
            }

        }*/

        //buton stergere client
        private void btnStergereClient_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza un client!");
            }
            else
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi clientul selectat?", "Stergere", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectareItem = lvClienti.SelectedItems[0];

                    Clienti cl = (Clienti)selectareItem.Tag;

                    //clienti.Remove(cl);

                    StergereClientiBD(cl);
                    AfisareClienti();
                }
            }
        }

        //buton editare client
        private void btnEditareClient_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza un client!");
            }
            else
            {
                ListViewItem list = lvClienti.SelectedItems[0];

                Clienti cl = (Clienti)list.Tag;

                FormEditareClient editareClient = new FormEditareClient(cl);
               
                if (editareClient.ShowDialog() == DialogResult.OK)
                {
                    UpdateClientiBD(cl);
                    AfisareClienti();
                }

            }
        }

        /*    private void tbNumeClient_Validated(object sender, EventArgs e)//nu mai poti iesi pana nu completezi
            {
                errorPro.SetError((Control)sender, string.Empty);
            }*/

        public void AdaugareClientiBD(Clienti cl)
        {
            var query = "INSERT INTO Clienti(NumeClient, CnpClient, Adresa, NrTelefonClient, NrComanda)" +
                " VALUES(@numeClient, @cnpClient, @adresa, @nrTelefonClient, @nrComanda);" + 
                " SELECT last_insert_rowid()";

            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                var comanda = new SQLiteCommand(query, conectare);

                comanda.Parameters.AddWithValue("@numeClient", cl.NumeClient);
                comanda.Parameters.AddWithValue("@cnpClient", cl.CnpClient);
                comanda.Parameters.AddWithValue("@adresa", cl.Adresa);
                comanda.Parameters.AddWithValue("@nrTelefonClient", cl.NrTelefonClient);
                comanda.Parameters.AddWithValue("@nrComanda",cl.NrComanda);//++

                conectare.Open();


                cl.Id = (long)comanda.ExecuteScalar();

                clienti.Add(cl);
            }

        }


        public void IncarcareClientiBD()
        {
            var query = "SELECT * FROM Clienti";
            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, conectare);

                conectare.Open();
                using (SQLiteDataReader read = comanda.ExecuteReader())
                {
                    while (read.Read())
                    {
                      
                        long id = (long)read["Id"];
                        string numeClient = (string)read["NumeClient"];
                        double cnpClient = double.Parse(read["CnpClient"].ToString());
                        string adresa = (string)read["Adresa"];
                        double nrTelefonClient = double.Parse(read["NrTelefonClient"].ToString());
                        int nrComanda = int.Parse(read["NrComanda"].ToString());
        

                        Clienti cli = new Clienti(id, numeClient, cnpClient, adresa, nrTelefonClient, nrComanda);

                        clienti.Add(cli);
                    }
                }
            }

        }


        void StergereClientiBD(Clienti cli)
        {
            var query = "DELETE FROM Clienti WHERE Id=@id";

            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, conectare);
                comanda.Parameters.AddWithValue("@id", cli.Id);

                conectare.Open();
                comanda.ExecuteNonQuery();

                clienti.Remove(cli);
            }
        }

        //bara sus formclienti
        private void FormClienti_Load(object sender, EventArgs e)
        {

            IncarcareClientiBD();
            AfisareClienti();
        }


        private void UpdateClientiBD(Clienti cl)
        {
            string query = "UPDATE Clienti SET NumeClient = @numeClient, CnpClient = @cnpClient, Adresa = @adresa, NrTelefonClient = @nrTelefonClient, NrComanda = @nrComanda" +
                " WHERE Id='" + cl.Id + "'";



            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                conectare.Open();
                var comanda = new SQLiteCommand(query, conectare);

                comanda.Parameters.AddWithValue("@numeClient", cl.NumeClient);
                comanda.Parameters.AddWithValue("@cnpClient",cl.CnpClient);
                comanda.Parameters.AddWithValue("@adresa", cl.Adresa);
                comanda.Parameters.AddWithValue("@nrTelefonClient", cl.NrTelefonClient);
                comanda.Parameters.AddWithValue("@nrComanda", cl.NrComanda);

                comanda.ExecuteNonQuery();

            }


        }

        private void tbNumeClient_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Insereaza numele Clientului";
        }

        private void tbNumeClient_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbCNP_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Insereaza CNP-ul Clientului";
        }

        private void tbCNP_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbAdresa_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Insereaza Adresa Clientului";
        }

        private void tbAdresa_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
