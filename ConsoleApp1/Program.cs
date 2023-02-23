using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hazırlayanın adı ve soyadı : Zeynep Erva YALINDAĞ");
            Console.WriteLine("İsmi girilen ülkelerdeki üniversiteler dünyanın ilk 100 üniversitesi arasına girmiş midir ve bu giren üniversiteler dünyanın en iyi kaçıncı ünivesitedidir sorularını yanıtlayan bir projedir.");
            Console.WriteLine();
            for (; ; )
            {
                Console.WriteLine("Bir ülke ismi giriniz :");
                string ulke = Console.ReadLine();
                X nesne = new X(ulke);
                nesne.Yazdir();
            }
        }
    }
    class X
    {
        private string mulke;
        public string degeratama
        {
            set
            {
                mulke = value;
            }
            get
            {
                return mulke;
            }
        }
        public X(string mulke)
        {
            this.mulke = mulke;
         }
        public void Yazdir()
        {
            if (this.mulke == "Afganistan")
            {
                Console.WriteLine("Afganistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Almanya")
            {
                Console.WriteLine("Almanya'da dünya sıralamasında ilk 100'e giren üniversite vardır : LMU Munich (32.), Technical University of Munich (38.), Heidelberg University (42.), Charite - Universitatsmedizin Berlin (73.), Humboldy University of Berlin (74.), University of Tübingen (78.), Free University of Berlin (83.)");
            }
            else if (this.mulke == "ABD")
            {
                Console.WriteLine("ABD'de dünya sıralamasında ilk 100'e giren üniversite vardır : California Institute of Technology (2.), Harvard University (3.),Stanford University (4.), Massachusetts Institute of Techonology (6.), Princeton University (7.), University of California,Berkeley (8.), Yale University (9.), The University of Chicago (11.), Johns Hopkins University (13.), University of Pennsylvania (14.), University of California,Los Angeles (20.), Cornell University (22.), Duke University (23.), University of Michigan-Ann Arbor (24.), Northwestern University (25.), New York University (26.), Carnegie Mellon University (28.), University of Wahington (29.), University of California,San Diego (34.), Georgia Institute of Technology (45.), University of Texas at Austin (47.), University of Illinois at Urbana - Chanpaign (48.), Washington University in St Louis (51.), University of North Carolina at Chapel Hill (52.), University of Wisconsin - Madison (59.), Boston University (62.), University of Southern California (63.), Brown University (64.), Universsity of California,Davis (67.), University of California,Santa Barbara (68.), Emory University (82.), Ohio State University (Main Campus) (85.), University of Minnesota (86.), University of MaryLand,College Park (94.), Michigan State University (95.), Universiy of California,Irvine (98.), Datmouth College (99.)");
            }
            else if (this.mulke == "Andora")
            {
                Console.WriteLine("Andora'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Angola")
            {
                Console.WriteLine("Angola'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Antigua ve Barbuda")
            {
                Console.WriteLine("Antigua ve Barbuda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Arjantin")
            {
                Console.WriteLine("Arjantin'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Avustralya")
            {
                Console.WriteLine("Avustralya'da dünya sıralamasında ilk 100'e giren üniversite vardır : University of Melbourne (33.), Australian National University (54.), The University of Queensland (55.), Monash University (57.), University of Sydney (58.), UNSW Sydney (70.)");
            }
            else if (this.mulke == "Avusturya")
            {
                Console.WriteLine("Avusturya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Azerbaycan")
            {
                Console.WriteLine("Azerbaycan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Birleşik Krallık")
            {
                Console.WriteLine("Birleşik Krallık'ta dünya sıralamasında ilk 100'e giren üniversite vardır : University of Oxford (1.), University of Cambridge (5.), Imperial College London (12.), UCL (19.), London School of Economics and Political Science (27.), University of Edinburgh (30.), King's College London (35.), University of Manchester (50.), University of Warwick (79.), University of Glasgow (86.), University of Bristol (93.)");
            }
            else if (this.mulke == "Bahreyn")
            {
                Console.WriteLine("Bahreyn'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Bangladeş")
            {
                Console.WriteLine("Bangladeş'te dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Barbados")
            {
                Console.WriteLine("Barbados'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Belçika")
            {
                Console.WriteLine("Belçika'da dünya sıralamasında ilk 100'e giren üniversite vardır : KU Leuven (43.), Ghent University (97.)");
            }
            else if (this.mulke == "Belize")
            {
                Console.WriteLine("Belize'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Benin")
            {
                Console.WriteLine("Benin'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Belarus")
            {
                Console.WriteLine("Belarus'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Bhutan")
            {
                Console.WriteLine("Bhutan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Birleşik Arap Emirlikleri")
            {
                Console.WriteLine("Birleşik Arap Emirlikleri'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Bolivya")
            {
                Console.WriteLine("Bolivya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Bosna ve Hersek")
            {
                Console.WriteLine("Bosna ve Hersek'te dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Botsvana")
            {
                Console.WriteLine("Botsvana'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Brezilya")
            {
                Console.WriteLine("Brezilya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Brunei")
            {
                Console.WriteLine("Brunei'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Bulgaristan")
            {
                Console.WriteLine("Bulgaristan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Burkina Faso")
            {
                Console.WriteLine("Burkina Faso'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Burundi")
            {
                Console.WriteLine("Burundi'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Cezayir")
            {
                Console.WriteLine("Cezayir'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Cibuti")
            {
                Console.WriteLine("Cibuti'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Çad")
            {
                Console.WriteLine("Çad'da dünya sıralamasında ilk 300100e giren üniversite yoktur.");
            }
            else if (this.mulke == "Çek Cumhuriyeti")
            {
                Console.WriteLine("Çek Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Çin")
            {
                Console.WriteLine("Çin'de dünya sıralamasında ilk 100'e giren üniversite vardır : Peking University (16.), Tsinghua University (17.), University of Hong Kong (31.), Chinese University of Hong Kong (49.), Fudan University (60.), The Hong Kong,University of Science and Technology (66.), Zheijang University (76.), Shanghai Jiao Tong University (84.), University of Science and Technology of China (89.), Hong Kong Polytechnic University (91.)");
            }
            else if (this.mulke == "Danimarka")
            {
                Console.WriteLine("Danimarka'da dünya sıralamasında ilk 100'e giren üniversite vardır : University of Copenhagen (96.)");
            }
            else if (this.mulke == "Doğu Timor")
            {
                Console.WriteLine("Doğu Timor'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Dominik Cumhuriyeti")
            {
                Console.WriteLine("Dominik Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Dominika")
            {
                Console.WriteLine("Dominika'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ekvador")
            {
                Console.WriteLine("Ekvador'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ekvator Ginesi")
            {
                Console.WriteLine("Ekvator Ginesi'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "El Salvador")
            {
                Console.WriteLine("El Salvador'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Endonezya")
            {
                Console.WriteLine("Endonezya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Eritre")
            {
                Console.WriteLine("Eritre'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ermenistan")
            {
                Console.WriteLine("Ermenistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Estonya")
            {
                Console.WriteLine("Estonya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Etiyopya")
            {
                Console.WriteLine("Etiyopya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Estavini")
            {
                Console.WriteLine("Estavini'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Fas")
            {
                Console.WriteLine("Fas'ta dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Fiji")
            {
                Console.WriteLine("Fiji'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Fildişi Sahili")
            {
                Console.WriteLine("Fildişi Sahili'ndedünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Filipinler")
            {
                Console.WriteLine("Filipinler'dedünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Finlandiya")
            {
                Console.WriteLine("Finlandiya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Fransa")
            {
                Console.WriteLine("Fransa'da dünya sıralamasında ilk 100'e giren üniversite vardır : Paris Sciences et Lettres - PSL Research University Paris (41.), Sorbonne University (90.), Institut Polytechnique de Paris (92.)");
            }
            else if (this.mulke == "Filistin")
            {
                Console.WriteLine("Filistin'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Gabon")
            {
                Console.WriteLine("Gabon'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Gambiya")
            {
                Console.WriteLine("Gambiya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Gana")
            {
                Console.WriteLine("Gana'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Gine")
            {
                Console.WriteLine("Gine'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Gine-Bissau")
            {
                Console.WriteLine("Gine-Bissau'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Grenada")
            {
                Console.WriteLine("Grenada'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Güney Osetya")
            {
                Console.WriteLine("Güney Osetya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Guatemala")
            {
                Console.WriteLine("Guatemala'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Guyana")
            {
                Console.WriteLine("Guyana'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Güney Afrika Cumhuriyeti")
            {
                Console.WriteLine("Güney Afrika Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Güney Kore")
            {
                Console.WriteLine("Güney Kore'de dünya sıralamasında ilk 300'e giren üniversite vardır : Seoul National University (56.), Korea Advanced Institute of Science and Technology");
            }
            else if (this.mulke == "Gürcistan")
            {
                Console.WriteLine("Gürcistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Güney Sudan")
            {
                Console.WriteLine("Güney Sudan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Haiti")
            {
                Console.WriteLine("Haiti'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Hırvatistan")
            {
                Console.WriteLine("Hırvatistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Hindistan")
            {
                Console.WriteLine("Hindistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Hollanda")
            {
                Console.WriteLine("Hollanda'da dünya sıralamasında ilk 100'e giren üniversite vardır : Wageningen University & Research (53.), University of Amsterdam (65.), Utrecht University (69), Leiden University (71.), Erasmus University Rotterdam (72.), Delft University of Technology (75.), University of Groningen (80.)");
            }
            else if (this.mulke == "Honduras")
            {
                Console.WriteLine("Honduras'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Irak")
            {
                Console.WriteLine("Irak'ta dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "İran")
            {
                Console.WriteLine("İran'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "İrlanda")
            {
                Console.WriteLine("İrlanda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "İspanya")
            {
                Console.WriteLine("İspanya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "İsrail")
            {
                Console.WriteLine("İsrail'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "İsveç")
            {
                Console.WriteLine("İsveç'te dünya sıralamasında ilk 100'e giren üniversite vardır : Karolinska Institute (39.)");
            }
            else if (this.mulke == "İsviçre")
            {
                Console.WriteLine("İsviçre'de dünya sıralamasında ilk 100'e giren üniversite vardır : ETH Zurich (15.), Ecole Polytechnique Federale de Lausanne (40.), University of Zurich (77.), University of Bern (100.)");
            }
            else if (this.mulke == "İtalya")
            {
                Console.WriteLine("İtalya'da dünya sıralamasında 100 300'e giren üniversite yoktur.");
 }
            else if (this.mulke == "İzlanda")
            {
                Console.WriteLine("İzlanda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Jamaika")
            {
                Console.WriteLine("Jamaika'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Japonya")
            {
                Console.WriteLine("Japonya'da dünya sıralamasında ilk 100'e giren üniversite vardır : The University of Tokyo (36.), Kyoto University (61.)");
            }
            else if (this.mulke == "Kamboçya")
            {
                Console.WriteLine("Kamboçya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kemerun")
            {
                Console.WriteLine("Kemerun'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kanada")
            {
                Console.WriteLine("Kanada'da dünya sıralamasında ilk 100'e giren üniversite vardır : University of Toronto (18.), University of British Columbia (37.), McGill University (44.), McMaster University (81.), University of Montreal (88.)");
            }
            else if (this.mulke == "Katar")
            {
                Console.WriteLine("Katar'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kazakistan")
            {
                Console.WriteLine("Kazakistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kırgızistan")
            {
                Console.WriteLine("Kırgızistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kenya")
            {
                Console.WriteLine("Kenya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kiribati")
            {
                Console.WriteLine("Kiribati'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kolombiya")
            {
                Console.WriteLine("Kolombiya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Komorlar")
            {
                Console.WriteLine("Komorlar'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kongo")
            {
                Console.WriteLine("Kongo'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kongo Demotratik Cumhuriyeti")
            {
                Console.WriteLine("Kongo Demotratik Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kosta Rika")
            {
                Console.WriteLine("Kosta Rika'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kuveyt")
            {
                Console.WriteLine("Kuveyt'te dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kuzey Kıbrıs Türk Cumhuriyeti")
            {
                Console.WriteLine("Kuzey Kıbrıs Türk Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kuzey Kore")
            {
                Console.WriteLine("Kuzey Kore'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Küba")
            {
                Console.WriteLine("Küba'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Karadağ")
            {
                Console.WriteLine("Karadağ'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Güney Kıbrıs")
            {
                Console.WriteLine("Güney Kıbrıs'ta dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Lesotho")
            {
                Console.WriteLine("Lesotho'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Laos")
            {
                Console.WriteLine("Laos'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Letonya")
            {
                Console.WriteLine("Letonya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Liberya")
            {
                Console.WriteLine("Liberya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Libya")
            {
                Console.WriteLine("Libya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Lihtenştayn")
            {
                Console.WriteLine("Lihtenştayn'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Litvanya")
            {
                Console.WriteLine("Litvanya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Lübnan")
            {
                Console.WriteLine("Lübnan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Lüksemburg")
            {
                Console.WriteLine("Lüksemburg'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Macaristan")
            {
                Console.WriteLine("Macaristan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Madagaskar")
            {
                Console.WriteLine("Madagaskar'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Kuzey Makedonya")
            {
                Console.WriteLine("Kuzey Makedonya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Malavi")
            {
                Console.WriteLine("Malavi'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Maldivler")
            {
                Console.WriteLine("Maldivler'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Malezya")
            {
                Console.WriteLine("Malezya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Mali")
            {
                Console.WriteLine("Mali'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Malta")
            {
                Console.WriteLine("Malta'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Marshall Adaları")
            {
                Console.WriteLine("Marshall Adaları'ndan dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Mauritius")
            {
                Console.WriteLine("Mauritius'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Meksika")
            {
                Console.WriteLine("Meksika'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Mısır")
            {
                Console.WriteLine("Mısır'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Mikronezya Federal Devletleri")
            {
                Console.WriteLine("Mikronezya Federal Devletleri'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Moğolistan")
            {
                Console.WriteLine("Moğolistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Moldova")
            {
                Console.WriteLine("Moldova'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Monako")
            {
                Console.WriteLine("Monako'da dünya sıralamasında ilk 300'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Moritanya")
            {
                Console.WriteLine("Moritanya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Mozambik")
            {
                Console.WriteLine("Mozambik'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Myanmar")
            {
                Console.WriteLine("Myanmar'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Namibya")
            {
                Console.WriteLine("Namibya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Nauru")
            {
                Console.WriteLine("Nauru'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Nepal")
            {
                Console.WriteLine("Nepal'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Nijer")
            {
                Console.WriteLine("Nijer'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Nijerya")
            {
                Console.WriteLine("Nijerya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Nikaragua")
            {
                Console.WriteLine("Nikaragua'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Norveç")
            {
                Console.WriteLine("Norveç'te dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Orta Afrika Cumhuriyeti")
            {
                Console.WriteLine("Orta Afrika Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Özbekistan")
            {
                Console.WriteLine("Özbekistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Pakistan")
            {
                Console.WriteLine("Pakistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Palau")
            {
                Console.WriteLine("Palau'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Panama")
            {
                Console.WriteLine("Panama'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Papua Yeni Gine")
            {
                Console.WriteLine("Papua Yeni Gine'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Paraguay")
            {
                Console.WriteLine("Paraguay'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Peru")
            {
                Console.WriteLine("Peru'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Polonya")
            {
                Console.WriteLine("Polonya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Portekiz")
            {
                Console.WriteLine("Portekiz'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Romanya")
            {
                Console.WriteLine("Romanya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ruanda")
            {
                Console.WriteLine("Ruanda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Rusya")
            {
                Console.WriteLine("Rusya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sahra Demokratik Arap Cumhuriyeti")
            {
                Console.WriteLine("Sahra Demokratik Arap Cumhuriyeti'nde dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Samoa")
            {
                Console.WriteLine("Samoa'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sao Tome ve Principe")
            {
                Console.WriteLine("Sao Tome ve Principe'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "San Marino")
            {
                Console.WriteLine("San Marino'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Senegal")
            {
                Console.WriteLine("Senegal'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Seyşeller")
            {
                Console.WriteLine("Seyşeller'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sierra Leone")
            {
                Console.WriteLine("Sierra Leone'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sırbistan")
            {
                Console.WriteLine("Sırbistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Singapur")
            {
                Console.WriteLine("Singapur'da dünya sıralamasında ilk 100'e giren üniversite vardır : National University of Singapore (21.), Nanyang Technological University,Singapore (46.)");
            }
            else if (this.mulke == "Slovakya")
            {
                Console.WriteLine("Slovakya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Slovenya")
            {
                Console.WriteLine("Slovenya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Solomon")
            {
                Console.WriteLine("Solomon'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Somali")
            {
                Console.WriteLine("Somali'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Somaliland")
            {
                Console.WriteLine("Somaliland'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sri Lanka")
            {
                Console.WriteLine("Sri Lanka'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "St. Kitts ve Nevis")
            {
                Console.WriteLine("St. Kitts ve Nevis'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "St. Lucia")
            {
                Console.WriteLine("St. Lucia'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "St. Vincent ve Grenadinler")
            {
                Console.WriteLine("St. Vincent ve Grenadinler'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Sudan")
            {
                Console.WriteLine("Sudan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Surinam")
            {
                Console.WriteLine("Surinam'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Suriye")
            {
                Console.WriteLine("Suriye'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Suudi Arabistan")
            {
                Console.WriteLine("Suudi Arabistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Şili")
            {
                Console.WriteLine("Şili'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tacikistan")
            {
                Console.WriteLine("Tacikistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tanzanya")
            {
                Console.WriteLine("Tanzanya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tayland")
            {
                Console.WriteLine("Tayland'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tayvan")
            {
                Console.WriteLine("Tayvan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Togo")
            {
                Console.WriteLine("Togo'da  dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tonga")
            {
                Console.WriteLine("Tonga'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Trinidad ve Tobago")
            {
                Console.WriteLine("Trinidad ve Tobago'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tunus")
            {
                Console.WriteLine("Tunus'ta dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Transdinyester")
            {
                Console.WriteLine("Transdinyester'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Tuvalu")
            {
                Console.WriteLine("Tuvalu'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Türkmenistan")
            {
                Console.WriteLine("Türkmenistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Türkiye")
            {
                Console.WriteLine("Türkiye'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Umman")
            {
                Console.WriteLine("Umman'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Uganda")
            {
                Console.WriteLine("Uganda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ukrayna")
            {
                Console.WriteLine("Ukrayna'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Uruguay")
            {
                Console.WriteLine("Uruguay'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Ürdün")
            {
                Console.WriteLine("Ürdün'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Vanuatu")
            {
                Console.WriteLine("Vanuatu'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Venezuela")
            {
                Console.WriteLine("Venezuela'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Vietnam")
            {
                Console.WriteLine("Vietnam'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Vatikan")
            {
                Console.WriteLine("Vatikan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Yemen")
            {
                Console.WriteLine("Yemen'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Yeşil Burun Adaları")
            {
                Console.WriteLine("Yeşil Burun Adaları'nda dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Yeni Zelanda")
            {
                Console.WriteLine("Yeni Zelanda'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Yunanistan")
            {
                Console.WriteLine("Yunanistan'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Zambiya")
            {
                Console.WriteLine("Zambiya'da dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }
            else if (this.mulke == "Zimbabve")
            {
                Console.WriteLine("Zimbabve'de dünya sıralamasında ilk 100'e giren üniversite yoktur.");
            }



        }
}
}
