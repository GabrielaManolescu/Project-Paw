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
    public partial class FormActivitati : Form
    {
        private const int CtrlKey = 10;
        private const string ConnectionString = "Data Source=bazaDeDate.db";
        private List<Activitati> activitati;

        public FormActivitati()
        {
            InitializeComponent();
            activitati = new List<Activitati>();
         
           // IncarcarePRoiecteBDCB();
           
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();//inchide doar formulActivitati
        }

        //Butonul Adaugare activitate
        private void btnAdaugaActivitate_Click(object sender, EventArgs e)
        {
            string numeActivitate = tbNumeActivitate.Text;
            string participantActivitate = tbParticipantActivitate.Text;
            DateTime dataActivitate = dtpDataActivitati.Value;
            //DomeniiDeActivitate domeniiDeActivitate = (DomeniiDeActivitate)System.Enum.Parse(typeof(DomeniiDeActivitate), cbDomeniiDeActivitate.Text);
           DomeniiDeActivitate domeniiDeActivitate = string.IsNullOrEmpty(cbDomeniiDeActivitate.Text) ? 0 : (DomeniiDeActivitate)Enum.Parse(typeof(DomeniiDeActivitate), cbDomeniiDeActivitate.Text);
           
            string numeProiect = cbNumeProiect.Text;//++++
         


            bool validareFormular = true;

            if (tbNumeActivitate.Text.Trim().Length < 5)
            {
                errorPr.SetError(tbNumeActivitate, "Minim 5 litere!");
                validareFormular = false;
            }
            if (tbParticipantActivitate.Text.Trim().Length < 3)
            {
                errorPr.SetError(tbParticipantActivitate, "Minim 3 litere!");
                validareFormular = false;
            }
            if(dataActivitate< DateTime.Now)
            {
                errorPr.SetError(dtpDataActivitati, "Data Invalida.");
                validareFormular = false;
            }
            if (cbDomeniiDeActivitate.Text.Trim().Length ==0)
            {
                errorPr.SetError(cbDomeniiDeActivitate, "Domeniu Invalid");
                validareFormular = false;
            }
            if (!validareFormular)
            {
                MessageBox.Show("Formularul contine erori!", "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Activitati activitate = new Activitati(numeActivitate, participantActivitate, dataActivitate, domeniiDeActivitate, numeProiect);//de refacut constructorul
            // activitati.Add(activitate);
            AdaugareActivitateBD(activitate);

            tbNumeActivitate.Text = string.Empty;
            tbParticipantActivitate.Text = string.Empty;
            dtpDataActivitati.Value = DateTime.Now;
            cbDomeniiDeActivitate.Text = string.Empty;

           cbNumeProiect.Text = string.Empty;//+
            AfisareActivitati();

        }

        void AfisareActivitati()
        {
            lvActivitati.Items.Clear();
            foreach(Activitati a in activitati)
            {
                ListViewItem listViewItem = new ListViewItem(a.NumeActivitate);
                listViewItem.SubItems.Add(a.ParticipantActivitate);
                listViewItem.SubItems.Add(a.DataActivitate.ToShortDateString());
                listViewItem.SubItems.Add(a.domeniiDeActivitate.ToString());
                listViewItem.SubItems.Add(a.NumeProiect);//+

                listViewItem.Tag = a;

                lvActivitati.Items.Add(listViewItem);
            }
        }

        //btn stergereActivitate
        private void btnStergereActivitate_Click(object sender, EventArgs e)
        {
            if (lvActivitati.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o activitate!");
            }
            else
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi activitatea selectata?", "Stergere", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectareItem = lvActivitati.SelectedItems[0];

                    Activitati a = (Activitati)selectareItem.Tag;

                  //  activitati.Remove(a);

                    StergereActivitateBD(a);
                    AfisareActivitati();
                }
            }
        }

        //btn editare avctivitate//actualiz
        private void btnEditareActivitate_Click(object sender, EventArgs e)
        {
            if (lvActivitati.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o activitate pentru a o edita!");
            }
            else
            {
                ListViewItem selectare = lvActivitati.SelectedItems[0];

                Activitati a = (Activitati)selectare.Tag;

                FormEditareActivitate editareActivitate = new FormEditareActivitate(a);

                if (editareActivitate.ShowDialog() == DialogResult.OK)
                {
                    UpdateeProiecteBD(a);
                   
                    AfisareActivitati();//fac actuaalizare si dupa afisare 
                    
                }
                 
            }
        }




        //baza de date:

        public void AdaugareActivitateBD(Activitati activ)
        {
            var query = "INSERT INTO Activitati(NumeActivitate, ParticipantActivitate, DataActivitate, DomeniiDeActivitate, NumeProiect)" +
                " VALUES(@numeActivitate, @participantActivitate, @dataActivitate, @domeniiDeActivitate, @numeProiect);" + 
                " SELECT last_insert_rowid()";

            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                var comanda = new SQLiteCommand(query, conectare);

                comanda.Parameters.AddWithValue("@numeActivitate", activ.NumeActivitate);
                comanda.Parameters.AddWithValue("@participantActivitate", activ.ParticipantActivitate);
                comanda.Parameters.AddWithValue("@dataActivitate", activ.DataActivitate);
                comanda.Parameters.AddWithValue("@domeniiDeActivitate", activ.domeniiDeActivitate);
                comanda.Parameters.AddWithValue("@numeProiect", activ.NumeProiect);//++

                conectare.Open();


                activ.Id = (long)comanda.ExecuteScalar();

                activitati.Add(activ);
            }

        }

        //incarcarea/load proiectelor din baza de date la pornirea aplicatiei:

        public void IncarcareActivitatiBD()
        {
            var query = "SELECT * FROM Activitati";
            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, conectare);

                conectare.Open();
                using (SQLiteDataReader read = comanda.ExecuteReader())
                {
                    while (read.Read())
                    {
                      
                        long id = (long)read["Id"];
                        string NumeActivitate = (string)read["NumeActivitate"];
                        string ParticipantActivitate = (string)read["ParticipantActivitate"];
                        DateTime DataActivitate = DateTime.Parse((string)read["DataActivitate"]);
                        // DomeniiDeActivitate domeniiDeActivitate =(DomeniiDeActivitate)read["domeniiDeActivitate"];
                        //  var domeniiDeActivitate = (String)read["domeniiDeActivitate"];
                        DomeniiDeActivitate domeniiDeActivitate = (DomeniiDeActivitate)Enum.Parse(typeof(DomeniiDeActivitate), ((string)read["domeniiDeActivitate"]));
                       string numeProiect= (string)read["NumeProiect"];//+
                       // string numeProiect = (string)Enum.Parse(typeof(string), (string)read["NumeProiect"]); // ? string.Empty : cbNumeProiect.ToString();
                     
                        Activitati act = new Activitati(id, NumeActivitate, ParticipantActivitate, DataActivitate, domeniiDeActivitate, numeProiect);

                        activitati.Add(act);
                    }
                }
            }

        }
        void StergereActivitateBD(Activitati activ)
        {
            var query = "DELETE FROM Activitati WHERE Id=@id";

            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, conectare);
                comanda.Parameters.AddWithValue("@id", activ.Id);

                conectare.Open();
                comanda.ExecuteNonQuery();

                activitati.Remove(activ);
            }
        }

        //bara de sus la Activitati
        private void FormActivitati_Load(object sender, EventArgs e)
        {
            IncarcarePRoiecteBDCB();
            IncarcareActivitatiBD();
            AfisareActivitati();

     
            
        }

        //update bd//NumeActivitate = @numeActivitate,
        private void UpdateeProiecteBD(Activitati activ)
        {
            string query = "UPDATE Activitati SET NumeActivitate = @numeActivitate, ParticipantActivitate = @participantActivitate, DataActivitate = @dataActivitate, domeniiDeActivitate = @domeniiDeActivitate, NumeProiect = @numeProiect" +
                " WHERE Id='" + activ.Id +"'";



            using (SQLiteConnection conectare = new SQLiteConnection(ConnectionString))
            {
                conectare.Open();
                var comanda = new SQLiteCommand(query, conectare);

                comanda.Parameters.AddWithValue("@numeActivitate", activ.NumeActivitate);
                comanda.Parameters.AddWithValue("@participantActivitate", activ.ParticipantActivitate);
                comanda.Parameters.AddWithValue("@dataActivitate", activ.DataActivitate);
                comanda.Parameters.AddWithValue("@domeniiDeActivitate", activ.domeniiDeActivitate);
                comanda.Parameters.AddWithValue("@numeProiect", activ.NumeProiect);

                comanda.ExecuteNonQuery();

            }


        }
        //pt combobox proiecte adaugare proiecte Nume proiect:
        public void IncarcarePRoiecteBDCB()
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

                        {
                            //bun
                            // cbNumeProiect.Items.Add(read["NumeProiect"].ToString());
                            cbNumeProiect.Items.Add(read["NumeProiect"]);
            
                        }
               
                    }
                }
            }

        }

        //buton de copiere domeniu-pct 10 clipboard
        private void btnCopiereDomeniu_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbDomeniiDeActivitate.Text);
          
        }
        //pt a drag
        private void tbParticipantActivitate_MouseDown(object sender, MouseEventArgs e)
        {
            tbParticipantActivitate.DoDragDrop(tbParticipantActivitate.Text, DragDropEffects.Copy);
        }
        //pt a drag
        private void tbNumeActivitate_MouseDown(object sender, MouseEventArgs e)
        {
            tbNumeActivitate.DoDragDrop(tbNumeActivitate.Text, DragDropEffects.Copy);
        }

        //buton anulare 
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNumeActivitate.Text = string.Empty;
            tbParticipantActivitate.Text = string.Empty;
            dtpDataActivitati.Value = DateTime.Now;
            cbDomeniiDeActivitate.Text = string.Empty;

            cbNumeProiect.Text = string.Empty;//++
        }

        private void cbDomeniiDeActivitate_Validating(object sender, CancelEventArgs e)
        {
            if (cbDomeniiDeActivitate.Text.Trim() == null)
            {
                errorPr.SetError(cbDomeniiDeActivitate, "Domeniu invalid");
            }
            else
            {
                errorPr.SetError(cbDomeniiDeActivitate, null);
            }
        }
    }
}
