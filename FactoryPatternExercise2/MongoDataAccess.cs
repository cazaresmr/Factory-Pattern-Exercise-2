using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo database.");
            return new List<Product> { new Product { Name = "MongoProduct1", Price = 50.0 }, new Product { Name = "MongoProduct2", Price = 60.0 } };
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}


