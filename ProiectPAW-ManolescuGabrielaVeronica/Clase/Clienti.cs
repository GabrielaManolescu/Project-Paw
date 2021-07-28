using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_ManolescuGabrielaVeronica
{
    public class Clienti
    {
        public long Id { get; set; }
        public int ClientId;
        public string NumeClient { get; set; }
        public double CnpClient { get; set; }
        public string Adresa { get; set; }

        public double NrTelefonClient { get; set; }
        public int NrComanda { get; set; }

      

        public Clienti() 
        { }

        public Clienti(string numeClient, double cnpClient, string adresa, double nrTelefonClient, int nrComanda)
        {
            NumeClient = numeClient;
            CnpClient = cnpClient;
            Adresa = adresa;
            NrTelefonClient = nrTelefonClient;
            NrComanda = nrComanda;
        }

        public Clienti(long id, string numeClient, double cnpClient, string adresa, double nrTelefonClient, int nrComanda)
        {
            Id = id;
            NumeClient = numeClient;
            CnpClient = cnpClient;
            Adresa = adresa;
            NrTelefonClient = nrTelefonClient;
            NrComanda = nrComanda;
        }
    }
}
