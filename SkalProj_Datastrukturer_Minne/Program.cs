using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {


        /// 
        static void Main()
        {
            //Capacity only grows when count exceed previous max capacity. As long as the count grows within the capacity 
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, it asks the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some sort of input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            Console.WriteLine("Welcome");
            string NewWord = "_";
            List<string> namelist = new List<string>();
           

            while (true)
            {
                char choice = ' ';
                
                try
                {
                    string word = Console.ReadLine();
                    char y; /// Checks for each letter in a string, for a if switch.
                   
                    
                        for (int i = 0; i < word.Length; i++)
                    {
                        y = word[i];
                        if (y == '+')
                        {
                           
                            choice = '+';

                           NewWord = word.TrimStart(choice);
                           namelist.Add ( NewWord);
                        }
                        y = word[i];
                        if (y == '-')
                        {
                            choice = '-';
                            NewWord = word.TrimStart(choice);

                            namelist.Remove(NewWord);
                            //The capacity does not lower if count is reduced. 

                        }
                        
                        else
                        {

                        }
                    
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (choice)
                {
                    case '+':
                     
                        Console.WriteLine(NewWord);
                        Console.WriteLine(namelist.Capacity);
                        Console.WriteLine(namelist.Count);
                        Console.WriteLine(namelist[0]);
                        break;
                    case '-':

                        
                     
                        if (namelist.Count <= 0)  
                        {
                            
                            Console.WriteLine("The list is empty!");
                          


                        }

                        else
                        {
                            Console.WriteLine(NewWord);
                            Console.WriteLine(namelist.Capacity);
                            Console.WriteLine(namelist.Count);
                            Console.WriteLine(namelist[0]);


                        }
                     break;

                    case 'E':
                      
                        break;

                    case '0':

                        Environment.Exit(0);

                        break;
                    default:

                        break;
                }
            }


        }

    
        static void ExamineQueue()
        {
              
            while (true) {
                bool res; 
                int choice;
                Console.WriteLine("Type 1 to Add to the Que. 2 to remove someone from the que");
                res = int.TryParse(Console.ReadLine(), out choice);
              
                Queue<string> customers = new Queue<string>();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the name of a customer");
                        var newCustomer = Console.ReadLine();
                        Console.WriteLine();

                        if (newCustomer == null)
                        {
                            Console.WriteLine("error");
                            
                        }
                        else { 
                        customers.Enqueue(newCustomer); 
                        Console.WriteLine(customers.Count);
                            foreach (string item in customers)
                        {

                            Console.WriteLine(item);


                        }
                      
                        }

                        break;
                    case 2:

                    
                        if (customers.Count>0)
                        {
                            customers.Dequeue();

                            Console.WriteLine(customers.Count);
                        }
                        else if (customers.Count <= 0)
                        {
                            Console.WriteLine("Que is empty");
                        }

                        foreach (string item in customers)
                        {
                            Console.WriteLine(item);


                        }
                        break;
                   
                    case 0:

                        Environment.Exit(0);

                        break;
                    default:

                        break;
                }

            

               
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {   
            // Att använda Stack funkar inte då stack hela tiden lägger uppepå den tidigare och prioritiserar sedan den senaste ditlagda.
            // I en kö innebär det den som står först i kön blir stilla ståande och kön inte rör sig frammåt.

            
               
            try
            {
                Console.WriteLine("Type a word in");
                string normalWord = Console.ReadLine();
                

                char[] letters = normalWord.ToCharArray();
                Stack<char> letterassembly = new Stack<char>();
                
                for (int i = 0; i < letters.Length; i++)
                {
                    letterassembly.Push(letters[i]);

                }
                foreach (var item in letterassembly)
                {
                    Console.Write(item);
              
                
                }

                Console.WriteLine("");
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException) //If the input line is empty, it asks the users for some input.
            {

                Console.Clear();
                Console.WriteLine("Please enter some sort of input!");
            }


           



            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            try
            {

                Console.WriteLine("Type a word in");
                string check = Console.ReadLine();

                Stack<char> StackingCheck = new Stack<char>();
                    foreach (var c in check)
                    {
                        switch (c)
                        {
                            case ')':
                                if (StackingCheck.Count == 0 || StackingCheck.Pop() != '(') Console.WriteLine("Fail");
                            break;
                            case ']':
                                if (StackingCheck.Count == 0 || StackingCheck.Pop() != '[') Console.WriteLine("Fail");
                            break;
                            case '}':
                                if (StackingCheck.Count == 0 || StackingCheck.Pop() != '{') Console.WriteLine("Fail");
                            break;
                            case '(': StackingCheck.Push(c); break;
                            case '[': StackingCheck.Push(c); break;
                            case '{': StackingCheck.Push(c); break;
                        }
                    }
                if (StackingCheck.Count == 0) { Console.WriteLine("Success"); }
                else {  }



            }
            catch (IndexOutOfRangeException) //If the input line is empty, it asks the users for some input.
            {

                Console.Clear();
                Console.WriteLine("Please enter some sort of input!");
            }



        }

    }
}

