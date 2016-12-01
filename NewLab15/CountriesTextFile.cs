using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab15
{
    public class CountriesTextFile
    {
        private string countries;
        private List<CountriesTextFile> CountryList = new List<CountriesTextFile>();

        public string Countries
        {
            get
            {
                return countries;
            }

            set
            {
                countries = value;
            }
        }



        public static List<CountriesTextFile> ReadFile()
        {
            List<string> CountryList = new List<string>();

            string fileLocation = "../../countries.txt";

            StreamReader reader = new StreamReader(fileLocation);

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');


            foreach (string record in CountryList)
            {
                Console.WriteLine(record);

            }
            reader.Close();
           return CountryList;
        }


        public static void write(List<string> CountryList)
        {
            StreamWriter writeCountry = new StreamWriter("../../countries.txt", true);
            foreach (string record in CountryList)
            {
                writeCountry.WriteLine(record);
            }
            writeCountry.Close();

        }

        //Add to the countries
        public static List<string> addTOListCountry(string country, List<string> CountryList)
        {
            CountryList.Add(country);
            return CountryList;
        }

        //Displays the countries
        public static void showCounty(List<string> CountryList)
        {
            foreach (string record in CountryList)
            {
                Console.WriteLine(record);
            }
        }



        internal static void WriteString(string userCountries)
        {
            throw new NotImplementedException();
        }
    }
}

    
