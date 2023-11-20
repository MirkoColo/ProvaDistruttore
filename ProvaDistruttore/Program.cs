using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDistruttore
{
    class Esempio
    {
        protected string _stringa;
        protected int _numero;
        public Esempio()
        {
            //Fabio Rovazzi è il numero 1
            _stringa = "Fabio Rovazzi";
            _numero = 1;
        }
        public void Stampa()
        {
            Console.WriteLine($"{_stringa} è il numero {_numero}");
        }

        ~Esempio()
        {
            Console.WriteLine("Fabio Rovazzi(numero 1) è stato distrutto");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Esempio esempio = new Esempio();
            esempio.Stampa();
        }
    }
}
