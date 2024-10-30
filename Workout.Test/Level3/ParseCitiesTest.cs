using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level3
{
    [TestClass]
    public class ParseCitiesTest
    {
        Func<string, List<City>>[] parseCitiesMethods;

        public class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
        }

        public ParseCitiesTest()
        {
            throw new NotImplementedException();
        }

        public void parsecities_should_return_one_city_when_just_one_city_is_supplied(string onecity)
        {
            throw new NotImplementedException();
        }

        public void parsecities_should_give_empty_list_if_just_white_spaces_is_supplied(string input)
        {
            throw new NotImplementedException();
        }

        public List<City> ParseCities(string input)
        {
            throw new NotImplementedException();
        }

        public List<City> ParseCities_Linq(string input)
        {
            throw new NotImplementedException();
        }

    }
}
