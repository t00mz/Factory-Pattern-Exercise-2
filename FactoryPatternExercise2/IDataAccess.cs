using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        //In one solution, you will need to create some new types.
        //A class called Product with 2 properties, Name and Price
        //An interface called IDataAccess with 2 methods, LoadData() and SaveData()
        //3 classes that implement the interface and its members(the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
        //Last you will need to create a class called DataAccessFactory


        public void SaveData();
        public List<Product> LoadData();
       


    }
}
