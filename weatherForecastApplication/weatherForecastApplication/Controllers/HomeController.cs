using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;

namespace weatherForecastApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string conString = "Data Source=SQL5041,1433;Initial Catalog=DB_A50C18_emre;User Id=DB_A50C18_emre_admin;Password=emre9797";
            //"Data Source=SQL5041,1433;Initial Catalog=DB_A50C18_emre;User Id=DB_A50C18_emre_admin;Password=emre9797;";
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Hava";
            con.Open();

            DateTime dt = DateTime.UtcNow;
            String guncelTarihGun = TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).Day.ToString();
            String guncelTarihAy = TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).Month.ToString();
            ArrayList Sicaklik = new ArrayList();
            ArrayList Basinc = new ArrayList();
            ArrayList Nem = new ArrayList();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (guncelTarihGun + "." + guncelTarihAy == (dr["GUN"] + "." + dr["AY"]).ToString() && dr["Istasyon_Adi"].ToString().Equals("KUTAHYA"))
                {
                    for (int i = 0; i < 13; i++)
                    {
                        dr.Read();
                        Sicaklik.Add(dr["ORTALAMA_SICAKLIK_C"]);
                        Basinc.Add(dr["ORTALAMA_AKTUEL_BASINC_hPa"]);
                        Nem.Add(dr["ORTALAMA_NEM_"]);
                    }
                }
            }
            dr.Close();
            con.Close();


            int[] predictionTemp = new int[8];
            int a = 0;
            int b = 2;
            for (int j = 1; j < 8; j++)
            {
                for (; a < b; a++)
                {
                    predictionTemp[j] += Int32.Parse(Sicaklik[a].ToString());
                }
                predictionTemp[j] /= 2;
                b++;
                a = b - 2;
            }
            TempData["predictionTemp1"] = predictionTemp[1];
            TempData["predictionTemp2"] = predictionTemp[2];
            TempData["predictionTemp3"] = predictionTemp[3];
            TempData["predictionTemp4"] = predictionTemp[4];
            TempData["predictionTemp5"] = predictionTemp[5];
            TempData["predictionTemp6"] = predictionTemp[6];
            TempData["predictionTemp7"] = predictionTemp[7];


            int predictionPressure = 0;
            for(int i = 0; i < 3; i++)
            {
                predictionPressure += Int32.Parse(Basinc[i].ToString());
            }
            predictionPressure /= 3;
            TempData["predictionPressure"] = predictionPressure;

            int[] predictionRain = new int[8];
            int x = 0;
            int y = 2;
            for (int j = 1; j < 8; j++)
            {
                for (; x < y; x++)
                {
                    predictionRain[j] += Int32.Parse(Nem[x].ToString());
                }
                predictionRain[j] /= 2;
                y++;
                x = y - 2;
            }
            int[] rain = new int[8];
            for (int j = 1; j < 8; j++) {
                if (predictionRain[j] - 85 > 0)
                {
                    rain[j] = (predictionRain[j] - 85) * 5;
                }
            }
            TempData["predictionRain1"] = rain[1];
            TempData["predictionRain2"] = rain[2];
            TempData["predictionRain3"] = rain[3];
            TempData["predictionRain4"] = rain[4];
            TempData["predictionRain5"] = rain[5];
            TempData["predictionRain6"] = rain[6];
            TempData["predictionRain7"] = rain[7];

            TempData["predictionHumidity1"] = predictionRain[1];
            TempData["predictionHumidity2"] = predictionRain[2];
            TempData["predictionHumidity3"] = predictionRain[3];
            TempData["predictionHumidity4"] = predictionRain[4];
            TempData["predictionHumidity5"] = predictionRain[5];
            TempData["predictionHumidity6"] = predictionRain[6];
            TempData["predictionHumidity7"] = predictionRain[7];


            String[] weatherSymbol = new string[8];
            for (int j = 1; j < 8; j++)
            {
                if (rain[j] > 50)
                {
                    weatherSymbol[j] = "/images/icons/icon-10.svg";
                    if (predictionTemp[j] <= 1)
                    {
                        weatherSymbol[j] = "/images/icons/icon-14.svg";
                    }
                    if (predictionTemp[j] >= 10)
                    {
                        weatherSymbol[j] = "/images/icons/icon-4.svg";
                    }
                }
                else if (rain[j] <= 50 && rain[j] >= 35)
                {
                    weatherSymbol[j] = "/images/icons/icon-9.svg";
                }
                else if (rain[j] <= 35 && rain[j] > 15)
                {
                    if (predictionTemp[j] >= 9)
                    {
                        weatherSymbol[j] = "/images/icons/icon-2.svg";
                    }
                    else if (predictionTemp[j] < 9 && predictionTemp[j] >= 6)
                    {
                        weatherSymbol[j] = "/images/icons/icon-3.svg";
                    }
                    else
                    {
                        weatherSymbol[j] = "/images/icons/icon-6.svg";
                    }
                }
                else if (rain[j] <= 15)
                {
                    if(predictionTemp[j] >= 10)
                        weatherSymbol[j] = "/images/icons/icon-2.svg";
                    else if ((predictionTemp[j] >= 5 && (predictionTemp[j] < 10)))
                        weatherSymbol[j] = "/images/icons/icon-3.svg";
                    else
                        weatherSymbol[j] = "/images/icons/icon-5.svg";
                }
                else
                    weatherSymbol[j] = "/images/icons/icon-3.svg";
            }
            TempData["predictionSymbol1"] = weatherSymbol[1];
            TempData["predictionSymbol2"] = weatherSymbol[2];
            TempData["predictionSymbol3"] = weatherSymbol[3];
            TempData["predictionSymbol4"] = weatherSymbol[4];
            TempData["predictionSymbol5"] = weatherSymbol[5];
            TempData["predictionSymbol6"] = weatherSymbol[6];
            TempData["predictionSymbol7"] = weatherSymbol[7];

            TempData["Tarih"] = TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).ToString("dd/MM/yyyy");
            TempData["gunAdi1"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).DayOfWeek];
            TempData["gunAdi2"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(1).DayOfWeek];
            TempData["gunAdi3"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(2).DayOfWeek];
            TempData["gunAdi4"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(3).DayOfWeek];
            TempData["gunAdi5"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(4).DayOfWeek];
            TempData["gunAdi6"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(5).DayOfWeek];
            TempData["gunAdi7"] = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).AddDays(6).DayOfWeek];
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}