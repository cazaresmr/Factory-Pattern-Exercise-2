using System;
using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List.");
            return new List<Product> { new Product { Name = "ListProduct1", Price = 10.0 }, new Product { Name = "ListProduct2", Price = 20.0 } };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List.");
        }
    }
}


