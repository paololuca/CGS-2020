using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RisultatiIncontriGironi
    {
        public Int32 idAtleta { get; set; }
        public Int32 Vittorie { get; set; }
        public Int32 Sconfitte { get; set; }
        public Int32 PuntiFatti { get; set; }
        public Int32 PuntiSubiti { get; set; }
        public Double Differenziale { get; set; }
        public Int32 NumeroIncontriDisputati { get; set; }


        public RisultatiIncontriGironi()
        {
            Vittorie = 0;
            Sconfitte = 0;
            PuntiFatti = 0;
            PuntiSubiti = 0;
            Differenziale = 0;
            NumeroIncontriDisputati = 0;
        }
    }
}
