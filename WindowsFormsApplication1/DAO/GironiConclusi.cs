using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GironiConclusi
    {
        public Boolean Qualificato { get; set; }
        public Int32 IdTorneo { get; set; }
        public Int32 idDisciplina { get; set; }
        public Int32 IdGirone { get; set; }
        public Int32 IdAtleta { get; set; }
        public String Cognome { get; set; }
        public String Nome { get; set; }        
        public Int32 Vittorie { get; set; }
        public Int32 Sconfitte { get; set; }
        public Int32 PuntiFatti { get; set; }
        public Int32 PuntiSubiti { get; set; }
        public Double Differenziale { get; set; }
        public Int32 Posizionamento { get; set; }
        public Double Ranking { get; set; }

    }
}
