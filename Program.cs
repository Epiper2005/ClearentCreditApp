using System;

namespace CreditApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                gatherInfo();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void gatherInfo()
        {
            try
            {
                string name;
                int numberOfWallets;
                int numberofCards;
                string card1;
                double balance1;
                double interest1;
                string card2;
                double balance2;
                double interest2;
                string card3;
                double balance3;
                double interest3;
                string card4;
                double balance4;
                double interest4;
                string card5;
                double balance5;
                double interest5;
                string card6;
                double balance6;
                double interest6;
                double totalInterest1;
                double totalInterest2;

                Console.WriteLine("Enter Customer Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Number of Wallets: ");
                numberOfWallets = Convert.ToInt32(Console.ReadLine());
                switch (numberOfWallets)
                {
                    case 1:
                        Console.WriteLine("How many cards are in this wallet? ");
                        numberofCards = Convert.ToInt32(Console.ReadLine());
                        if (numberofCards == 1)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            totalInterest1 = interest1;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nTotal Interest for wallet: " + totalInterest1);
                        }
                        else if (numberofCards == 2)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card2 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card2 + " card balance: ");
                            balance2 = Convert.ToDouble(Console.ReadLine());
                            interest2 = calculateInterest(card2, balance2);
                            totalInterest1 = interest1 + interest2;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nCard 2: " + card2 + " Balance: " + balance2 + " Interest: " + interest2 + "\nTotal Interest for wallet: " + totalInterest1);
                        }
                        else if (numberofCards == 3)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card2 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card2 + " card balance: ");
                            balance2 = Convert.ToDouble(Console.ReadLine());
                            interest2 = calculateInterest(card2, balance2);
                            Console.WriteLine("Please enter the type for the third card (ex. Visa, MC, Discover): ");
                            card3 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card3 + " card balance: ");
                            balance3 = Convert.ToDouble(Console.ReadLine());
                            interest3 = calculateInterest(card3, balance3);
                            totalInterest1 = interest1 + interest2 + interest3;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nCard 2: " + card2 + " Balance: " + balance2 + " Interest: " + interest2 + "\nCard 3: " + card3 + " Balance: " + balance3 + " Interest: " + interest3 +
                                "\nTotal Interest for wallet: " + totalInterest1);
                        }
                        else
                        {
                            Console.WriteLine("Card amount cannot be less than 1 or more than 3.");
                        };
                        break;
                    case 2:
                        Console.WriteLine("How many cards are in the first wallet? ");
                        numberofCards = Convert.ToInt32(Console.ReadLine());
                        if (numberofCards == 1)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            totalInterest1 = interest1;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nTotal Interest for wallet 1: " + totalInterest1);
                        }
                        else if (numberofCards == 2)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card2 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card2 + " card balance: ");
                            balance2 = Convert.ToDouble(Console.ReadLine());
                            interest2 = calculateInterest(card2, balance2);
                            totalInterest1 = interest1 + interest2;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nCard 2: " + card2 + " Balance: " + balance2 + " Interest: " + interest2 + "\nTotal Interest for wallet 1: " + totalInterest1);
                        }
                        else if (numberofCards == 3)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card1 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card1 + " card balance: ");
                            balance1 = Convert.ToDouble(Console.ReadLine());
                            interest1 = calculateInterest(card1, balance1);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card2 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card2 + " card balance: ");
                            balance2 = Convert.ToDouble(Console.ReadLine());
                            interest2 = calculateInterest(card2, balance2);
                            Console.WriteLine("Please enter the type for the third card (ex. Visa, MC, Discover): ");
                            card3 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card3 + " card balance: ");
                            balance3 = Convert.ToDouble(Console.ReadLine());
                            interest3 = calculateInterest(card3, balance3);
                            totalInterest1 = interest1 + interest2 + interest3;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card1 + " Balance: " + balance1 + " Interest: " + interest1 +
                                "\nCard 2: " + card2 + " Balance: " + balance2 + " Interest: " + interest2 + "\nCard 3: " + card3 + " Balance: " + balance3 + " Interest: " + interest3 +
                                "\nTotal Interest for wallet 1: " + totalInterest1);
                        }
                        Console.WriteLine("How many cards are in the second wallet? ");
                        numberofCards = Convert.ToInt32(Console.ReadLine());
                        if (numberofCards == 1)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card4 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card4 + " card balance: ");
                            balance4 = Convert.ToDouble(Console.ReadLine());
                            interest4 = calculateInterest(card4, balance4);
                            totalInterest2 = interest4;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card4 + " Balance: " + balance4 + " Interest: " + interest4 +
                                "\nTotal Interest for wallet 2: " + totalInterest2);
                        }
                        else if (numberofCards == 2)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card4 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card4 + " card balance: ");
                            balance4 = Convert.ToDouble(Console.ReadLine());
                            interest4 = calculateInterest(card4, balance4);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card5 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card5 + " card balance: ");
                            balance5 = Convert.ToDouble(Console.ReadLine());
                            interest5 = calculateInterest(card5, balance5);
                            totalInterest2 = interest4 + interest5;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card4 + " Balance: " + balance4 + " Interest: " + interest4 +
                                "\nCard 2: " + card5 + " Balance: " + balance5 + " Interest: " + interest5 + "\nTotal Interest for wallet 2: " + totalInterest2);
                        }
                        else if (numberofCards == 3)
                        {
                            Console.WriteLine("Please enter the type for the first card: (ex. Visa, MC, Discover): ");
                            card4 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card4 + " card balance: ");
                            balance4 = Convert.ToDouble(Console.ReadLine());
                            interest4 = calculateInterest(card4, balance4);
                            Console.WriteLine("Please enter the type for the second card (ex. Visa, MC, Discover): ");
                            card5 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card5 + " card balance: ");
                            balance5 = Convert.ToDouble(Console.ReadLine());
                            interest5 = calculateInterest(card5, balance5);
                            Console.WriteLine("Please enter the type for the third card (ex. Visa, MC, Discover): ");
                            card6 = Console.ReadLine();
                            Console.WriteLine("Please enter the " + card6 + " card balance: ");
                            balance6 = Convert.ToDouble(Console.ReadLine());
                            interest6 = calculateInterest(card6, balance6);
                            totalInterest2 = interest4 + interest5 + interest6;
                            Console.WriteLine("Name: " + name + "\nNumber of Wallets: " + numberOfWallets + "\nCard 1: " + card4 + " Balance: " + balance4 + " Interest: " + interest4 +
                                "\nCard 2: " + card5 + " Balance: " + balance5 + " Interest: " + interest5 + "\nCard 3: " + card6 + " Balance: " + balance6 + " Interest: " + interest6 +
                                "\nTotal Interest for wallet 2: " + totalInterest2);
                        }
                        else
                        {
                            Console.WriteLine("Card amount cannot be less than 1 or more than 3.");
                        };
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        public static double calculateInterest(string cardType, double balance)
        {
            try
            {
                double visaInterest;
                double mcInterest;
                double discoverInterest;

                switch (cardType)
                {
                    case "Visa":
                        visaInterest = balance * .1;
                        return visaInterest;
                    case "MasterCard":
                    case "MC":
                        mcInterest = balance * .05;
                        return mcInterest;
                    case "Discover":
                        discoverInterest = balance * .01;
                        return discoverInterest;
                    default:
                        Console.WriteLine("Not matching card found");
                        break;
                }
                return 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }
    }
}
