using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_for_Bank_Account
{
    class Bank 
    {
        string name;
        string acc_number;
        double balance;
        public Bank()               //in case of invalid entry
        {
            name = "XXXX";
            acc_number = "Invalid User";
            balance=0.00;
        }
        public Bank(string x,string y, double z)                    //Non default constructor to assign starting values
        {
            name = x;
            acc_number = y;
            balance = z;
        }
        public void display() 
        {
            Console.WriteLine("Name:{0}\nAccount Number:{1}\nBalance:{2}\n",name,acc_number,balance);
        }
        public void deposit(double x) 
        {
            balance = balance + x;
        }
        public void withdrawal(double x)
        {
            balance = balance - x;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bank John = new Bank("John","21341312",12213.32);
            Bank invalid = new Bank();
            John.display();
            Console.WriteLine(" ");
            John.deposit(300000);
            John.display();
            John.withdrawal(42222);
            John.display();
            Console.WriteLine("For the invalid User: ");
            invalid.display();
            Console.ReadKey();
        }
    }
}
