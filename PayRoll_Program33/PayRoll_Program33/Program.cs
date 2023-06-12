using System;

namespace PayRoll_Program33
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello Day-33 Program Address Payroll Program\n");

            AdoDotNet ado = new AdoDotNet();
            ado.CreateDatabase();

        }
    }
}