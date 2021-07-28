using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
   public class Activitati 
    {
        public int ActivitateId;
        public int ProiectId;
        public long Id { get; set; }

        public string NumeActivitate;
        private ComboBox cbNumeProiect;
        private string numeClient;
        private double cnpClient;
        private string adresa;
        private double nrTelefonClient;
        private int nrComanda;

        public string ParticipantActivitate { get; set; }
        public DateTime DataActivitate { get; set; }
        public DomeniiDeActivitate domeniiDeActivitate { get; set; }
        public string NumeProiect { get; set; }//++
        public Activitati() { }

        public Activitati(string numeActivitate, string participantActivitate, DateTime dataActivitate, DomeniiDeActivitate domeniiDeActivitate)
        {
            NumeActivitate = numeActivitate;
            ParticipantActivitate = participantActivitate;
            DataActivitate = dataActivitate;
            this.domeniiDeActivitate = domeniiDeActivitate;
        }

        public Activitati(long id, string numeActivitate, string participantActivitate, DateTime dataActivitate, DomeniiDeActivitate domeniiDeActivitate)
        {
            Id = id;
            NumeActivitate = numeActivitate;
            ParticipantActivitate = participantActivitate;
            DataActivitate = dataActivitate;
            this.domeniiDeActivitate = domeniiDeActivitate;
        }
        //nou cu tot
        public Activitati(int activitateId, int proiectID, long id, string numeActivitate, string participantActivitate, DateTime dataActivitate, DomeniiDeActivitate domeniiDeActivitate, string numeProiect)
        {
            ActivitateId = activitateId;
            ProiectId = proiectID;
            Id = id;
            NumeActivitate = numeActivitate;
            ParticipantActivitate = participantActivitate;
            DataActivitate = dataActivitate;
            this.domeniiDeActivitate = domeniiDeActivitate;
            NumeProiect = numeProiect;
        }

        public Activitati(string numeActivitate, string participantActivitate, DateTime dataActivitate, DomeniiDeActivitate domeniiDeActivitate, string numeProiect)
            : this(numeActivitate, participantActivitate, dataActivitate, domeniiDeActivitate)
        {
            NumeProiect = numeProiect;
        }

        public Activitati(long id, string numeActivitate, string participantActivitate, DateTime dataActivitate, DomeniiDeActivitate domeniiDeActivitate, string numeProiect)
            : this(id, numeActivitate, participantActivitate, dataActivitate, domeniiDeActivitate)
        {
            Id = id;
        }

        public Activitati(ComboBox cbNumeProiect)//pt combobox
        {
            this.cbNumeProiect = cbNumeProiect;
        }

        public Activitati(long id, string numeClient, double cnpClient, string adresa, double nrTelefonClient, int nrComanda)
        {
            Id = id;
            this.numeClient = numeClient;
            this.cnpClient = cnpClient;
            this.adresa = adresa;
            this.nrTelefonClient = nrTelefonClient;
            this.nrComanda = nrComanda;
        }

        public String getNumeActivitate()
        {
            return NumeActivitate;
        }

        public void setNumeActivitate(string numeActivitate)
        {
            NumeActivitate = numeActivitate;
        }


        // public DomeniiDeActivitate domenii { get; set; }

    }
}
