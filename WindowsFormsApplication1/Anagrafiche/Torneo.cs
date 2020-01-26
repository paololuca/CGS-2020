using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Torneo
    {

        public int TournamentId { get; set; }
        public String TournamentName { get; set; }
        public DateTime TournamentStartDate { get; set; }
        public DateTime TournamentEndDate { get; set; }
        public String TournamentPlace { get; set; }

        public Torneo(int tournamentId, DateTime tournamentDate)
        {
            TournamentId = tournamentId;
            TournamentName = "torneo del cippalippa";
            TournamentStartDate = tournamentDate;
        }
        public Torneo() { }
    }
}
