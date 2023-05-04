using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public enum Continent
    {
        North_America,
        South_America,
        Asia,
        Africa,
        Europe,
        Antarctica,
        Oceania
    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; } = new List<string>(); 

        public Country(string name, Continent continent, string colors) 
        { 
            this.Name = name;
            this.Continent = continent;
            this.Colors = colors;
            
        }

    }

}
