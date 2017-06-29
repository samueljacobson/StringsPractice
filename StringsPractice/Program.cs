using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Sam";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this  line \t I want a new line without WriteLine \n Hi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("User 2 is a copycat");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original");
            //}
            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User 2 is a copycat");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original");
            //}
            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Pierre.";
            //string fullSentence = startOfSentence + endOfSentence;

            //Console.WriteLine(startOfSentence + endOfSentence);
            //Console.WriteLine(fullSentence);

            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);
            //Console.WriteLine("The first part of my sentence was {0}, the second was {1}, and the third was {2}", startOfSentence, endOfSentence, fullSentence);

            //Console.WriteLine("This is a tab. \t\nThis is a backslash \\.\nAnd this is a bell sound \a.");

            //string firstName = "Sam";
            //string lastName = "Jacobson";

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Length of first name: " + firstName.Length);
            //Console.WriteLine("Length of last name: " + lastName.Length);

            //int firstNameLength = firstName.Length;
            //int lastNameLength = lastName.Length;

            //if (firstNameLength > lastNameLength)
            //{
            //    Console.WriteLine("First is longer.");
            //}
            //else if (firstNameLength == lastNameLength)
            //{
            //    Console.WriteLine("Samsies");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}
            string fName = "George";
            string fName2 = "George";

            if (fName.Equals(fName2))
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }


        }
    }
}
