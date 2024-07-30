// IDataAccess.cs

using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        List<Product> LoadData();
        void SaveData();
    }
}



