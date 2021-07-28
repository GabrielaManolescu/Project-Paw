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
    public partial class EditareProiect : Form
    {
        Proiecte proiect;
        public EditareProiect(Proiecte proiect)
        {
            InitializeComponent();
            this.proiect = proiect;
        }

        //editare proiecte
        private void EditareProiect_Load(object sender, EventArgs e)
        {
           tbNrProiect.Text = Convert.ToString(proiect.NrProiect);
            tbNumeProiect.Text = proiect.NumeProiect;
            dtpDataInceput.Value = proiect.dataInceputProiect;
            dtpDataSfarsit.Value = proiect.dataSfarsitProiect;
            tbCost.Text = Convert.ToString(proiect.CostProiect);
       

        }

        //butonul salvare-ok din EditareProiecte
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            proiect.NrProiect = Convert.ToInt32(tbNrProiect.Text);
            proiect.NumeProiect = tbNumeProiect.Text;
            proiect.dataInceputProiect = dtpDataInceput.Value;
            proiect.dataSfarsitProiect = dtpDataSfarsit.Value;
            proiect.CostProiect = float.Parse(tbCost.Text);//Convert.ToInt32 DACA E INT
        }
    }
}
