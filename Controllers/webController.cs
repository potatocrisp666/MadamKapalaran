using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class webController : Controller
    {
        // GET: web
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Horoscope() {
            string fname = Request.Form["fname"];
            string lname = Request.Form["lname"];
            string stat = Request.Form["status"];
            string month = Request.Form["Month"];
            string datetmp = Request.Form["Date"];
            int date = Int32.Parse(datetmp);
            string yeartmp = Request.Form["Year"];
            int year = Int32.Parse(yeartmp);
            string birthdate = month + "-" + date + "-" + year;

            DateTime bdate = DateTime.Parse(birthdate);
            int age = DateTime.Today.Year - bdate.Year;

            ViewBag.Birthdate = birthdate;
            ViewBag.Age = age;
            ViewBag.Year = year;
            ViewBag.Month = month;
            ViewBag.Date = date;
            ViewBag.Fname = fname.Remove(1).ToUpper()+fname.Substring(1);
            ViewBag.Lname = lname.Remove(1).ToUpper()+lname.Substring(1);
            ViewBag.status = stat;

            string initialF = fname.Substring(0, 1).ToUpper();
            string initialL = lname.Substring(0, 1).ToUpper();

            ViewBag.InitialF = initialF;
            ViewBag.InitialL = initialL;

            string zodiac = string.Empty;
            string zodiac_msg = string.Empty;
            string stat_msg = string.Empty;
            string lucky_color = string.Empty;
            string bad_luck = string.Empty;

            switch (bdate.Year%12) {

                case 0:
                    zodiac = "Monkey";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga gipanganak sa year of the Monkey. Pag-bantay sa mga bag-ong amigo/amiga, wala ka kabalo, isa sa ilaha silahis.";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Red";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Pagbantay sa kolor pula, Lucky kolor nimo ni kay sugton nakas imong gipanguyaban, apan pula-pula usab imong mga grado.";
                    ViewBag.BL = bad_luck;
                    
                    break;
                case 1:
                    zodiac = "Rooster";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga gi anak ani nga mga tuiga, mao ning pinakaswerte nga tuiga imong kinabuhi, makita na nimo imong Forever kunuhay, apan amigo/amiga ra diay gyapon iyang feelings para sa imoha.";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "bayolet";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Pagbantay sa baga ug aso nga lugar, basin wala nimo damha, apil nakas sunog anang dapita.";
                    ViewBag.BL = bad_luck;
                    break;
                case 2:
                    zodiac = "Dog";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga na anak aning tuiga, hastang malasa gyud nimo karon nga tuig, ayaw na katingala nga bati kag nawong kay bati jud na tanan, dli lang ka malas karon ngtuig, sa tanan katuigan na gyud naa.";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Rain BOW !";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Likayi ang mga lugar nga daghan ug tao, Basin maalaan kag tulisan";
                    ViewBag.BL = bad_luck;
                    break;
                case 3:
                    zodiac = "Pig";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga na anak ani nga mga tuiga, Good job!ma hired naka sa trabaho nga Php. 2,000.00 - Php. 3,000.00 kada semana ang madawatan, excited naka kay e orient namo, apan wala nimo damha networking imong nasudlan nga abi nimo trabahoan na !";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "White";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw na patunto sa imong mga kaila nga maka dawat kagdagko nga salapi, scam na power of networking";
                    ViewBag.BL = bad_luck;
                    break;
                case 4:
                    zodiac = "Rat";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa gipanganak ug  ani nga mga tuiga, daghan Pakboi ug pakgirl natawo aning nga mga tuiga, hinay-hinaylang mo mga langga, ulaw raba palit tambal sa sira";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Colore less";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw kumpyansa kay mailad raka's tao nga kapamilya ra gyapon nimo sa mga pakboi/pakgirl.";
                    ViewBag.BL = bad_luck;
                    break;
                case 5:
                    zodiac = "Ox";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa natawo ani nga mga tuiga, Magpasalamaton ka sa ginoo kay bisan unsa na nga mga trials imong naagian, nalampasan ra gyapon nimo, tungod sa imong zodiac year nga OX , maong Ox raka permi !";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Black";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw padala sa mga korny nga joke!, ikaw ray gi ilad ana!";
                    ViewBag.BL = bad_luck;
                    break;
                case 6:
                    zodiac = "Tiger";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga dalaga ug ulitawo nga natawo ani nga mga tuiga, pag tigum namog sugod kung makatrabaho namo kay, magpalibre nasad imong mga hangol nga mga amigo/amiga. Advice sa imoha, permi ka mag Cash Advance arun wala nakay makuha sa imong ting sweldo nga ilang gihulat nga adlaw!";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Color Coding";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Sa sige nimog Cash Advance, wala nimo gi huna2 nga overdropped naka, wala nakay panggastos sa imong adlaw-adlaw nga kinahanglanon";
                    ViewBag.BL = bad_luck;
                    break;
                case 7:
                    zodiac = "Rabbit";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga natawo ani nga mga tuiga, naay madawat nimo nga bag.ong balita sa inyong lugar . Imong mga classmate ug mga kaila naa nay mga anak, apan ikaw masking lablayp ZERO. ligo-ligo sad lage pag may time";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Green";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw pagdahom nga maka anak ka, wala kay matres";
                    ViewBag.BL = bad_luck;
                    break;
                case 8:
                    zodiac = "Dragon";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga natawo aning mga tuiga, kamo ang mga isog ug dugo , mga hitsuraan , mga palaban , walay gikahadlokan , apan kung sa gugma masakitan, lupig pay namatyan";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Sky Black";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw pag sulod ug usa ka relasyon kay mao rani hinungdan nga ma pakboi/pakgirl ka !";
                    ViewBag.BL = bad_luck;
                    break;
                case 9:
                    zodiac = "Snake";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga natawo ani nga mga tuiga, wala nakoy ma say, maklaro na daan sa inyong zodiac year !";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Brown";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Wala kay badluck kay permi raka go, bira bisan asa .";
                    ViewBag.BL = bad_luck;
                    break;
                case 10:
                    zodiac = "Horse";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga natawo ani nga mga tuiga, hapsay na ang dagan sa inyong kaugmaon, hapit namo mu lambo ug mamilyonaro/milyonarya , apan kwarta nalang ang kulang ";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Dirty White";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Mangatol imong palad ug ga dahom naka nga maka dawat kag dakong kantitad nga salapi. Wala nimo damha, kagid ra diay to ni abot dili salapi";
                    ViewBag.BL = bad_luck;
                    break;
                case 11:
                    zodiac = "Goat";
                    ViewBag.zodiac = zodiac;
                    zodiac_msg = "Sa mga natawo aning mga tuiga , mapasalamaton ka sa mga tao nga naa sa imong palibot kay kung wala sila , dili ka himsog ug healthy kung wala sila, gituman gyud nimo ang saying nga Food is Life, but Libre is Lifer  ";
                    ViewBag.msg = zodiac_msg;
                    lucky_color = "Pink";
                    ViewBag.LC = lucky_color;
                    bad_luck = "Ayaw pag uban ug kaon sa mga buffet or eat all you can nga restaurant kay maka double pay jud nang imong gi ubanan, pagtoon pud intawo'g kalooy ug kaulaw !";
                    ViewBag.BL = bad_luck;
                    break;

            }
            return View();

        }

    }
}