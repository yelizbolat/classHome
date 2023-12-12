using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();
            Console.WriteLine("oda sayisi : {0}", ev.odaSayisi);
            Console.WriteLine("metre karesi {0}:", ev.metreKaresi);
        }
    }
    class Ev 
    {
       public int odaSayisi {  get; set; }
        public int metreKaresi { get; set; }
        public Ev()
        {
            Console.Write("oda sayisini girin: ");
            odaSayisi=Convert.ToInt32(Console.ReadLine());
            Console.Write("metre karesini girin:");
            metreKaresi=Convert.ToInt32(Console.ReadLine());
        }
    }
}
