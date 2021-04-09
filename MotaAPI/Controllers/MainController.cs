using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using System.Data;
// using Microsoft.Data.SqlClient;

namespace MotaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly AppContext _context;

        public MainController(AppContext context)
        {
            _context = context;
        }

        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpGet("/{info}")]
        public IActionResult Get(string info)
        {
            Console.Error.WriteLine("Number 1" + info);
            Console.WriteLine("Number 2" + info);

            return Ok("Virkaði: " + info);

        }

        public class Mot
        {
            public string strengur { get; set; }
        }

        [HttpPost("/post")]
        public async Task<ActionResult<Mot>> PostCompetition(Mot mot)
        {
            try
            {
                if (mot == null)
                {
                    Console.Error.WriteLine("Number 3");
                    return BadRequest();
                }
                Console.Error.WriteLine("Number 4 " +mot.strengur);

                CreateCompetition2();

                return Ok();
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Number 5");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new Competition");
            }
        }

        public void CreateCompetition2()
        {
            // Get the code for the new competition
            string code = SkilaNaestaMotanr();
            // Todo: Create variables to pass to CreateAthl_Competition

           
            DateTime now = DateTime.Now;
            byte[] timestamp = BitConverter.GetBytes(now.ToBinary());
            string name = "Prufumót_Steini";
            string location = "Reykjavík";
            DateTime Date1 = now;
            DateTime Date2 = now;
            DateTime Date3 = now;
            string Organizer = "ÍR";
            string Director = "";
            string Judge = "";
            int OutdoorsOrIndoors = 0;
            int CompetitonType = 0;
            int fjolditilstiga = 0;
            int stigfyrir1saeti = 0;
            int stigfyrir2saeti = 0;
            byte allirfastig = 0;
            int tegundstigakeppni = 0;
            int fjoldibrauta = 0;
            Decimal skraningargjaldprgrein = 0;
            string undirskriftgjaldkera = "";
            Byte rafmagnstimataka = 0;
            string heitiiafrekaskra = "";
            int fjoldiumferdaitaeknigreinum = 0;
            Byte staðurgreinainnanbæjarfélags = 0;
            DateTime dagsetning4 = now;
            DateTime Tími = now;
            Decimal Skráningargjld_f__boðhlaup = 0;
            Byte vantardagogmanud = 0;
            Decimal lengdikm = 0;
            string systurhlaup1 = "";
            string systurhlaup2 = "";
            string systurhlaup3 = "";
            string hlaupmotifyrra = "";
            int vidbotvtimatoku1 = 0;
            string greiniafrekaskra = "";
            Byte bokadiafrekaskra = 0;
            string vidbotvtimatoku = "";
            Byte endanlegurslitskrad = 0;
            DateTime raesitimi = now;
            Byte synaathugasemd = 0;
            Byte oldungaflokkar = 0;
            int tungumal = 0;
            Byte synafelag = 0;
            Byte synaheitisveitar = 0;
            string taknhlaupsvidinnlestur = "";
            string ensktheitiamoti = "";
            string heitihtmlsidu = "";
            Byte aldursflokkamot = 0;
            Byte makeppauppfyrirsig = 0;
            Byte ritarablodmedislmeti = 0;
            Byte synaland = 0;
            string athugasemdaurslitabladi = "";
            Byte Reikna_unglingastig = 0;
            DateTime dagssídastuppfaert = now;
            DateTime timisídastuppfaert = now;
            Byte bodhlaupmedmismsprettum = 0;
            string textividgesti = "";
            Byte synanettotima = 0;
            string greiniafrekaskraflogutimi = "";
            Byte notafelagafkeppendaspjaldi = 0;
            Byte lokamotivafrekaskrar = 0;
            Byte landistadfelags = 0;
            Byte ekkibirtaiafrekaskra = 0;
            string slodaurslitmots = "";
            Byte synamillitima1 = 0;
            Byte synamillitima2 = 0;
            string heitialista = "";
            string keppnisvollur = "";
            Byte floguhlaup = 0;
            int nanaritegund = 0;
            string hlaupaseria = "";
            string flokkurhlaups = "";
            string tegundmots = "";
            Byte synamillitima3 = 0;
            Decimal teljarialltaf1 = 0;
            Byte Stofna_nýjan_v_innles_á_millit = 0;
            string Millitímar_teknir_eftir = "";
            Byte Nota_aðeins_ársbesta_við_röðun = 0;
            string Tímabil_ársbesta_frá_mótsdags = "";
            Byte Reikna_IAAF_stig = 0;
            Byte Má_prenta_úrslit_frá_Scheduler = 0;
            Byte synamillitima4 = 0;
            Byte synamillitima5 = 0;
            Byte Með_rásnúmeri = 0;
            Byte Sleppa_í_afhendingu_rásnúmera = 0;
            Decimal Skráningargj__yngri_en_18_ára = 0;
            Decimal Skráningargj__f_boðhl_y_18_ára = 0;
            int CompetitorsMinimumAge = 0;
            int Staða_móts = 0;
            int EntryFeeType = 0;
            Decimal EntryFeePrClub = 0;
            int MaxAgeForFee1 = 0;
            Decimal EntryFeePrCompetitor1 = 0 ;
            int MaxAgeForFee2 = 0;
            Decimal EntryFeePrCompetitor2 = 0;
            int MaxAgeForFee3 = 0;
            Decimal EntryFeePrCompetitor3 = 0;
            Decimal MaximumEntryFeePrCompetitor = 0;
            int DefaultTabOrderOnEntryForms = 0;
            Byte DisplayColumnForPrizeCeremony = 0;
            Byte CompetitionFinalized = 0;

            Athl_Competition comp = Athl_Competition.CreateAthl_Competition(timestamp, code, name, location, Date1, Date2, Date3, Organizer, Director, Judge, OutdoorsOrIndoors,
               CompetitonType, fjolditilstiga, stigfyrir1saeti, stigfyrir2saeti, allirfastig, tegundstigakeppni, fjoldibrauta, skraningargjaldprgrein, undirskriftgjaldkera,
               rafmagnstimataka, heitiiafrekaskra, fjoldiumferdaitaeknigreinum, staðurgreinainnanbæjarfélags, dagsetning4, Tími, Skráningargjld_f__boðhlaup, vantardagogmanud,
               lengdikm, systurhlaup1, systurhlaup2, systurhlaup3, hlaupmotifyrra, vidbotvtimatoku1, greiniafrekaskra, bokadiafrekaskra, vidbotvtimatoku, endanlegurslitskrad,
               raesitimi, synaathugasemd, oldungaflokkar, tungumal, synafelag, synaheitisveitar, taknhlaupsvidinnlestur, ensktheitiamoti, heitihtmlsidu, aldursflokkamot,
               makeppauppfyrirsig, ritarablodmedislmeti, synaland, athugasemdaurslitabladi, Reikna_unglingastig, dagssídastuppfaert, timisídastuppfaert, bodhlaupmedmismsprettum,
               textividgesti, synanettotima, greiniafrekaskraflogutimi, notafelagafkeppendaspjaldi, lokamotivafrekaskrar, landistadfelags, ekkibirtaiafrekaskra, slodaurslitmots,
               synamillitima1, synamillitima2, heitialista, keppnisvollur, floguhlaup, nanaritegund, hlaupaseria, flokkurhlaups, tegundmots, synamillitima3, teljarialltaf1,
               Stofna_nýjan_v_innles_á_millit, Millitímar_teknir_eftir, Nota_aðeins_ársbesta_við_röðun, Tímabil_ársbesta_frá_mótsdags, Reikna_IAAF_stig,
               Má_prenta_úrslit_frá_Scheduler, synamillitima4, synamillitima5, Með_rásnúmeri, Sleppa_í_afhendingu_rásnúmera, Skráningargj__yngri_en_18_ára,
               Skráningargj__f_boðhl_y_18_ára, CompetitorsMinimumAge, Staða_móts, EntryFeeType, EntryFeePrClub, MaxAgeForFee1, EntryFeePrCompetitor1, MaxAgeForFee2,
               EntryFeePrCompetitor2, MaxAgeForFee3, EntryFeePrCompetitor3, MaximumEntryFeePrCompetitor, DefaultTabOrderOnEntryForms, DisplayColumnForPrizeCeremony,
               CompetitionFinalized);

            _context.athl_Competition.Add(comp);
            _context.SaveChanges();
        }

        public SqlConnection OpenConnection()
        {
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnStr;
            connection.Open();

            return connection;
        }

        public string SkilaNaestaMotanr()
        {
            string SidastaTaknMots = "";
            string NaestaTaknMots;
            //string Tolustafahluti;
            string Tolustafahluti2;
            Int32 Tolust = 0;
            //int TolustafirByrjaI = -1;
            //int ix = 0;

            // var rowsAffected = _context.code.ExecuteSqlRaw("SELECT TOP 1 Code FROM [Athletics].[dbo].[Athl$Competition] WHERE Code LIKE 'M-%' order by Code DESC").ToString();

            SqlConnection objConn = OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 Code FROM [Athletics].[dbo].[Athl$Competition] WHERE Code LIKE 'M-%' order by Code DESC", objConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Comp");
            DataTable dt = ds.Tables["Comp"];
            SidastaTaknMots = "";
            foreach (DataRow row in dt.Rows)
            {
                SidastaTaknMots = Convert.ToString(row[0]);
            }

            if (SidastaTaknMots == String.Empty)
            {
                NaestaTaknMots = "M-00000001";
            }
            else
            {
                Tolust = Convert.ToInt32(SidastaTaknMots.Substring(2));
                Tolust = Tolust + 1;
                Tolustafahluti2 = Convert.ToString(Tolust);
                NaestaTaknMots = "M-" + "0000000000".Substring(1, 8 - Tolustafahluti2.Length) + Tolustafahluti2;
            }

            return NaestaTaknMots;

        }


        public void CreateCompetition()
        {
            // var connection = _context.Database.GetDbConnection();

            // var rows = _context.Database.FromSqlRaw("select Code from Athl$Competition where Code = '19COCACOLA'");
            // var rows = _context.Database.FromSqlInterpolated($"SELECT * FROM Checks WHERE Organisation = '19COCACOLA'");
            /*var rows = _context.Database.FromSqlInterpolated($"select Code from Athl$Competition where Code = '19COCACOLA'");

            var blogs = _context.Database.;

            var DataSource = from employee in _context.Employees
                         where employee.Gender == "Male"
                                            order by employee.Salary descending
                                            select employee;*/

            /*using (SqlConnection conn = new SqlConnection("Server=82.221.94.225;Database=Athletics;User Id=a;Password=Langst0kk.;"))
            {
                //retrieve the SQL Server instance version
                string query = @"select Code from Athl$Competition where Code = '19COCACOLA'";

                SqlCommand cmd = new SqlCommand(query, conn);

                //open connection
                conn.Open();

                //execute the SQLCommand
                SqlDataReader dr = cmd.ExecuteReader();

                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var car = dr.GetString(0);
                        //display retrieved record (first column only/string value)
                        Console.WriteLine(dr.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
                dr.Close();
            }*/


            /*var rowsAffected = _context.Database
            .ExecuteSqlRaw(
                @"UPDATE Student
                  SET Age = {0} 
                  WHERE Name = {1}", 29, "Mike Miles");*/
            //return Ok(new { RowsAffected = rowsAffected } );

            string QueryString = @"Insert into Athl$Competition
                  (column1, column2, column3, ...)
                   VALUES (value1, value2, value3, ...)";

            var rowsAffected = _context.Database
            .ExecuteSqlRaw(
                  @"Insert Student
                  SET Age = {0} 
                  WHERE Name = {1}", 29, "Mike Miles");
            // return Ok(new { RowsAffected = rowsAffected });

            return;
           
        }

    }
}
