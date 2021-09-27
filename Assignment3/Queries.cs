using System.Linq;
using System;
namespace BDSA2021.Assignment03
{
    public class Queries
    {
        Repository repo = new Repository();
        // public IReadOnlyCollection<Wizard> ByRowling<Wizard>(){
        //     var wizards = Wizard.Wizards.Value.AsEnumerable;
        //     return wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => new {Name = w.Name});
        // }


        /* Exercise 1 - Wizards invented by Rowling. Only return the names.
        // Using LINQ
        var ByRowling = from w in Wizard
                        where w.Name.Contains("Rowling")
                        select new { Name = w.Name };

        ByRowling.Print();

        // Using Extentions
        var ByRowlingSorted = Wizard.Where(w => w.Name.Contains("Rowling"))
                                    .Select(w => new { Name = w.Name });
        ByRowlingSorted.Print();
        */

        // Exercise 2 - The year the first sith lord ( Darth something ) was introduced. 
    }   
}
