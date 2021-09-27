using System.Linq;
using System;
namespace BDSA2021.Assignment03
{
    public class Queries
    {
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

        /* Exercise 2 - The year the first sith lord ( Darth something ) was introduced. 
        
        // Using LINQ
        var FirstDarth = (from w in Wizard
                        where w.Name.Contains("Darth")
                        orderby c.Year
                        select new { Name = w.Name, Year = w.Year }).Take(1);
        FirstDarth.Print()

        // Using Extentions
        var FirstDarthSorted = Wizard.Where(w => w.Name.Contains("Darth"))
                                    .orderby(w => w.Year)
                                    .Select(w => new { Name = w.Name, Year = w.Year })
                                    .Take(1);
        FirstDarthSorted.Print();
        */
        

        /* Exercise 3 Unique list of wizards from the Harry Potter books - return name and year
        
        // Using LINQ 
        var HarryPotter = from w in Wizard
                        where w.Medium.Contains("Harry Potter")
                        select new { Name = w.Name, Year = w.Year } 
        HarryPotter.Print();

         // Using Extentions
        var HarryPotterSorted = Wizard.Where(w => w.Medium.Contains("Harry Potter"))
                                    .Select(w => new { Name = w.Name, Year = w.Year });
        HarryPotterSorted.Print();
        */

        // Exercise 4 List of wizard names grouped by creator 
        // Print in reverse order: creator name and then wizard name.

        // Using lINQ
        var sortedWizards = from w in Wizard
                            group w by w.Creator into h
                            select new { Creator = h.Key, Wizard = w.name };
        sortedWizards.Print();

        // Using Extension
    }   
}
