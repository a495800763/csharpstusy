using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinqDemo
{
    public class DistinctDemo
    {
        public static void Main(string[] args)
        {
            IEnumerable<object> queryResults = MultiOrderByResult();
            foreach (var item in queryResults)
            {
                WriteLine(item);
            }

            Write("Program finished.press Enter/Return to continue.");
            ReadLine();
        }

        private static IEnumerable<string> DistinctResult()
        {
            List<Customer> customers = GetCustomers();
            var queryResults = customers.Select(q => q.Region).Distinct();
            return queryResults;
        }

        private static IEnumerable<object> MultiOrderByResult()
        {
            List<Customer> customers = GetCustomers();
            //var reslt = customers.Select(q => new { q.ID, q.Region, q.Country, q.City }).OrderBy(q => q.City).OrderBy(q => q.Country).OrderBy(q => q.Region);
            var reslt =
                from c in customers
                orderby c.Region, c.Country, c.City
                select new { c.ID, c.Region, c.Country, c.City };

            return reslt;
        }

        private static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer> {
                new Customer{ ID="A",City="New York",Country="USA",Region="North America",Sales=9999},
                new Customer{ ID="B",City="Munbai",Country="India",Region="Asia",Sales=8888},
                new Customer{ ID="C",City="Karachi",Country="Pakistan",Region="Asia",Sales=777},
                new Customer{ ID="D",City="Delhi",Country="India",Region="Asia",Sales=6666},
                new Customer{ ID="E",City="Sao Paulo",Country="Brazil",Region="South America",Sales=5555},
                new Customer{ ID="F",City="Moscow",Country="Russia",Region="Europe",Sales=4444},
                new Customer{ ID="G",City="Seoul",Country="Korea",Region="Asia",Sales=3333},
                new Customer{ ID="H",City="Istanbul",Country="Turkey",Region="Asia",Sales=2222},
                new Customer{ ID="I",City="Shanghai",Country="China",Region="Asia",Sales=1111},
                new Customer{ ID="J",City="Lagos",Country="Nigeria",Region="Africa",Sales=1000},
            };
            return customers;
        }
    }

    class Customer
    {
        public string ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public decimal Sales { get; set; }

        public override string ToString()
        {
            return "ID:" + ID + " City:" + City +
                " Country:" + Country +
                " Region:" + Region +
                " Sales:" + Sales;
        }
    }
}
