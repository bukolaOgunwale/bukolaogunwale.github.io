using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int yourChoice;          // declared variable to accept the choice of planet
            double yourWeight;       //declared variable to accept the weight  
            double ans;              // variable that accepts the result of the calculated weight on the choosen planet
            int yourChoosen;
            double ChoosenWeight;
            do
                {
                    Console.WriteLine("            Menu of Planets            "); // this display the menu choice of planets available
                    Console.WriteLine("          ======== == =======          ");
                    Console.WriteLine("1. Jupiter    2. Mars    3. Mercury    ");
                    Console.WriteLine("4. Neptune    5. Pluto   6. Saturn     ");
                    Console.WriteLine("7. Uranus     8. Venus   9. <Quit>     ");
                    Console.WriteLine("                                       ");

                    do
                    {
                        Console.Write("Enter your menu choice:");                   // This request for the choice of planet
                        string inputChoice = Console.ReadLine();
                                                
                        if (int.TryParse(inputChoice, out yourChoosen) == true)    //checks if its true the strings can be converted to integer

                        {
                            yourChoice = Convert.ToInt16(inputChoice);            //convert the menu choice of the user into integer
                            if (yourChoice == 9)
                             {
                            Console.WriteLine("Have a Nice Day");                //ends program with have a nice day
                            Environment.Exit(0);
                             }
                                            
                        }
                    else
                       {
                        Console.Write("Enter your menu choice: ");          //if the choice cannot be converted to interger then another value is requested
                        yourChoice = int.Parse(Console.ReadLine());        //it reads the inputted value and stores it as an integer
                        
                       }

                   } while (yourChoice < 1 || yourChoice > 9);                //loops the menu choosen until the condition of choice is between 1 to 9 is met
                  do                                                         // loops begins
                   {
                        Console.Write("Enter your weight on Earth:");        // requests for weight on earth from the user 
                        string inputWeight = Console.ReadLine();             //reads the inputted value as a string

                        if (double.TryParse(inputWeight, out ChoosenWeight) == true)  //tries to check if the conversion of the weight into double data types s possible

                        {
                            yourWeight = Convert.ToDouble(inputWeight);             //converts the weight to double

                        }
                        else 

                        {
                            Console.Write("Enter your weight on Earth: ");          //a new weight is requested for 
                            yourWeight = double.Parse(Console.ReadLine());          //weight on earth is coverted to double

                        }


                     } while (yourWeight < 1);                                    //checks for the inputted weight is not negative
                   
                                switch (yourChoice)
                                {
                                    case 1:
                                        ans = Math.Round((yourWeight * 2.64), 1);       // calculates the weight of another planet
                                         Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Jupiter ", yourWeight, ans);
                                        break;
                                    case 2:                                  
                                        ans = Math.Round((yourWeight * 0.38), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Mars ", yourWeight, ans);
                                        break;
                                    case 3:                                    
                                        ans = Math.Round((yourWeight * 0.37), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Mercury ", yourWeight, ans);
                                        break;
                                    case 4:
                                         ans = Math.Round((yourWeight * 1.12), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Neptune ", yourWeight, ans);
                                        break;
                                    case 5:                                   
                                        ans = Math.Round((yourWeight * 0.04), 1); 
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Pluto ", yourWeight, ans);
                                        break;
                                    case 6:                                   
                                        ans = Math.Round((yourWeight * 1.15), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Saturn ", yourWeight, ans);
                                        break;
                                    case 7:                                   
                                        ans = Math.Round((yourWeight * 1.15), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Uranus ", yourWeight, ans);
                                        break;
                                    case 8:                                    
                                        ans = Math.Round((yourWeight * 0.88), 1);
                                        Console.WriteLine("Your weight of {0} pounds on Earth would be {1} pounds on Venus ", yourWeight, ans);
                                        break;
                                }                   
                                   
            } while (yourChoice != 9);                          //checks if the user doesn't input 9     

        }
    }
}


