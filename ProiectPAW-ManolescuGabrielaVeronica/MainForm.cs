using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    public partial class AgendaDeActivitati : Form
    {
        private const string ConnectionString = "Data Source=bazaDeDate.db";
        private List<Proiecte> proiecte;
  
      
        public AgendaDeActivitati()
        {
            InitializeComponent();
            proiecte = new List<Proiecte>();

            //  IncarcareClientiBDCB//IncarcareActivitatiBD();//combox

        }

        private void btnAdaugareProiect_Click(object sender, EventArgs e)
        {
            //int nrPr = Int32.Parse(tbNrProiect.Text);//pt int e dif///.Items.Count;
            // int nrPr = Int32.Parse(tbNrProiect.Text);
            // int nrPr =Convert.ToInt32(tbNrProiect.Text);
            int nrPr = string.IsNullOrEmpty(tbNrProiect.Text) ? 0 : int.Parse(tbNrProiect.Text);
            
            string numeProiect = tbNumeProiect.Text;
            DateTime dataInceput = dtpDataInceput.Value;
            DateTime dataSfarsit = dtpDataSfarsit.Value;
            //float costProiect = float.Parse(tbCost.Text);
            float costProiect = string.IsNullOrEmpty(tbCost.Text) ? 0 : float.Parse(tbCost.Text);
            //float costProiect = (float)tbCost.Text;
            //float costProiect =tbCost.textGetOrdinal(tb)
            string numeClient = cbNumeClient.Text;//+

            bool validareFormular = true;
         
            if (nrPr < 2)
            {
                errorProvider.SetError(tbNrProiect, "Numar invalid <2");
                validareFormular = false;
            }

            if (tbNumeProiect.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbNumeProiect, "Este mic de 2 litere");
                validareFormular = false;
            }
            if (costProiect ==0 )
            {
                errorProvider.SetError(tbCost, "Cost invalid!");
                validareFormular = false;
            }
            if (dtpDataInceput.Value < DateTime.Now)
            {
                validareFormular = false;
                errorProvider.SetError(dtpDataInceput, "Data inceput invalida");
               
            }
            if (dtpDataSfarsit.Value < DateTime.Now)
            {
                validareFormular = false;
                errorProvider.SetError(dtpDataSfarsit, "Data sfarsit invalida");

            }
            if (!validareFormular)
            {
                MessageBox.Show("Formularul contine erori!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Proiecte proiect = new Proiecte(nrPr, numeProiect, dataInceput, dataSfarsit, costProiect, numeClient);

            // proiecte.Add(proiect);
            AdaugareProiecteBD(proiect);

            //se restarteaza consola 
            tbNrProiect.Text = string.Empty;
            tbNumeProiect.Text = string.Empty;
            dtpDataInceput.Value = DateTime.Now;
            dtpDataSfarsit.Value = DateTime.Now;
            //tbCost.Text =  string.Empty;
            tbCost.Clear();
            cbNumeClient.Text = string.Empty;//+

            AfisareProiecte();
        }



        void AfisareProiecte()
        {
            lvProiecte.Items.Clear();
            foreach (Proiecte p in proiecte)
            {
                ListViewItem listViewItem = new ListViewItem(p.NrProiect.ToString());
                listViewItem.SubItems.Add(p.NumeProiect);
                listViewItem.SubItems.Add(p.dataInceputProiect.ToShortDateString());
                listViewItem.SubItems.Add(p.dataSfarsitProiect.ToShortDateString());
                //  listViewItem.SubItems.Add(p.NrProiect.ToString());//
                listViewItem.SubItems.Add(p.CostProiect.ToString());//
                listViewItem.SubItems.Add(p.NumeClient);//+


                listViewItem.Tag = p;


                lvProiecte.Items.Add(listViewItem);


            }
        }
        
        private void tbNumeProiect_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeProiect.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbNumeProiect, "Este mic de 2 litere");
            }
            else
            {
                errorProvider.SetError(tbNumeProiect, null);
            }

        }

        private void tbNrProiect_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrProiect.Text.Trim().Length < 2)
            {
                errorProvider.SetError(tbNrProiect, "Numar invalid <2");
            }
            else
            {
                errorProvider.SetError(tbNrProiect, null);
            }


        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            lvProiecte.View = View.List;
        }

        private void btnDetalii_Click(object sender, EventArgs e)
        {
            lvProiecte.View = View.Details;
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();//pt a inchide aplucatia cu Exit din File
        }

        //Serializarea xml:trebuie clasa publica si constr fara param si [serializable]
        private void btnSerializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializare = new XmlSerializer(typeof(List<Proiecte>));

            using (FileStream ser = File.Create("serializare.xml"))
            {
                serializare.Serialize(ser, proiecte);
                MessageBox.Show("Serializarea s-a efectuata!", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Deserializarea XML
        private void btnDeserializareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializare = new XmlSerializer(typeof(List<Proiecte>));

            using (FileStream ser = File.OpenRead("serializare.xml"))
            {
                proiecte = (List<Proiecte>)serializare.Deserialize(ser);

                AfisareProiecte();

            }
        }

        //metoda pentru EXPORT
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileD = new SaveFileDialog();
            saveFileD.Filter = "CSV | *.csv";

            saveFileD.Title = "Export csv";

            if (saveFileD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileD.FileName))
                {
                    streamWriter.WriteLine("Nr.Proiect, NumeProiect, DataDeInceput,DataDeSfarsit,Cost");//

                    foreach (Proiecte pr in proiecte)
                        streamWriter.WriteLine($"{pr.NrProiect},{pr.NumeProiect},{pr.dataInceputProiect.ToShortDateString()},{pr.dataSfarsitProiect.ToShortDateString()},{pr.CostProiect}");


                }
            }
        }
       

        //Buton Anulare
        private void btnAnulare_Click(object sender, EventArgs e)
        {
            tbNrProiect.Text = string.Empty;
            tbNumeProiect.Text = string.Empty;
            dtpDataInceput.Value = DateTime.Now;
            dtpDataSfarsit.Value = DateTime.Now; 

            tbCost.Clear();
        }

        //Butonul Stergere
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (lvProiecte.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un proiect pentru a-l sterge!");
            }
            else 
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi acest proiect?", "Stergere", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectareItem = lvProiecte.SelectedItems[0];

                    Proiecte pr = (Proiecte)selectareItem.Tag;
                    //proiecte.Remove(pr);

                    StergereProiectBD(pr);
                    AfisareProiecte();
                }
            }



        }



        //Adaug metoda de adaugare de proiecte  noi participati in baza de date

        public void AdaugareProiecteBD(Proiecte pr)
        {
            var query = "INSERT INTO Proiecte(NrProiect, NumeProiect, dataInceputProiect, dataSfarsitProiect, CostProiect, NumeClient)" +
                " VALUES(@nrProiect, @numeProiect, @DataInceputProiect, @DataSfarsitProiect, @costProiect, @numeClient);" + 
                " SELECT last_insert_rowid()";

            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                var comanda = new SQLiteCommand(query, conectare);

                comanda.Parameters.AddWithValue("@nrProiect", pr.NrProiect);
                comanda.Parameters.AddWithValue("@numeProiect", pr.NumeProiect);
                comanda.Parameters.AddWithValue("@DataInceputProiect", pr.dataInceputProiect);
                comanda.Parameters.AddWithValue("@DataSfarsitProiect", pr.dataSfarsitProiect);
                comanda.Parameters.AddWithValue("@costProiect", pr.CostProiect);
                comanda.Parameters.AddWithValue("@numeClient", pr.NumeClient);

                conectare.Open();
               

                pr.Id =(long)comanda.ExecuteScalar();

                proiecte.Add(pr);
            }

        }


        //incarcarea/load proiectelor din baza de date la pornirea aplicatiei:

        public void IncarcareProiecteBD()
        {
          
                var query = "SELECT * FROM Proiecte";
                using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
                {
                    SQLiteCommand comanda = new SQLiteCommand(query, conectare);

                    conectare.Open();
                    using (SQLiteDataReader read = comanda.ExecuteReader())
                    {
                        while (read.Read())
                        {

                      
                        long id = (long)read["id"];
               
                            int NrProiect = Convert.ToInt32(read["NrProiect"]);
                            string NumeProiect = (string)read["NumeProiect"];
                            DateTime dataInceputProiect = DateTime.Parse((string)read["dataInceputProiect"]);
                            DateTime dataSfarsitProiect = DateTime.Parse((string)read["dataSfarsitProiect"]);
                            //float costProiect = read.GetOrdinal("CostProiect");
                            float costProiect = float.Parse(read["CostProiect"].ToString());
                           // string NumeClient = (string)read["NumeClient"];

                        Proiecte pro = new Proiecte(id, NrProiect, NumeProiect, dataInceputProiect, dataSfarsitProiect, costProiect);

                            proiecte.Add(pro);
                        }

                    }
                }

        }

       
        void StergereProiectBD(Proiecte pro)
        {
            var query = "DELETE FROM Proiecte WHERE Id=@id";

            using(SQLiteConnection conectare =new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, conectare);
                comanda.Parameters.AddWithValue("@id", pro.Id);

                conectare.Open();
                comanda.ExecuteNonQuery();

                proiecte.Remove(pro);
            }
        }



        //este MainFormul de sus
        private void AgendaDeActivitati_Load(object sender, EventArgs e)
        {
            IncarcareClientiBDCB();
            IncarcareProiecteBD();
            AfisareProiecte();
        }

        //buton editare apl1
        private void btnEditare_Click(object sender, EventArgs e)
        {
            if (lvProiecte.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza un proiect!");

            }
            else
            {
                ListViewItem list = lvProiecte.SelectedItems[0];

                Proiecte pr = (Proiecte)list.Tag;
                EditareProiect editareProiect = new EditareProiect(pr);
               // ActualizareProiecte(pr);
                if (editareProiect.ShowDialog() == DialogResult.OK)
                {
                    UpdateProiecteBD(pr);
                    AfisareProiecte();
                }

              

            }
          

        }


        //butonul Activitati din meniul Proiecte
        private void activitatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormActivitati formActivitati = new FormActivitati();
          
            formActivitati.Show();
        }

        //update baza de  date-in edit  ->ActualizareProiecte(pr);
        private void UpdateProiecteBD(Proiecte p)
        {
            var query = "UPDATE Proiecte SET NrProiecT = @nrProiect, NumeProiect = @numeProiect, dataInceputProiect = @DataInceputProiect, " +
                "dataSfarsitProiect = @DataSfarsitProiect, CostProiect = @costProiect, NumeClient= @numeClient" + " WHERE nrProiect=" + p.getNrProiect() + " ";


                using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
                {
                conectare.Open();
                var comanda = new SQLiteCommand(query, conectare);


              
                comanda.Parameters.AddWithValue("@nrProiect", p.NrProiect);
                comanda.Parameters.AddWithValue("@numeProiect", p.NumeProiect);
                comanda.Parameters.AddWithValue("@DataInceputProiect", p.dataInceputProiect);
                comanda.Parameters.AddWithValue("@DataSfarsitProiect",p.dataSfarsitProiect);
                comanda.Parameters.AddWithValue("@costProiect", p.CostProiect);
                comanda.Parameters.AddWithValue("@numeClient", p.NumeClient);

                comanda.ExecuteNonQuery();
               
                }

        }

        //buton Clienti
        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();

            formClienti.Show();
        }


        //combobox pentru Main Nume client:
        public void IncarcareClientiBDCB()//pt combobox main meniu
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
                       
                        cbNumeClient.Items.Add(read["NumeClient"]);
                    
                    }
               /*     read.Close();
                    conectare.Close();*/

                }
            }

        }

        //pt printare- print Doc
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Cambria", 20);
            int cY = 0;

            while(currentPrintIndex < proiecte.Count)
            {
                Proiecte pr = proiecte[currentPrintIndex];
                e.Graphics.DrawString($"{pr.NrProiect}  {pr.NumeProiect}  {pr.CostProiect}  {pr.dataInceputProiect}  {pr.CostProiect}",
                   font, Brushes.Black, 0, cY);
                cY += 50;

                //mai multe pagini:
                if(cY > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    break;
                }

                    currentPrintIndex++;
            }

        }

        int currentPrintIndex = 0;

        //pt printare- print Doc2
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentPrintIndex = 0;
        }

        //sus Print Preview
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        //buton Print
        private void btnPrintare_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
        //pt drag
        private void tbNumeProiect_MouseDown(object sender, MouseEventArgs e)
        {
            tbNumeProiect.DoDragDrop(tbNumeProiect.Text, DragDropEffects.Copy);
        }

        private void dtpDataInceput_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDataInceput.Value < DateTime.Now)
            {
                errorProvider.SetError(dtpDataInceput, "Data invalida");
            }
            else
            {
                errorProvider.SetError(dtpDataInceput, null);
            }
        }

        private void dtpDataSfarsit_Validating(object sender, CancelEventArgs e)
        {

            if (dtpDataSfarsit.Value < DateTime.Now)
            {
                errorProvider.SetError(dtpDataSfarsit, "Data sfarsit invalida");
            }
            else
            {
                errorProvider.SetError(dtpDataSfarsit, null);
            }
        }


   
    }

   
}

