using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    [Serializable]//trebuie clasa si publica pt serializare
   public class Proiecte
    {
        public int ClientId;
        public int ProiectId;

        public long Id { get; set; }
        public int NrProiect;
        public string NumeProiect;
        public string NumeClient;//+
        public DateTime dataInceputProiect { get; set; }
       public DateTime dataSfarsitProiect { get; set; }

       public float CostProiect { get; set; }

        public Proiecte() { }
        public Proiecte(int nrProiect, string numeProiect, DateTime DataInceputProiect, DateTime DataSfarsitProiect, float costProiect)
        {
            NrProiect = nrProiect;
            NumeProiect = numeProiect;
            this.dataInceputProiect = DataInceputProiect;
            this.dataSfarsitProiect = DataSfarsitProiect;
            CostProiect = costProiect;
        }

        public Proiecte(long id, int nrProiect, string numeProiect, DateTime DataInceputProiect, DateTime DataSfarsitProiect, float costProiect)
       : this(nrProiect, numeProiect, DataInceputProiect, DataSfarsitProiect, costProiect)
        {
            Id = id;
        }

        public Proiecte(int nrProiect, string numeProiect, DateTime DataInceputProiect, DateTime DataSfarsitProiect, float costProiect, string numeClient) 
            : this(nrProiect, numeProiect, DataInceputProiect, DataSfarsitProiect, costProiect)
        {
            this.NumeClient = numeClient;
        }

   

        public float getNrProiect()
        {
            return NrProiect;
        }

        public void setNrProiect(int nrPr)
        {
            NrProiect = nrPr;
        }

        public void setNumeProiect(string numeProiect)
        {
            NumeProiect=numeProiect;
        }

        public string getNumeProiect()
        {
            return NumeProiect;
        }

        public string getNumeClient()
        {
            return NumeClient;
        }

        public void setNumeClient(string numeClient)
        {
            NumeClient = numeClient;
        }
    }
}
