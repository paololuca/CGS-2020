using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person
    {
        public int Id { get; set; }
        public String Satrapia { get; set; }

        public String Cognome { get; set; }

        public String Nome { get; set; }

        public int Ranking { get; set; }

        public Person(String satrapia, String cognome, String nome)
        {
            ///TODO memorizzare l'id del DB che poi servirà come chiave
            Satrapia = satrapia;
            Cognome = cognome;
            Nome = nome;
            Ranking = 0;        ///TODO per ora non hanno ranking (è il caso comunque base la prima volta nel DB)
        }
        public Person()
        { }
    }
}
