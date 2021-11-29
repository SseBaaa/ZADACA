using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov();

            
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);

            Console.WriteLine(x380.ToString());

            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);

            Console.WriteLine(C162.ToString());

            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine(PC_21.ToString());

            Console.ReadKey();
            
        }
    }
            
    class Zrakoplov
    {

        String Naziv;
        int snaga, dosegLeta;
       


        public override string ToString()
        {
            string ispis = "Naziv: " + this.getNaziv() + " " + "\n"
                + "snaga: " + this.getsnaga() + " kW" + "\n"
                + "Doseg leta: " + this.getdosegLeta() + " km" + "\n";
            return ispis;
        }

        public Zrakoplov()
        {

        }

        public Zrakoplov(String Naziv, int snaga, int dosegLeta)
        {
            this.Naziv = Naziv;
            this.snaga = snaga;
            this.dosegLeta= dosegLeta;
           
        }



        

        

        private void setNaziv(String Naziv)
        {
            this.Naziv = Naziv;
        }
        private void setsnaga(int snaga)
        {
            this.snaga = snaga;
        }
        private void setdosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }

        public String getNaziv()
        {
            return this.Naziv;
        }
        public int getsnaga()
        {
            return this.snaga;
        }
        public int getdosegLeta()
        {
            return this.dosegLeta;
        }
 

    }
}