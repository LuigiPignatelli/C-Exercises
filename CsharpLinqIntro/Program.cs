using System;
using System.Linq;

namespace CsharpLinqIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ = Language Integrated Query
            // syntax: 1. lambda, 2. query

            // LAMBDA SYNTAX
            // initialize array of Hobbies
            Hobbies[] myHobbies =
            {
                new Hobbies(1, "Walking"),
                new Hobbies(2, "Reading"),
                new Hobbies(3, "Programming")
            };

            // LAMBDA SYNTAX
            // "h" is an alias and represents the current element inside of the Array, like a for each
            // in myHobbies, grab any element that satisfies this condition h.Name.Equals("Programming")
            var hobbie = myHobbies.Where(h => h.Name.Equals("Programming"));
            var someHobbies = myHobbies.Where(h => h.Id > 1);
            // this returns a list

            // get elements that satisfies the Where condition and then once you have a list of element, make another list that only grabs the names     
            var nameHobbies = myHobbies.Where(h => h.Id > 1).Select(h => h.Name);


            // QUERY SYNTAX
            var AllHobbies = from h in myHobbies where h.Name == "Programming" select h;
            // from h in collection -> get the alias from the collection
            // where -> filter the collection that satisfies the condition
            // select -> once we have the result, grab the whole thing (we can also grab also a property h.Name)


            // USE SKIP
            var allHobbiesButOne = myHobbies.Skip(2); // how many items do you want to skip? the first items

            // USE TAKE
            var takeMyHobby = myHobbies.Take(1); // how many elements do you want to take? only the first
        }
    }

    internal class Hobbies
    {
        // PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }

        public Hobbies(int argId, string argName)
        {
            Id = argId;
            Name = argName;
        }
    }
}