/*
 Author : Yue Xu
 Date   : 1/29/2019
 Comment: 1. As the user to enter their name
          2. Write a method that prints to the Console: "Hello users name!".
          Here's an example of the User Input and Output:
          INPUT: Clinton Daniel
          OUTPUT: Hello Clinton Daniel!
          Once you complete this program, upload it to GitHub.
          Then, past in your GitHub Link to GitHub here.
*/

using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name. ");

            
            try
            {
                // This variable will gather data from user input
                string Input = Console.ReadLine();

                // call method Recommend_Name
                string get_your_name = Recommend_Name(Input);

                Console.ReadKey(true);

            

            }//End of try

            catch
            {
                Console.WriteLine("Please use the correctm name format");
                Console.WriteLine("Press any key to exit the program and try again....");
                Console.ReadKey(true);
            }// End of catch

 
        }//End of main

         //static = can not dupulicate 
         //ing = going out with int value
         //Recommne_xxx= int(get _age) = come in and you got a new name get_age

        private static string Recommend_Name(string get_name)
        {
            string name_you_entered = get_name;
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + get_name + " !");
            Console.WriteLine(" ");
            Console.WriteLine("__________________________________________________________________");

            return name_you_entered;

        }// End of Recommend_Name
    }//End of class

}//End of namespace
