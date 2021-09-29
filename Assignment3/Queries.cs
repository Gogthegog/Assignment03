using System.Linq;
using System;
using System.Collections.Generic;
namespace BDSA2021.Assignment03
{
    public class Queries
    {
        /* Exercise 1 - Wizards invented by Rowling. Only return the names.
        
        Using LINQ*/
        public static IEnumerable<string> byRowling()
        {
            var ByRowling = from w in Wizard.Wizards.Value
                            where w.Creator.Contains("Rowling")
                            select w.Name;

            return ByRowling;
        }
        

        // Using Extentions
        public static IEnumerable<string> byRowlingSorted()
        {
            var ByRowlingSorted = Wizard.Wizards.Value.Where(w => w.Creator.Contains("Rowling"))
                                    .Select(w => w.Name);
            return ByRowlingSorted;
        }
        
        

        /* Exercise 2 - The year the first sith lord ( Darth something ) was introduced. 
        
        Using LINQ */
        public static IEnumerable<int?> firstDarth()
        {
            var FirstDarth = (from w in Wizard.Wizards.Value
                        where w.Name.Contains("Darth")
                        orderby w.Year
                        select w.Year).Take(1);
            return FirstDarth;
        }
        

        // Using Extentions
        public static IEnumerable<int?> firstDarthSorted(){
            var FirstDarthSorted = Wizard.Wizards.Value.Where(w => w.Name.Contains("Darth"))
                                .OrderBy(w => w.Year)
                                .Select(w => w.Year)
                                .Take(1);
            return FirstDarthSorted;
        }
        
        
        

        /* Exercise 3 Unique list of wizards from the Harry Potter books - return name and year
        
         Using LINQ */
        public static IEnumerable<(string, int?)> HarryPotter()
        {
            var HarryPotter = from w in Wizard.Wizards.Value
                    where w.Medium.Contains("Harry Potter")
                    select ( w.Name, w.Year );
            return HarryPotter;
        }
        

         // Using Extentions
        public static IEnumerable<(string, int?)> HarryPotterSorted(){
            var HarryPotterSorted = Wizard.Wizards.Value.Where(w => w.Medium.Contains("Harry Potter"))
                                .Select(w => (w.Name, w.Year));
            return HarryPotterSorted;
        }
    
        // Exercise 4 List of wizard names grouped by creator 

        //Using Linq
        public static IEnumerable<(string, string)> SortedWizards() 
        {
            var sortedWizards = from w in Wizard.Wizards.Value
                            orderby w.Creator descending, w.Name descending
                            select (w.Creator.ToString(), w.Name.ToString());
                            
            return sortedWizards;
        }
        

        //Using Extension
        public static IEnumerable<(string,string)> WizardsReverse()
        {
            var wizards = Wizard.Wizards.Value
                        .OrderByDescending(w => w.Creator)
                        .ThenByDescending(w => w.Name)
                        .Select(w => (w.Creator, w.Name));
            return wizards;
        }
    }   
}
