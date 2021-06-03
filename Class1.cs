using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public class Payment
    {
        #region PAYMENT METHOD
        public bool Pay(string pay1)
        {
            if (pay1 == "yes" || pay1 == "y" || pay1 == "YES")
            {
                Console.WriteLine("payment success");
                return true;
            }
            else if (pay1 == "NO" || pay1 == "no" || pay1 == "n")
            {

                Console.WriteLine("******You may exit the console******");
                return false;
            }
            else
            {
                Console.WriteLine("Please type the required parameter");
                string pay2 = Console.ReadLine();
                return this.Pay(pay2);
            }

        }
        #endregion
    }
    public class Operation : Payment
    {

        public enum operation { Buy = 1, Sell = 2, Rent = 3 }
        public void Op()
        {

            Console.WriteLine("====Enter your preference: =======");
            Console.WriteLine(" 1. BUY  2. SELL  3. RENT ");
            int op1 = Convert.ToInt32(Console.ReadLine());

            switch (op1)
            {
                #region BUY OPTION
                case 1:

                    Console.WriteLine("=====Enter Your Location: ======");
                    Console.WriteLine(" * 1.Chennai  * 2. Mumbai * 3. Hyderbad");
                    int op2 = Convert.ToInt32(Console.ReadLine());
                    if (op2 == 1)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: 3050, 6th avenue,13th main road,shanthi Colony, Anna nagar,Chennai-600040  ");
                        Console.WriteLine("Contact: Harsita - 123456789");
                        Console.WriteLine("** Ready To Buy? **");
                        Console.WriteLine("PLEASE STATE ---- YES , NO");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);
                        /* bool payment.pay(string pay1)*/
                        ;

                    }
                    else if (op2 == 2)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: Dno 16-2-3/D , Ambani Colony, Mumbai, Maharashtra - 420001 ");
                        Console.WriteLine("Contact: Mansi Rathi - 123456789");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);

                    }
                    else if (op2 == 3)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: Dno 25-7-15 , Ameerpet , Hyderbad, Telangana - 620001 ");
                        Console.WriteLine("Contact: Arjun - 123456789");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);

                    }
                    break;
                #endregion
                #region SELL OPTION
                case 2:
                    Console.Write("Enter locality:");
                    string loc = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter Contact Info:");
                    string info = Console.ReadLine();
                    Console.WriteLine("==== THESE ARE YOUR DETAILS ===" + loc + address + info);
                    break;
                #endregion
                #region RENT OPTION
                case 3:

                    Console.WriteLine("=====Enter Your Location: ======");
                    Console.WriteLine(" * 1.Chennai * 2. Mumbai * 3. Hyderbad");
                    int op3 = Convert.ToInt32(Console.ReadLine());
                    // bool pay;
                    if (op3 == 1)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: 3050, 6th avenue,13th main road,shanthi Colony, Anna nagar,Chennai-600040  ");
                        Console.WriteLine("Contact: Harsita - 123456789");
                        Console.WriteLine("** Ready To Move-in? **");
                        Console.WriteLine("PLEASE STATE ---- YES , NO");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);

                    }
                    else if (op3 == 2)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: Dno 16-2-3/D , Ambani Colony, Mumbai, Maharashtra - 420001 ");
                        Console.WriteLine("Contact: Mansi Rathi - 123456789");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);

                    }
                    else if (op3 == 3)
                    {
                        Console.WriteLine("Details : 3BHK - Fully furnished.");
                        Console.WriteLine("Address: Dno 25-7-15 , Ameerpet , Hyderbad, Telangana - 620001 ");
                        Console.WriteLine("Contact: Arjun - 123456789");
                        string pay1 = Console.ReadLine();
                        bool temp = this.Pay(pay1);

                    }
                    break;
                    #endregion
            }
        }
    }
}