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
    public partial class FormEditareActivitate : Form
    {
        Activitati activitate;
        public FormEditareActivitate(Activitati activitate)
        {
            InitializeComponent();
            this.activitate = activitate;
        }

     

        private void FormEditareActivitate_Load(object sender, EventArgs e)
        {
            tbNumeActivitate.Text = activitate.NumeActivitate;
            tbParticipantActivitate.Text = activitate.ParticipantActivitate;
            dtpDataActivitati.Value = activitate.DataActivitate;
            cbDomeniiDeActivitate.Text = Convert.ToString(activitate.domeniiDeActivitate);
            cbNumeProiect.Text= Convert.ToString(activitate.NumeProiect);
        }

        //butonul salvare din editare activitate
        private void btnSalvareActivitate_Click(object sender, EventArgs e)
        {
            activitate.NumeActivitate = tbNumeActivitate.Text;
            activitate.ParticipantActivitate = tbParticipantActivitate.Text;
            activitate.DataActivitate = dtpDataActivitati.Value;
            activitate.domeniiDeActivitate = (DomeniiDeActivitate)System.Enum.Parse(typeof(DomeniiDeActivitate), cbDomeniiDeActivitate.Text);
            activitate.NumeProiect = cbNumeProiect.Text;
           // activitate.NumeProiect = (string)Enum.Parse(typeof(string), cbNumeProiect.Text);
        }

   
    }
}
