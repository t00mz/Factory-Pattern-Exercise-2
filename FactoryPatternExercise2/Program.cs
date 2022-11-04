using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Lastly in the Main()
            //Ask the user what database they want to use: a List, SQL, or Mongo
            //Store their response in a variable
            //Call your factory method and pass in what the user types
            //
            //
            //and store what your factory method returns in an IDataAccess variable
            //Call the LoadData and SaveData methods of the IDataAccess variable
            //Run the program a few times using the different types.

            Console.WriteLine("Do you want to use list, sql, or mongo database?");
            var userInput = Console.ReadLine();  // var userInput = Console.ReadLine().ToLower()
                                                 // but would store the response, in lower case, 
                                                 // to the variable, if it's done in the IF ELSE or
                                                 // the switch statement it wouldnt modify value stored
                                                 // in variable

            var userInputData = DataAccessFactory.GetDataAccessType(userInput);

            var products = userInputData.LoadData();
            userInputData.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
            }



        }
    }
}
