using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInts = new List<int>
            {
                3,5,4,7,22,8,5,1
            };

            var listOfStrings = new List<string>
            {
                "Ala",
                "Ma",
                "Dużego",
                "Fiuta",
                "",
                "Kośmiński"
            };


            var listOfUsers = new List<User>
            {
                new User
                {
                    FirstName = "Papryk",
                    LastName = "Korzeń",
                    Email = "paprykkorzen@gmail.com"
                },

                new User
                {
                    FirstName = "Michał",
                    LastName = "Korzenny",
                    Email = "michalkorzenny@gmail.com"
                },
                new User
                {
                    FirstName = "Mateusz",
                    Email = "mateuszoko@gmail.com"
                },
                null
            };

            var list1 = listOfInts.Select(x => x + 2).ToList();                  // skrót
            
            listOfInts.Select(x => {return x + 2;});        // robi to samo co wyżej


            // Func<int, int> power = (a) => { return a * a; };
            // Action functionLambda2 = () => { Console.WriteLine("Hi"); };

            // functionLambda2();
            // functionLambda2.Invoke();       // to samo co wywołanie powyżej
            // Console.WriteLine(power(6));
        }
    }
}
