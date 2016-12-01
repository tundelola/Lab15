using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab15
{
    class CountriesApp
    {
       

        static void Main(string[] args)
        {
            CountriesApp country = new CountriesApp();
            Console.WriteLine("Welcome to the Countries Maintainance Application!");
            Console.WriteLine("These are list of Countries you can choose from");
            Console.WriteLine("Choose Option 1 to read a list of Countries");
            Console.WriteLine("Choose Option 2 to write a list of Countries");
            Console.WriteLine("Choose Option 3 to Exit");
            
            while (true)
            {
                Console.WriteLine("Enter your option");
                int inputOption = int.Parse(Console.ReadLine());
                country.userOption(inputOption);
                
            }

            Console.WriteLine("Do you want to enter another option? (y/n)");// validates more input sentence from the user
            string userRes = Console.ReadLine();
            if (userRes == "Y" || userRes == "y")
            {
                return;

            }
            else
            {
                Console.WriteLine("Thanks and Good bye....");
            }
           

        }

        public void userOption(int inputOption)
        {
         
            switch (inputOption)
            {
                case 1:
                    CountriesTextFile.ReadFile();
                    break;

                case 2:

                    Console.WriteLine("Add a county");

                    string userCountries = Console.ReadLine();

                    CountriesTextFile.WriteString(userCountries);

                    break;

                default:

                    Console.WriteLine("Thanks and Good Bye!");

                    break;
            }

            
        }
    }

}



    
    

