using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> newWords = LinqProblems.RunProblem1(words);

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> noDuplicates = LinqProblems.RunProblem2(names);

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>();

            Customer Mike = new Customer(1, "Mike", "Rodgers");
            Customer Nick = new Customer(2, "Nick", "Allen");
            Customer Jason = new Customer(3, "Jason", "Ryan");
            Customer Dan = new Customer(4, "Dan", "Laffey");
            customers.Add(Mike);
            customers.Add(Nick);
            customers.Add(Jason);
            customers.Add(Dan);


            Customer mike = LinqProblems.RunProblem3(customers);
            Customer newGuy = LinqProblems.RunProblem4(customers);


            //Problem 5
            List<string> classGrades = new List<string>();

            classGrades.Add("80,100,92,89,65");
            classGrades.Add("93,81,78,84,69");
            classGrades.Add("73,88,83,99,64");
            classGrades.Add("98,100,66,74,55");

            double avg = LinqProblems.RunProblem5(classGrades);
            


            //--------------------
            //Bonus Problem 1
            string letters = "terrill";
            string newString = LinqProblems.RunBonusProblem1(letters);
            Console.WriteLine(newString);
            Console.ReadLine();


        }
           
                
            

           




    }



}
