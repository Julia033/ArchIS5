using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Controllers
{
    class ViewController
    {
        private DatabaseController DB = new DatabaseController();
        public void PrintHouseCity()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите номер участника");
            Guid? CityID = new Guid();
            List<Models.House> houses = DB.SelectAll();
            int ind = 0;
            foreach (Models.House house in houses)
            {
                Console.WriteLine();
                Console.WriteLine(ind + " " + house.Name);
                Console.WriteLine();
                ind++;
            }
            Console.WriteLine();
            string ch = Console.ReadLine();
            Console.WriteLine();

            try
            {
                ind = int.Parse(ch);
                try
                {
                    CityID = houses[ind].CityID;
                    List<Models.House> house = DB.House(CityID);
                    foreach (Models.House house1 in house)
                    {
                        Console.WriteLine();
                        Console.WriteLine(house1.Id + " " + house1.Name);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
        }
        public void PrintCity()
        {
            foreach (Models.City city in DB.SelectAllCity())
            {
                Console.WriteLine();
                Console.WriteLine(city.Name);
                Console.WriteLine();
            }
        }
        public void PrintHouse()
        {
            foreach (Models.House house in DB.SelectAll())
            {
                Console.WriteLine();
                Console.WriteLine(house.Name);
                Console.WriteLine(house.Start);
                Console.WriteLine(house.End) ;
                Console.WriteLine();
            }
        }
    }
}
