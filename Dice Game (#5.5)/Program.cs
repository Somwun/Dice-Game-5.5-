using More_Classes___5._5_;
using System;

namespace Dice_Game___5._5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;
            string bet = "0", userInput = "help";
            int result = 0, value1, value2;
            Die die1 = new Die(), die2 = new Die();
            double money = 100;
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                if (!(isNumber = bet.All(char.IsDigit)) || userInput != "help" & userInput != "double" & userInput != "doubles" & userInput != "single" & userInput != "singles" & userInput != "even" & userInput != "evens" & userInput != "odd" & userInput != "odds" & userInput != "exit")
                {
                    Console.WriteLine("Invalid Input");
                    bet = "0";
                }
                Console.WriteLine("Welcome to the definately not shady casino in the alley");
                Console.WriteLine("Rules of the game are simple.\nI roll two dice and you bet on the outcome, whether you think they'll be doubles, singles, even, or odd");
                Console.WriteLine("If you need help, just type Help\nAnd if you'd like to leave, just type Exit");
                userInput = Console.ReadLine().ToLower().Trim();
                if (userInput == "help")
                {
                    Console.Clear();
                    Console.WriteLine("Here's the gist, I'll roll two dice, and there are 4 options for you to pick as to what you think they'll be\n1. Doubles\n  Pick this if you think both of the dice will be the same number\n  If you win this I'll give you back double your bet\n\n2. Singles\n  Pick this if you think both of the dice will be different numbers\n  If you win this I'll give you back half of your bet\n\n3. Even\n  Pick this if you think their sum will be even\n  If you win this I'll give you back your bet\n\n4. Odd\n  Pick this if you think their sum will be odd\n  If you win this I'll give you back your bet\n\nIn order to choose simply type your choice\nSo what do you want to bet on? (Type Exit if you'd like to leave)");
                    userInput = Console.ReadLine().ToLower();
                }
                else if (userInput == "exit")
                    repeat = false;
                else if (userInput == "double" || userInput == "doubles")
                {
                    Console.Clear();
                    Console.WriteLine("How much do you want to bet on that?");
                    bet = Console.ReadLine().Trim();
                    if (isNumber = bet.All(char.IsDigit))
                    {
                        Console.Clear();
                        die1.RollDie();
                        die2.RollDie();
                        if (die1.CurrentRoll == die2.CurrentRoll)
                        {
                            money += Convert.ToDouble(bet);
                            Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            money -= Convert.ToDouble(bet);
                            Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                            Console.ReadLine();
                        }
                    }
                    else
                        Console.Clear();
                }
                else if (userInput == "single" || userInput == "singles")
                {
                    Console.Clear();
                    Console.WriteLine("How much do you want to bet on that?");
                    bet = Console.ReadLine().Trim();
                    if (isNumber = bet.All(char.IsDigit))
                    {
                        Console.Clear();
                        die1.RollDie();
                        die2.RollDie();
                        if (die1.CurrentRoll != die2.CurrentRoll)
                        {
                            money += Convert.ToDouble(bet);
                            Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            money -= Convert.ToDouble(bet);
                            Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                            Console.ReadLine();
                        }
                    }
                }
                else if (userInput == "odd" || userInput == "odds")
                {
                    Console.Clear();
                    Console.WriteLine("How much do you want to bet on that?");
                    bet = Console.ReadLine().Trim();
                    if (isNumber = bet.All(char.IsDigit))
                    {
                        Console.Clear();
                        die1.RollDie();
                        die2.RollDie();
                        if ((die1.CurrentRoll + die2.CurrentRoll / 2) % 1 == 0)
                        {
                            money += Convert.ToDouble(bet);
                            Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            money -= Convert.ToDouble(bet);
                            Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                            Console.ReadLine();
                        }
                    }
                }
                else if (userInput == "even" || userInput == "evens")
                {
                    Console.Clear();
                    Console.WriteLine("How much do you want to bet on that?");
                    bet = Console.ReadLine().Trim();
                    if (isNumber = bet.All(char.IsDigit))
                    {
                        Console.Clear();
                        die1.RollDie();
                        die2.RollDie();
                        if ((die1.CurrentRoll + die2.CurrentRoll / 2) % 1 != 0)
                        {
                            money += Convert.ToDouble(bet);
                            Console.WriteLine($"Congrats you won, you now have {money.ToString("C")}\nPress enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            money -= Convert.ToDouble(bet);
                            Console.WriteLine($"Well we can't all be winners, you know have {money.ToString("C")} left\nPress enter to continue");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}