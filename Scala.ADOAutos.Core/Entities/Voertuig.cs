using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scala.ADOAutos.Core.Entities
{
    public class Voertuig
    {
        public string Merk { get; set; }
        public string Serie { get; set; }
        public string Kleur { get; set; }
        public string Nummerplaat { get; set; }
        public int KW { get; set; }
        public DateTime InDienst { get; set; }

        public Voertuig()
        { }
        public Voertuig(string merk, string serie, string kleur, string nummerplaat, int kw, DateTime inDienst)
        {
            Merk = merk;
            Serie = serie;
            Kleur = kleur;
            Nummerplaat = nummerplaat;
            KW = kw;
            InDienst = inDienst;
        }
        public override string ToString()
        {
            return $"{Merk} - {Serie}";
        }
    }
}
