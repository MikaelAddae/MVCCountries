using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDB { get; set; } = new List<Country>();
        

        public CountryController() 
        {
            CountryDB.Add(new Country("USA", Continent.North_America, "Red, White, Blue"));
        }

        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);
            Console.WriteLine("Hello, please select a country from the following list, by index");
            clv.Display();
            int pick = int.Parse(Console.ReadLine());
            CountryAction(CountryDB[pick]);
            //loop


        }

    }
}
