using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25

        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            List<string> thWords = words.FindAll(x => x.Contains("th"));
            return thWords;

        }
        #endregion


        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            List<string> noDuplicates = names.Distinct().ToList();
            return noDuplicates;

        }
        #endregion
        


        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            Customer mike = customers.FirstOrDefault(x => x.FirstName == "Mike");
            return mike;

        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            Customer customer = (from x in customers where x.Id == 3 select x).First();
            customer.FirstName = ("New First Name");
            customer.LastName = ("New Last Name");
            return customer;

        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            List<double> finalAvg = new List<double>();
            for (int i = 0; i < classGrades.Count; i++)
            {
                string[] splitStrings = (classGrades[i].Split(','));
                List<string> splitResult = splitStrings.ToList();
                List<double> convertedString = splitResult.ConvertAll(x => double.Parse(x));
                double min = convertedString.Find(x => x == convertedString.Min());
                convertedString.Remove(min);
                double avg = convertedString.Average();
                finalAvg.Add(avg);
            }

            double result = finalAvg.Average();
            return result;
            
        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            char[] newWord = word.ToCharArray();
            Array.Sort(newWord);
            List<string> newWordAsList = new List<string>();
            foreach (char item in newWord)
            {
                string y = item.ToString();
                newWordAsList.Add(y);
                
            }
            int occurrence = 0;
            List<string> finalList = new List<string>();
            for (int i = 0; i < newWordAsList.Count; i++)
            {

                string x = newWordAsList[i];

                if (x != newWordAsList[i + 1])
                {

                    occurrence++;
                    finalList.Add(x);

                    
                }
                else if  (x == newWordAsList[i - 1] && x != newWordAsList[i + 1])
                {
                    occurrence++;
                    string numString = occurrence.ToString();
                    finalList.Add(numString);
                }
                
            }
            
            
           
            string finalProduct = finalList.ToString();
            return finalProduct;
            



        }
        #endregion
    }
}
