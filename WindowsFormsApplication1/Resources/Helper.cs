using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Helper
    {
        public const String MASCHILE = "MASCHILE";
        public const String FEMMINILE = "FEMMINILE";
        public const String TEST = "TEST";

        private static string GetConnectionString()
        {
            if (GetDbType() == TEST)
                return ConfigurationManager.AppSettings["SqlDBTest"];
            else if (GetDbType() == FEMMINILE)
                return ConfigurationManager.AppSettings["SqlDBFemale"];
            else
                return ConfigurationManager.AppSettings["SqlDB"];
        }

        ///TODO per ora funziona solo testuale, poi i gironi vanno fisicamente calcolati sull'oggetto GIRONE
        ///(cioè su una lista di persone)
        ///il risutlato sarà una lista di incontri

        /// <summary>
        /// [T4]
        ///    0	1			
        ///    2	3			
        ///    1	2			
        ///    0	3			
        ///    0	2			
        ///    1	3
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static String ElaborateT4(TreeNodeCollection t)
        {
            string incontri = "";

            foreach (TreeNode n in t)
                incontri += n.Text + " \r\n";

            incontri += " \r\n \r\n";

            incontri += t[0].Text + "\t\t" + t[1].Text + " \r\n";
            incontri += t[2].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[3].Text + " \r\n";

            return incontri;
        }

        /// <summary>
        /// [T5]
        /// 0	1			
        /// 2	3			
        /// 4	0			
        /// 1	2			
        /// 3	4			
        /// 0	2			
        /// 4	1			
        /// 0	3			
        /// 4	2			
        /// 1	3
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static String ElaborateT5(TreeNodeCollection t)
        {
            string incontri = "";

            foreach (TreeNode n in t)
                incontri += n.Text + " \r\n";

            incontri += " \r\n \r\n";

            incontri += t[0].Text + "\t\t" + t[1].Text + " \r\n";
            incontri += t[2].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[4].Text + "\t\t" + t[0].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[3].Text + "\t\t" + t[4].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[4].Text + "\t\t" + t[1].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[4].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[3].Text + " \r\n";
            return incontri;
        }

        /// <summary>
        /// [T6]
        /// 0	1			
        /// 2	3			
        /// 4	5			
        /// 0	3			
        /// 1	2			
        /// 3	5			
        /// 2	4			
        /// 1	5			
        /// 0	2			
        /// 3	4
        /// 
        /// 2	5			
        /// 0	4			
        /// 1	3			
        /// 0	5			
        /// 1	4
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static String ElaborateT6(TreeNodeCollection t)
        {
            string incontri = "";

            foreach (TreeNode n in t)
                incontri += n.Text + " \r\n";

            incontri += "[INCONTRI] \r\n \r\n";
            incontri += " \r\n \r\n";

            incontri += t[0].Text + "\t\t" + t[1].Text + " \r\n";
            incontri += t[2].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[4].Text + "\t\t" + t[5].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[3].Text + "\t\t" + t[5].Text + " \r\n";
            incontri += t[2].Text + "\t\t" + t[4].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[5].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[2].Text + " \r\n";
            incontri += t[3].Text + "\t\t" + t[4].Text + " \r\n";
            incontri += t[2].Text + "\t\t" + t[5].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[4].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[3].Text + " \r\n";
            incontri += t[0].Text + "\t\t" + t[5].Text + " \r\n";
            incontri += t[1].Text + "\t\t" + t[4].Text + " \r\n";

            return incontri;
        }

        internal static List<Incontro> ElaborateT4(List<Atleta> g)
        {
            List<Incontro> match = new List<Incontro>();

            match.Add(new Incontro(g[0], g[1]));
            match.Add(new Incontro(g[2], g[3]));
            match.Add(new Incontro(g[1], g[2]));
            match.Add(new Incontro(g[0], g[3]));
            match.Add(new Incontro(g[0], g[2]));
            match.Add(new Incontro(g[1], g[3]));

            return match;
        }

        internal static List<Incontro> ElaborateT5(List<Atleta> g)
        {

            List<Incontro> match = new List<Incontro>();

            match.Add(new Incontro(g[0], g[1]));
            match.Add(new Incontro(g[2], g[3]));
            match.Add(new Incontro(g[4], g[0]));
            match.Add(new Incontro(g[1], g[2]));
            match.Add(new Incontro(g[3], g[4]));
            match.Add(new Incontro(g[0], g[2]));
            match.Add(new Incontro(g[4], g[1]));
            match.Add(new Incontro(g[0], g[3]));
            match.Add(new Incontro(g[4], g[2]));
            match.Add(new Incontro(g[1], g[3]));

            return match;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        internal static List<Incontro> ElaborateT6(List<Atleta> g)
        {
            List<Incontro> match = new List<Incontro>();

            match.Add(new Incontro(g[0], g[1]));
            match.Add(new Incontro(g[2], g[3]));
            match.Add(new Incontro(g[4], g[5]));
            match.Add(new Incontro(g[0], g[3]));
            match.Add(new Incontro(g[1], g[2]));
            match.Add(new Incontro(g[3], g[5]));
            match.Add(new Incontro(g[2], g[4]));
            match.Add(new Incontro(g[1], g[5]));
            match.Add(new Incontro(g[0], g[2]));
            match.Add(new Incontro(g[3], g[4]));
            match.Add(new Incontro(g[2], g[5]));
            match.Add(new Incontro(g[0], g[4]));
            match.Add(new Incontro(g[1], g[3]));
            match.Add(new Incontro(g[0], g[5]));
            match.Add(new Incontro(g[1], g[4]));

            return match;
        }


        ///TODO implementare i metodi che restituiscono liste di incontri
        ///


        #region READ
        public static bool TestConnectionString()
        {
            SqlConnection c = null;

            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                if (c.State == System.Data.ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static string GetDbType()
        {
            string dbType = ConfigurationManager.AppSettings["DataBase"].ToString().ToUpper();

            if (dbType == "MASCHILE")
                return MASCHILE;
            else if (dbType == "FEMMINILE")
                return FEMMINILE;
            else
                return TEST;
        }

        /// <summary>
        /// Return the version of the DB Stored on the table SYSTEM_INFO
        /// </summary>
        /// <returns></returns>
        public static String GetDbVersion()
        {
            SqlConnection c = null;

            try
            {

                c = new SqlConnection(GetConnectionString());

                String sqlText = "SELECT * FROM SYSTEM_INFO WHERE NAME = 'DB_VERS'";
                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                string dbVersion = "";
                while (reader.Read())
                {
                    dbVersion = reader["VALUE"].ToString();
                }

                return dbVersion;
            }
            catch (Exception e)
            {
                return "";
            }
            finally
            {
                c.Close();
            }
        }
        public static bool CheckAdminPwd(string pwd)
        {
            SqlConnection c = null;

            try
            {

                c = new SqlConnection(GetConnectionString());

                String sqlText = "SELECT * FROM SYSTEM_INFO WHERE NAME = 'AdminPwd'";
                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                string pwdOnDb = "";
                while (reader.Read())
                {
                    pwdOnDb = reader["VALUE"].ToString();
                }

                return pwdOnDb.ToUpper() == pwd.ToUpper();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public static String GetDisciplinaById(int idDisciplina)
        {
            String commandText = "select Nome FROM Discipline WHERE Id = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();
                Torneo torneo = new Torneo();

                string nomeDisciplina = "";

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nomeDisciplina = (String)reader["nome"];
                }

                return nomeDisciplina;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static Torneo GetTorneoById(int idTorneo)
        {
            SqlConnection c = null;

            try
            {
                String sqlText = "SELECT * FROM TORNEO WHERE Id = " + idTorneo;
                c = new SqlConnection(GetConnectionString());

                c.Open();
                Torneo torneo = new Torneo();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    torneo = new Torneo()
                    {
                        TournamentName = reader["NomeTorneo"].ToString(),
                        TournamentId = Int32.Parse(reader["Id"].ToString()),
                        TournamentStartDate = DateTime.Parse(reader["DataInizio"].ToString())
                    };
                }

                return torneo;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Torneo> GetTorneiAttivi()
        {
            SqlConnection c = null;

            try
            {
                String sqlText = "SELECT * FROM TORNEO WHERE CONCLUSO = 0";
                c = new SqlConnection(GetConnectionString());

                c.Open();
                List<Torneo> tornei = new List<Torneo>();
                tornei.Add(new Torneo() { TournamentId = 0 });

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tornei.Add(new Torneo()
                    {
                        TournamentName = reader["NomeTorneo"].ToString()
                    ,
                        TournamentId = Int32.Parse(reader["Id"].ToString())
                    ,
                        TournamentStartDate = DateTime.Parse(reader["DataInizio"].ToString())
                    });
                }

                return tornei;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }
        public static List<Torneo> GetTorneiNonAttivi()
        {
            SqlConnection c = null;

            try
            {
                String sqlText = "SELECT * FROM TORNEO WHERE CONCLUSO = 1";
                c = new SqlConnection(GetConnectionString());

                c.Open();
                List<Torneo> tornei = new List<Torneo>();
                tornei.Add(new Torneo() { TournamentId = 0 });

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tornei.Add(new Torneo()
                    {
                        TournamentName = reader["NomeTorneo"].ToString()
                    ,
                        TournamentId = Int32.Parse(reader["Id"].ToString())
                    ,
                        TournamentStartDate = DateTime.Parse(reader["DataInizio"].ToString())
                    });
                }

                return tornei;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }
        public static List<Disciplina> GetDisciplineByIdTorneo(int idTorneo)
        {
            SqlConnection c = null;

            try
            {
                //TODO 
                String sqlText = "select * from TorneoVsDiscipline td, Discipline d " +
                                    "where td.IdDisciplina = d.Id " +
                                    "and td.IdTorneo = " + idTorneo;

                c = new SqlConnection(GetConnectionString());

                c.Open();
                List<Disciplina> discipline = new List<Disciplina>();
                discipline.Add(new Disciplina() { IdDisciplina = 0 });

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    discipline.Add(new Disciplina()
                    {
                        IdDisciplina = Convert.ToInt32(reader["IdDisciplina"])
                        ,
                        Nome = Convert.ToString(reader["Nome"]),
                        Descrizione = Convert.ToString(reader["Descrizione"])
                    });
                }


                return discipline;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Atleta> GetAtletiTorneoVsDisciplinaAssoluti(int idTorneo, int idDisciplina, string categoria)
        {
            List<Atleta> atleti = new List<Atleta>();

            Atleta a;

            String sqlText = "select * from AtletiVsTorneoVsDiscipline atd, TorneoVsDiscipline td, atleti a, ASD, Ranking r " +
                                "where atd.IdTorneoVsDiscipline = td.Id " +
                                "and a.Id = atd.IdAtleta " +
                                "and asd.Id = a.IdASD " +
                                "and r.IdAtleta = a.Id " +
                                "and td.IdTorneo = " + idTorneo + " " +
                                "and td.IdDisciplina = " + idDisciplina + " " +
                                "and a.Sesso = '" + categoria + "' " +
                                "and r.IdDisciplina = " + idDisciplina + " " +
                                "order by r.Punteggio DESC, ASD.Nome_ASD ASC, a.Cognome ASC";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    a = new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["IdAtleta"]),
                        Ranking = Convert.ToDouble(reader["Punteggio"])
                    };

                    atleti.Add(a);
                }

                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Atleta> GetAtletiTorneoVsDisciplina(int idTorneo, int idDisciplina, string categoria)
        {

            List<Atleta> atleti = new List<Atleta>();
            List<Atleta> atletiAsd = new List<Atleta>();
            String currentAsd = "";
            Atleta a;

            String sqlText = "select * from AtletiVsTorneoVsDiscipline atd, TorneoVsDiscipline td, atleti a, ASD, Ranking r " +
                                "where atd.IdTorneoVsDiscipline = td.Id " +
                                "and a.Id = atd.IdAtleta " +
                                "and asd.Id = a.IdASD " +
                                "and r.IdAtleta = a.Id " +
                                "and td.IdTorneo = " + idTorneo + " " +
                                "and td.IdDisciplina = " + idDisciplina + " " +
                                "and a.Sesso = '" + categoria + "' " +
                                "and r.IdDisciplina = " + idDisciplina + " " +
                                "order by r.Punteggio DESC, ASD.Nome_ASD ASC, a.Cognome ASC";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    a = new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["IdAtleta"]),
                        Ranking = Convert.ToDouble(reader["Punteggio"])
                    };

                    if (currentAsd != a.Asd)
                    {
                        if (currentAsd != "")
                        {
                            var rnd = new Random();
                            atleti.AddRange(atletiAsd.OrderBy(item => rnd.Next()));
                        }

                        currentAsd = a.Asd;
                        atletiAsd.Clear();
                        atletiAsd.Add(a);
                    }
                    else
                    {
                        atletiAsd.Add(a);
                    }
                }

                if (atletiAsd.Count > 0)
                {
                    var rnd = new Random();

                    atleti.AddRange(atletiAsd.OrderBy(item => rnd.Next()));
                }

                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Atleta> GetAtletiIscrittiTorneoVsDisciplina(int idTorneo, int idDisciplina, string categoria)
        {

            List<Atleta> atleti = new List<Atleta>();

            Atleta a;

            String sqlText = "select * from AtletiVsTorneoVsDiscipline atd, TorneoVsDiscipline td, atleti a, ASD, Ranking r " +
                                "where atd.IdTorneoVsDiscipline = td.Id " +
                                "and a.Id = atd.IdAtleta " +
                                "and asd.Id = a.IdASD " +
                                "and r.IdAtleta = a.Id " +
                                "and td.IdTorneo = " + idTorneo + " " +
                                "and td.IdDisciplina = " + idDisciplina + " " +
                                "and a.Sesso = '" + categoria + "' " +
                                "and r.IdDisciplina = " + idDisciplina +
                                "order by r.Punteggio DESC, ASD.Nome_ASD ASC, a.Cognome ASC";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    a = new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["IdAtleta"]),
                        Posizionamento = Convert.ToInt32(reader["Posizionamento"]),
                        Ranking = Convert.ToDouble(reader["Punteggio"])
                    };

                    atleti.Add(a);
                }

                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Atleta> GetAtletiOffTournament(int idTorneo, int idDisciplina, string categoria)
        {
            List<Atleta> atleti = new List<Atleta>();

            String sqlText = "SELECT * FROM ATLETI WHERE Id NOT IN (SELECT atd.IdAtleta FROM AtletiVsTorneoVsDiscipline atd JOIN TorneoVsDiscipline td " +
                    " ON atd.IdTorneoVsDiscipline = td.Id AND td.Categoria = '" + categoria + "'" +
                    " WHERE td.IdTorneo = " + idTorneo + " AND td.IdDisciplina = " + idDisciplina + ") " +
                    "AND SESSO = '" + categoria + "'";


            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                atleti.Add(new Atleta() { IdAtleta = 0 });

                while (reader.Read())
                {
                    atleti.Add(new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["Id"])
                    });
                }
                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Atleta> GetAllAnagraficaAtletiWithRanking()
        {
            List<Atleta> atleti = new List<Atleta>();

            //TODO : devo selezionare il ranking di tutte le discipline
            //per ora metto di default a 0 il campo ranking
            String sqlText = "SELECT a.*, asd.Nome_ASD, 0 as Punteggio FROM Atleti a " +
                                "JOIN ASD asd ON a.IdASD = asd.Id " +
                                //"JOIN Ranking r ON r.IdAtleta = a.Id " +
                                "order by asd.Nome_ASD, a.Cognome, a.Nome";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    atleti.Add(new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["Id"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Sesso = Convert.ToString(reader["Sesso"]),
                        Ranking = Convert.ToDouble(reader["Punteggio"])
                    });
                }
                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }

        public static List<Atleta> GetAllAnagraficaAtleti()
        {
            List<Atleta> atleti = new List<Atleta>();

            String sqlText = "SELECT a.*, asd.Nome_ASD, 0 as Punteggio FROM Atleti a " +
                                "JOIN ASD asd ON a.IdASD = asd.Id " +
                                "order by asd.Nome_ASD, a.Cognome, a.Nome";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    atleti.Add(new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["Id"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Sesso = Convert.ToString(reader["Sesso"])
                    });
                }
                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (c.State == ConnectionState.Open)
                    c.Close();
            }
        }
        public static Dictionary<int, String> GetAtletiDictionary()
        {
            Dictionary<int, String> result = new Dictionary<int, String>();

            string sqlText = "select id, Cognome + ' ' + Nome as Atleta from Atleti order by Atleta";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(Convert.ToInt32(reader["id"]), Convert.ToString(reader["Atleta"]));
                }

                return result;
            }
            catch (Exception e)
            {
                return result;
            }
            finally
            {
                if (c.State == ConnectionState.Open)
                    c.Close();
            }

        }
        public static List<List<Atleta>> GetGironiSalvati(int idTorneo, int idDisciplina, string categoria)
        {
            List<Atleta> atletiGirone = new List<Atleta>();
            List<List<Atleta>> gironi = new List<List<Atleta>>();

            String sqlText = "select a.Id, a.Nome, a.Cognome, asd.Nome_ASD, g.IdGirone, g.IdTorneo, g.IdDisciplina, td.Categoria, a.IdASD, asd.Nome_ASD, r.Punteggio " +
                                "from Gironi g join Atleti a on a.Id = g.IdAtleta " +
                                "join ASD asd on asd.Id = a.IdASD " +
                                "join TorneoVsDiscipline td on td.IdDisciplina = g.IdDisciplina and td.IdDisciplina = g.IdDisciplina " +
                                "join AtletiVsTorneoVsDiscipline atd on atd.IdTorneoVsDiscipline = td.Id and atd.IdAtleta = a.Id " +
                                "join Ranking r on r.IdAtleta = a.Id " +
                                "where td.IdTorneo = g.IdTorneo " +
                                "and td.Categoria = '" + categoria + "' " +
                                "and g.IdTorneo = " + idTorneo + " " +
                                "and g.IdDisciplina = " + idDisciplina + " " +
                                "and r.IdDisciplina = " + idDisciplina +
                                "order by g.IdGirone ASC, r.Punteggio DESC, asd.Nome_ASD ASC, a.Cognome ASC";

            Atleta a;
            int currentGirone = 0;
            int gironeAtleta = 0;
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    a = new Atleta()
                    {
                        IdAsd = Convert.ToInt32(reader["IdASD"]),
                        Asd = Convert.ToString(reader["Nome_ASD"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Cognome = Convert.ToString(reader["Cognome"]),
                        IdAtleta = Convert.ToInt32(reader["Id"]),
                        Ranking = Convert.ToDouble(reader["Punteggio"])
                    };

                    gironeAtleta = Convert.ToInt32(reader["IdGirone"]);

                    if ((currentGirone != 0) && (currentGirone != gironeAtleta))
                    {
                        gironi.Add(atletiGirone);
                        atletiGirone = new List<Atleta>();
                    }

                    atletiGirone.Add(a);
                    currentGirone = gironeAtleta;
                }
                //l'ultimo ciclo
                gironi.Add(atletiGirone);

                return gironi;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        internal static int GetNumeroGironiByTorneoDisciplina(int idTorneo, int idDisciplina, string categoria)//aggiungere categoria)
        {
            //anche i tornei vs discipline vanno divisi tra maschile e femminile
            string sqlText = "SELECT * FROM TorneoVsDiscipline WHERE IdTorneo = " + idTorneo + " AND IdDisciplina = " + idDisciplina + " AND Categoria = '" + categoria + "'";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int gironi = Convert.ToInt32(reader["NumeroGironi"]);
                    if (gironi > 0)
                        return gironi;
                    else
                        return 0;
                }
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Asd> GetAllAsd()
        {
            String commandText = "SELECT * FROM Asd";

            List<Asd> asd = new List<Asd>();
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                asd.Add(new Asd() { Id = 0, NomeAsd = "" });

                while (reader.Read())
                {
                    asd.Add(new Asd()
                    {
                        Id = (int)reader["Id"],
                        NomeAsd = Convert.ToString(reader["Nome_ASD"])
                    }
                    );
                }
                if (asd.Count > 0)
                    return asd;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static List<Asd> GetAllAsdWithMembersNumber()
        {
            String commandText = "SELECT asd.Id, asd.Nome_ASD, count(*) as members " +
                                    "FROM Asd asd join Atleti a on asd.Id = a.IdASD " +
                                    "GROUP BY asd.ID, asd.Nome_ASD " +
                                    "UNION ALL " +
                                    "SELECT Id, Nome_ASD, 0 as members " +
                                    "FROM Asd where Id not in (SELECT asd.Id FROM Asd asd join Atleti a on asd.Id = a.IdASD )";

            List<Asd> asd = new List<Asd>();
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    asd.Add(new Asd()
                    {
                        Id = (int)reader["Id"],
                        NomeAsd = Convert.ToString(reader["Nome_ASD"]),
                        AtletiAssociativi = (int)reader["members"]
                    }
                    );
                }
                if (asd.Count > 0)
                    return asd;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }

        public static List<Torneo> GetAllTornei()
        {
            List<Torneo> tornei = new List<Torneo>();

            String commandText = "SELECT * FROM Torneo WHERE Concluso = 0";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tornei.Add(new Torneo()
                    {
                        TournamentId = (int)reader["Id"],
                        TournamentName = Convert.ToString(reader["NomeTorneo"]),
                        TournamentPlace = Convert.ToString(reader["Luogo"]),
                        TournamentStartDate = Convert.ToDateTime(reader["DataInizio"]),
                        TournamentEndDate = Convert.ToDateTime(reader["DataFine"])
                    }
                    );
                }
                if (tornei.Count > 0)
                    return tornei;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }
        public static List<Atleta> GetAtletiFromNameAndSurname(String name, String surname)
        {
            List<Atleta> atleti = new List<Atleta>();

            String commandText = "select at.*, asd.Nome_ASD from atleti at join ASD asd on at.IdASD = asd.Id where at.Nome like '"
                                    + name + "%' and at.Cognome like '"
                                    + surname + "%' order by at.Cognome ASC";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    atleti.Add(new Atleta()
                    {
                        IdAtleta = (int)reader["Id"],
                        IdAsd = (int)reader["IdASD"],
                        Cognome = Convert.ToString(reader["Cognome"]),
                        Nome = Convert.ToString(reader["Nome"]),
                        Sesso = Convert.ToString(reader["Sesso"]),
                        Asd = Convert.ToString(reader["Nome_ASD"])
                    }
                    );
                }
                if (atleti.Count > 0)
                    return atleti;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }
        public static void CaricaPunteggiEsistentiGironiIncontri(int idTorneo, int idDisciplina, Incontro i, int idGirone)
        {
            String commandText = "SELECT * FROM GironiIncontri WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " and NumeroGirone = " + idGirone + " " +
                                    "AND IdAtletaRosso = " + i.IdRosso + " and IdAtletaBlu = " + i.IdBlu;


            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    i.PuntiRosso = (int)reader["PuntiAtletaRosso"];
                    i.PuntiBlu = (int)reader["PuntiAtletaBlu"];
                    i.DoppiaMorte = ((int)reader["DoppiaMorte"] == 1 ? true : false);
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

        }
        public static List<AtletaEliminatorie> GetFinali(int idTorneo, int idDisciplina, int campo)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Finali q on a.Id = q.IdAtleta  WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + "and Campo = " + campo + " ORDER BY Posizione ASC";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }
        public static List<AtletaEliminatorie> GetSemifinali(int idTorneo, int idDisciplina, int campo)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Semifinali q on a.Id = q.IdAtleta  WHERE IdTorneo = " 
                + idTorneo + " and IdDisciplina = " + idDisciplina + "and Campo = " + campo + " ORDER BY Posizione ASC";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }

        public static List<AtletaEliminatorie> GetSemifinali(int idTorneo, int idDisciplina)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Semifinali q on a.Id = q.IdAtleta  WHERE IdTorneo = " 
                + idTorneo + " and IdDisciplina = " + idDisciplina + " ORDER BY Posizione ASC";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }

        public static List<AtletaEliminatorie> GetQuarti(int idTorneo, int idDisciplina, int campo)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Qualificati8 q on a.Id = q.IdAtleta  WHERE IdTorneo = " 
                + idTorneo + " and IdDisciplina = " + idDisciplina + "and Campo = " + campo + " ORDER BY Posizione ASC";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }
        public static List<AtletaEliminatorie> GetQuarti(int idTorneo, int idDisciplina)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Qualificati8 q on a.Id = q.IdAtleta" +
                " WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " ORDER BY Posizione";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {
                return new List<AtletaEliminatorie>();
            }
            finally
            {
                if(c != null)
                    c.Close();
            }

            return list;
        }
        public static List<AtletaEliminatorie> GetOttavi(int idTorneo, int idDisciplina, int campo)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Qualificati16 q on a.Id = q.IdAtleta  WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + "and Campo = " + campo + " ORDER BY Posizione ASC";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }
        public static List<AtletaEliminatorie> GetOttavi(int idTorneo, int idDisciplina)
        {
            String commandText = "SELECT a.Nome, a.Cognome, q.* from Atleti a join Qualificati16 q on a.Id = q.IdAtleta " +
                " where IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " order by Posizione";

            SqlConnection c = null;
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }
        public static List<AtletaEliminatorie> GetSedicesimi(int idTorneo, int idDisciplina)
        {
            List<AtletaEliminatorie> list = new List<AtletaEliminatorie>();

            String commandText = "select a.Nome, a.Cognome, q.* from Atleti a join Qualificati32 q on a.Id = q.IdAtleta " +
                                " where IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " order by Posizione";


            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new AtletaEliminatorie()

                    {
                        IdAtleta = (int)reader["IdAtleta"],
                        IdTorneo = (int)reader["IdTorneo"],
                        idDisciplina = (int)reader["IdDisciplina"],
                        Posizione = (int)reader["Posizione"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"]
                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return list;
        }
        public static List<GironiConclusi> GetClassificaGironi(int idTorneo, int idDisciplina)
        {

            List<GironiConclusi> gironiConclusi = new List<GironiConclusi>();

            String commandText = "SELECT a.Cognome, a.Nome, g.*, r.Posizionamento, r.Punteggio FROM Gironi g join Atleti a on a.Id = g.IdAtleta " +
                                    "JOIN Ranking r on r.IdAtleta = a.Id " +
                                    "WHERE g.IdTorneo = " + idTorneo + " and g.IdDisciplina = " + idDisciplina + " AND r.IdDisciplina = " + idDisciplina +
                                    " order by g.Differenziale desc, g.Vittorie desc, g.PuntiFatti desc , g.PuntiSubiti asc, r.Punteggio asc  ";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    gironiConclusi.Add(new GironiConclusi()
                    {
                        IdTorneo = idTorneo,
                        idDisciplina = idDisciplina,
                        IdGirone = (int)reader["IdGirone"],
                        IdAtleta = (int)reader["IdAtleta"],
                        Nome = (String)reader["Nome"],
                        Cognome = (String)reader["Cognome"],
                        Vittorie = (int)reader["Vittorie"],
                        Sconfitte = (int)reader["Sconfitte"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Differenziale = (Double)reader["Differenziale"],
                        Posizionamento = (int)reader["Posizionamento"],
                        Ranking = Convert.ToDouble(reader["Punteggio"])

                    });
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                c.Close();
            }

            return gironiConclusi;

        }

        #endregion

        #region DELETE

        public static void RestartAfterGironi()
        {
            String commandText =    "truncate table Qualificati32; " +
                                    "truncate table Qualificati16; " +
                                    "truncate table Qualificati8; " +
                                    "Truncate table Semifinali; " +
                                    "truncate table Finali";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                c.Close();
            }

        }

        public static bool EliminaPartecipanteDaTorneo(int idTorneo, int idDisciplina, int idAtleta, string categoria)
        {
            String sqlText = "delete AtletiVsTorneoVsDiscipline where IdAtleta = " + idAtleta +
                                "and IdTorneoVsDiscipline in (select Id from TorneoVsDiscipline where " +
                                "IdDisciplina = " + idDisciplina + " " +
                                "and IdTorneo = " + idTorneo + " " +
                                "and Categoria = '" + categoria + "') ";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public static bool EliminaAtleta(int idAtleta)
        {
            string commandText = "DELETE Atleti where id = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public static bool EliminaAtletaDaGironi(int idAtleta)
        {
            string commandText = "DELETE Gironi where id = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public static bool EliminaAtletaDaRanking(int idAtleta)
        {
            string commandText = "DELETE Ranking where IdAtleta = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public static bool EliminaAtletaDaTorneo(int idAtleta)
        {
            string commandText = "DELETE AtletiVsTorneoVsDiscipline were IdAtleta = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaTorneo(Int32 idTorneo)
        {
            String commandText = "DELETE Torneo where Id = " + idTorneo;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaAtletiVsTorneoVsDiscipline(Int32 idTorneo)
        {
            String commandText = "DELETE AtletiVsTorneoVsDiscipline WHERE IdTorneoVsDiscipline in " +
                                    "(SELECT Id FROM TorneoVsDiscipline WHERE IdTorneo = " + idTorneo + ")";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaTorneoVsDiscipline(Int32 idTorneo)
        {
            String commandText = "DELETE TorneoVsDiscipline WHERE IdTorneo = " + idTorneo + ")";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaFinaliByCampo(int idCampo, int idTorneo, int idDisciplina, int idAtleta)
        {
            String commandText = "DELETE FROM Finali where IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " and IdAtleta = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaSemifinaliByCampo(int idCampo, int idTorneo, int idDisciplina, int idAtleta)
        {
            String commandText = "DELETE FROM Semifinali where Campo = " + idCampo + " and IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " and IdAtleta = " + idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaOttaviByCampo(int idCampo, int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Qualificati8 where Campo = " + idCampo + " and IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool EliminaSedicesimiByCampo(int idCampo, int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Qualificati16 where Campo = " + idCampo + " and IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool DeleteAllFinali(int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Finali WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool DeleteAllSemifinali(int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Semifinali WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool DeleteAllQuarti(int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Qualificati8 WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool DeleteAllOttavi(int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Qualificati16 WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool DeleteAllSedicesimi(int idTorneo, int idDisciplina)
        {
            String commandText = "DELETE FROM Qualificati32 WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        #endregion

        #region INSERT

        public static bool InsertAtletaOnTournament(int idTorneo, int idDisciplina, int idAtleta, string categoria)
        {
            String sqlText = "DECLARE @IdTorneoVsDisciplina int; " +
                                "SET @IdTorneoVsDisciplina = (SELECT Id from TorneoVsDiscipline WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " and Categoria = '" + categoria + "'); " +
                                "INSERT INTO AtletiVsTorneoVsDiscipline values (@IdTorneoVsDisciplina, " + idAtleta + ")";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(sqlText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static Int32 InsertNewAtleta(Atleta a)
        {
            String commandText = "INSERT INTO Atleti VALUES (" +
                                a.IdAsd + ",'" + a.Cognome + "','" + a.Nome + "','" + a.Sesso + "'); " +
                                    "SELECT SCOPE_IDENTITY();";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                Int32 idInserted = 0;
                reader.Read();

                idInserted = Convert.ToInt32(reader[0]);

                if (idInserted > 0)
                {
                    int rowAffected = InsertNewRanking(idInserted);
                    //insert in ranking storico
                    if (rowAffected >= 1)
                        return idInserted;
                    else
                        return -1;
                }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                c.Close();
            }
        }

        internal static void InsertAtletaInGirone(int idTorneo, int idDisciplina, int idGirone, int idAtleta)
        {
            String commandText = "INSERT INTO Gironi VALUES (" +
                                    idTorneo + "," + idDisciplina + "," + idGirone + "," + idAtleta + ",0,0,0,0,0,0)";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        internal static void InserisciGironiIncontri(int idTorneo, int idDisciplina, List<Incontro> incontri, int idgirone)
        {
            String commandText = "";

            foreach (Incontro i in incontri)
                commandText += "INSERT INTO GironiIncontri (IdTorneo, IdDisciplina, IdAtletaRosso, PuntiAtletaRosso, IdAtletaBlu, PuntiAtletaBlu, NumeroGirone) " +
                                "VALUES(" + idTorneo + "," + idDisciplina + "," + i.IdRosso + ",0," + i.IdBlu + ",0, " + idgirone + ");";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }

        }

        public static Int32 InsertNewRanking(Int32 idAtleta)
        {
            //TODO automatizzare dalla lettura della tabella Delle Discipline
            String date = "@date";
            String commandtext =    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,1); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,2); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,3); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,4); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,5); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,6); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,7); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,8); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,9); " +
                                    "INSERT INTO Ranking VALUES (" + idAtleta + ",0," + date + "," + date + ",0,10); " +
                                    "SELECT SCOPE_IDENTITY();";

            SqlParameter p = new SqlParameter(date, System.Data.SqlDbType.DateTime) { Value = DateTime.Today };
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandtext, c);
                command.Parameters.Add(p);
                Int32 rowAffected = command.ExecuteNonQuery();

                return rowAffected;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                c.Close();
            }

        }

        public static Int32 InserNewTorneo(Torneo t)
        {
            String startDate = "@startDate";
            String endDate = "@endDate";

            String commandText = "INSERT INTO Torneo VALUES ('" + t.TournamentName + "','" + t.TournamentPlace + "'," + startDate + "," + endDate + ", 0, '')" +
                                "SELECT SCOPE_IDENTITY();";

            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter(startDate, SqlDbType.DateTime) { Value = t.TournamentStartDate},
                new SqlParameter(endDate, SqlDbType.DateTime) { Value = t.TournamentEndDate}
            };

            SqlConnection c = null;

            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                command.Parameters.Add(parms);
                SqlDataReader reader = command.ExecuteReader();

                Int32 idInserted = 0;
                reader.Read();

                idInserted = Convert.ToInt32(reader[0]);

                if (idInserted > 0)
                    return idInserted;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                c.Close();
            }
        }

        internal static void AddDisciplineToTorneo(int newTournamentId,
                                                    bool singleSword,
                                                    bool swordAndDagger,
                                                    bool swordAndBuckler,
                                                    bool swordAndShield,
                                                    bool twoHandSword,
                                                    string categoria)
        {
            String commandText = "";

            if (singleSword)
                commandText += "INSERT INTO TorneoVsDiscipline VALUES ()";
        }


        public static void InsertFinali(List<AtletaEliminatorie> listAtleti)
        {
            String commandText = "";

            foreach (AtletaEliminatorie a in listAtleti)
                commandText += "INSERT INTO Finali (IdAtleta, IdTorneo, IdDisciplina, PuntiFatti, PuntiSubiti, Posizione, Campo) " +
                                "VALUES (" + a.IdAtleta + ", " + a.IdTorneo + ", " + a.idDisciplina + ", " + "0,0," + a.Posizione + "," + a.Campo + ");";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
        }

        public static void InsertSemifinali(List<AtletaEliminatorie> listAtleti)
        {
            String commandText = "";

            foreach (AtletaEliminatorie a in listAtleti)
                commandText += "INSERT INTO Semifinali (IdAtleta, IdTorneo, IdDisciplina, PuntiFatti, PuntiSubiti, Posizione, Campo) " +
                                "VALUES (" + a.IdAtleta + ", " + a.IdTorneo + ", " + a.idDisciplina + ", " + "0,0," + a.Posizione + "," + a.Campo + ");";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
        }

        public static void InsertQuarti(List<AtletaEliminatorie> listAtleti)
        {
            String commandText = "";

            foreach (AtletaEliminatorie a in listAtleti)
                commandText += "INSERT INTO Qualificati8 (IdAtleta, IdTorneo, IdDisciplina, PuntiFatti, PuntiSubiti, Posizione, Campo) " +
                                "VALUES (" + a.IdAtleta + ", " + a.IdTorneo + ", " + a.idDisciplina + ", " + "0,0," + a.Posizione + "," + a.Campo + ");";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
        }

        public static void InsertOttavi(List<AtletaEliminatorie> listAtleti)
        {
            String commandText = "";

            foreach (AtletaEliminatorie a in listAtleti)
                commandText += "INSERT INTO Qualificati16(IdAtleta, IdTorneo, IdDisciplina, PuntiFatti, PuntiSubiti, Posizione, Campo) " +
                                "VALUES (" + a.IdAtleta + ", " + a.IdTorneo + ", " + a.idDisciplina + ", " + "0,0," + a.Posizione + "," + a.Campo + ");";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
        }

        public static void InsertSedicesimi(List<AtletaEliminatorie> listAtleti)
        {
            String commandText = "";

            foreach (AtletaEliminatorie a in listAtleti)
                commandText += "INSERT INTO Qualificati32(IdAtleta, IdTorneo, IdDisciplina, PuntiFatti, PuntiSubiti, Posizione, Campo) " +
                                "VALUES (" + a.IdAtleta + ", " + a.IdTorneo + ", " + a.idDisciplina + ", " + "0,0," + a.Posizione + ",0);";

            SqlConnection c = null;
            try
            {

                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                int rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                c.Close();
            }
        }

        #endregion

        #region UPDATE

        public static void ConcludiGironi(int idTorneo, int idDisciplina)
        {
            String commandText = "UPDATE Gironi SET Concluso = 1 where IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina;


            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        public static bool UpdateAngraficDataByAtleta(Atleta a)
        {
            String commandText = "UPDATE Atleti " +
                                    "SET IdASD = " + a.IdAsd + ", Cognome = '" + a.Cognome + "', Nome = '" + a.Nome + "', Sesso = '" + a.Sesso + "' " +
                                    "WHERE Id = " + a.IdAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

                if (rowAffected == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public static bool UpdateGironi(RisultatiIncontriGironi res, int idTorneo, int idDisciplina, int idGirone)
        {
            String commandText = "UPDATE Gironi SET Vittorie = " + res.Vittorie +
                                                    ", Sconfitte = " + res.Sconfitte +
                                                    ", PuntiFatti = " + res.PuntiFatti +
                                                    ", PuntiSubiti = " + res.PuntiSubiti +
                                                    ", Differenziale = @differenziale" +
                                                    " WHERE IdTorneo = " + idTorneo +
                                                    " and IdDisciplina = " + idDisciplina +
                                                    " and IdGirone = " + idGirone +
                                                    " and IdAtleta = " + res.idAtleta;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlParameter p = new SqlParameter("@differenziale", SqlDbType.Float, 0) { Value = res.Differenziale };

                command.Parameters.Add(p);

                Int32 rowAffected = command.ExecuteNonQuery();

                return rowAffected == 1;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }

        }


        public static void UpdateFinali(int IdTorneo, int idDisciplina, int campo, int posizione, int idAtleta, int puntiFatti, int puntiSubiti)
        {
            String commandText = "UPDATE Finali SET PuntiFatti = " + puntiFatti + ", PuntiSubiti = " + puntiSubiti +
                                    " WHERE IdAtleta = " + idAtleta + " and IdTorneo = " + IdTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        public static void UpdateSemifinali(int IdTorneo, int idDisciplina, int campo, int posizione, int idAtleta, int puntiFatti, int puntiSubiti)
        {
            String commandText = "UPDATE Semifinali SET PuntiFatti = " + puntiFatti + ", PuntiSubiti = " + puntiSubiti +
                                    " WHERE IdAtleta = " + idAtleta + " and IdTorneo = " + IdTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        /// <summary>
        /// update degli quarti
        /// </summary>
        /// <param name="IdTorneo"></param>
        /// <param name="idDisciplina"></param>
        /// <param name="campo"></param>
        /// <param name="idAtleta"></param>
        /// <param name="puntiFatti"></param>
        /// <param name="puntiSubiti"></param>
        public static void UpdateQualificati8(int IdTorneo, int idDisciplina, int campo, int posizione, int idAtleta, int puntiFatti, int puntiSubiti)
        {
            String commandText = "UPDATE Qualificati8 SET PuntiFatti = " + puntiFatti + ", PuntiSubiti = " + puntiSubiti +
                                    " WHERE IdAtleta = " + idAtleta + " and IdTorneo = " + IdTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        /// <summary>
        /// update dei ottavi
        /// </summary>
        /// <param name="IdTorneo"></param>
        /// <param name="idDisciplina"></param>
        /// <param name="campo"></param>
        /// <param name="idAtleta"></param>
        /// <param name="puntiFatti"></param>
        /// <param name="puntiSubiti"></param>
        public static void UpdateQualificati16(int IdTorneo, int idDisciplina, int campo, int posizione, int idAtleta, int puntiFatti, int puntiSubiti)
        {
            String commandText = "UPDATE Qualificati16 SET PuntiFatti = " + puntiFatti + ", PuntiSubiti = " + puntiSubiti +
                                    " WHERE IdAtleta = " + idAtleta + " and IdTorneo = " + IdTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        /// <summary>
        /// update dei sedicesimi
        /// </summary>
        /// <param name="IdTorneo"></param>
        /// <param name="idDisciplina"></param>
        /// <param name="campo"></param>
        /// <param name="idAtleta"></param>
        /// <param name="puntiFatti"></param>
        /// <param name="puntiSubiti"></param>
        public static void UpdateQualificati32(int IdTorneo, int idDisciplina, int campo, int posizione, int idAtleta, int puntiFatti, int puntiSubiti)
        {
            String commandText = "UPDATE Qualificati32 SET PuntiFatti = " + puntiFatti + ", PuntiSubiti = " + puntiSubiti +
                                    " WHERE IdAtleta = " + idAtleta + " and IdTorneo = " + IdTorneo + " and IdDisciplina = " + idDisciplina;

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                c.Close();
            }
        }

        public static bool UpdateGironiIncontri(
            int idTorneo,
            int idDisciplina,
            int idGirone,
            int idAtletaRosso,
            int puntiRosso,
            int idAtletaBlu,
            int puntiBlu,
            bool doppiaMorte)
        {

            String commandText = "UPDATE GironiIncontri SET PuntiAtletaRosso = " + puntiRosso +
                                    ", PuntiAtletaBlu = " + puntiBlu +
                                    ", DoppiaMorte = " + (doppiaMorte ? 1 : 0) + " " +
                                    "WHERE IdTorneo = " + idTorneo + " and IdDisciplina = " + idDisciplina + " and NumeroGirone = " + idGirone + " " +
                                    "AND ((IdAtletaRosso = " + idAtletaRosso + " and IdAtletaBlu = " + idAtletaBlu
                                    + ") OR (IdAtletaRosso = " + idAtletaBlu + " and IdAtletaBlu = " + idAtletaRosso + "))";


            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                Int32 rowAffected = command.ExecuteNonQuery();
                if (rowAffected == 1)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                c.Close();
            }

        }

        #endregion

        #region REPORT

        public static List<OutputRisultatiTorneo> GetExportGironiTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiTorneo> result = new List<OutputRisultatiTorneo>();

            String commandText = "SELECT rosso.Id IdRosso, rosso.Cognome as CognomeAtletaRosso, rosso.Nome as NomeAtletaRosso, gi.PuntiAtletaRosso, blu.Id IdBlu, blu.Cognome CognomeAtletaBlu, blu.Nome as NomeAtletaBlu, gi.PuntiAtletaBlu, NumeroGirone as Field " +
                                    "FROM GironiIncontri gi " +
                                    "join Atleti rosso on gi.IdAtletaRosso = rosso.Id " +
                                    "join Atleti blu on gi.IdAtletaBlu = blu.Id " +
                                    "where gi.IdTorneo = " + idTorneo + " " +
                                    "and gi.IdDisciplina = " + idDisciplina + " " +
                                    "and rosso.Sesso = '" + categoria + "' " +
                                    "and blu.Sesso = '" + categoria + "' " +
                                    "order by NumeroGirone ";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiTorneo
                    {
                        IdRosso = (int)reader["IdRosso"],
                        CognomeRosso = (string)reader["CognomeAtletaRosso"],
                        NomeRosso = (string)reader["NomeAtletaRosso"],
                        PuntiRosso = (int)reader["PuntiAtletaRosso"],
                        Idblu = (int)reader["IdBlu"],
                        CognomeBlu = (string)reader["CognomeAtletaBlu"],
                        NomeBlu = (string)reader["NomeAtletaBlu"],
                        PuntiBlu = (int)reader["PuntiAtletaBlu"],
                        Campo = (int)reader["Field"]
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }
        }

        public static List<OutputRisultatiEliminatorieTorneo> GetExportSedicesimiTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiEliminatorieTorneo> result = new List<OutputRisultatiEliminatorieTorneo>();

            String commandText = "select g.Posizione, g.IdAtleta, a.Cognome, a.Nome, g.PuntiFatti, g.PuntiSubiti, Campo " +
                                    "from Qualificati32 g " +
                                    "join Atleti a on a.Id = g.IdAtleta " +
                                    "where IdTorneo = " + idTorneo + " " +
                                    "and IdDisciplina = " + idDisciplina + " " +
                                    "and a.Sesso = '" + categoria + "' " +
                                    "order by posizione";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiEliminatorieTorneo
                    {
                        Posizione = (int)reader["Posizione"],
                        IdAtleta = (int)reader["IdAtleta"],
                        CognomeAtleta = (string)reader["Cognome"],
                        NomeAtleta = (string)reader["Nome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Campo = Convert.ToInt32(reader["Campo"])
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }

        public static List<OutputRisultatiEliminatorieTorneo> GetExportOttaviTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiEliminatorieTorneo> result = new List<OutputRisultatiEliminatorieTorneo>();

            String commandText = "select g.Posizione, g.IdAtleta, a.Cognome, a.Nome, g.PuntiFatti, g.PuntiSubiti, Campo " +
                                    "from Qualificati16 g " +
                                    "join Atleti a on a.Id = g.IdAtleta " +
                                    "where IdTorneo = " + idTorneo + " " +
                                    "and IdDisciplina = " + idDisciplina + " " +
                                    "and a.Sesso = '" + categoria + "' " +
                                    "order by Campo";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiEliminatorieTorneo
                    {
                        Posizione = (int)reader["Posizione"],
                        IdAtleta = (int)reader["IdAtleta"],
                        CognomeAtleta = (string)reader["Cognome"],
                        NomeAtleta = (string)reader["Nome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Campo = Convert.ToInt32(reader["Campo"])
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }

        public static List<OutputRisultatiEliminatorieTorneo> GetExportQuartiTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiEliminatorieTorneo> result = new List<OutputRisultatiEliminatorieTorneo>();

            String commandText = "select g.Posizione, g.IdAtleta, a.Cognome, a.Nome, g.PuntiFatti, g.PuntiSubiti, Campo " +
                                    "from Qualificati8 g " +
                                    "join Atleti a on a.Id = g.IdAtleta " +
                                    "where IdTorneo = " + idTorneo + " " +
                                    "and IdDisciplina = " + idDisciplina + " " +
                                    "and a.Sesso = '" + categoria + "' " +
                                    "order by Campo";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiEliminatorieTorneo
                    {
                        Posizione = (int)reader["Posizione"],
                        IdAtleta = (int)reader["IdAtleta"],
                        CognomeAtleta = (string)reader["Cognome"],
                        NomeAtleta = (string)reader["Nome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Campo = Convert.ToInt32(reader["Campo"])
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }

        public static List<OutputRisultatiEliminatorieTorneo> GetExportSemifinaliTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiEliminatorieTorneo> result = new List<OutputRisultatiEliminatorieTorneo>();

            String commandText = "select g.Posizione, g.IdAtleta, a.Cognome, a.Nome, g.PuntiFatti, g.PuntiSubiti, Campo " +
                                    "from Semifinali g " +
                                    "join Atleti a on a.Id = g.IdAtleta " +
                                    "where IdTorneo = " + idTorneo + " " +
                                    "and IdDisciplina = " + idDisciplina + " " +
                                    "and a.Sesso = '" + categoria + "' " +
                                    "order by Campo";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiEliminatorieTorneo
                    {
                        Posizione = (int)reader["Posizione"],
                        IdAtleta = (int)reader["IdAtleta"],
                        CognomeAtleta = (string)reader["Cognome"],
                        NomeAtleta = (string)reader["Nome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Campo = Convert.ToInt32(reader["Campo"])
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }

        public static List<OutputRisultatiEliminatorieTorneo> GetExportFinaliTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            List<OutputRisultatiEliminatorieTorneo> result = new List<OutputRisultatiEliminatorieTorneo>();

            String commandText = "select g.Posizione, g.IdAtleta, a.Cognome, a.Nome, g.PuntiFatti, g.PuntiSubiti, Campo " +
                                    "from Finali g " +
                                    "join Atleti a on a.Id = g.IdAtleta " +
                                    "where IdTorneo = " + idTorneo + " " +
                                    "and IdDisciplina = " + idDisciplina + " " +
                                    "and a.Sesso = '" + categoria + "' " +
                                    "order by Campo";
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(GetConnectionString());

                c.Open();

                SqlCommand command = new SqlCommand(commandText, c);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new OutputRisultatiEliminatorieTorneo
                    {
                        Posizione = (int)reader["Posizione"],
                        IdAtleta = (int)reader["IdAtleta"],
                        CognomeAtleta = (string)reader["Cognome"],
                        NomeAtleta = (string)reader["Nome"],
                        PuntiFatti = (int)reader["PuntiFatti"],
                        PuntiSubiti = (int)reader["PuntiSubiti"],
                        Campo = Convert.ToInt32(reader["Campo"])
                    });
                }
                if (result.Count > 0)
                    return result;
                else
                    return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                c.Close();
            }

        }
        #endregion
    }
}
