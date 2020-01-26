using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Atleta
    {
        public int IdAtleta { get; set; }
        public int IdAsd { get; set; }
        public String Asd { get; set; }
        public String Cognome { get; set; }
        public String Nome { get; set; }
        public String Sesso { get; set; }
        public Double Ranking { get; set; }
        public Int32 Posizionamento { get; set; }

        public Atleta() { }

        public string FullName
        {
            get { return Cognome + " " + Nome; }
        }

    }
}
