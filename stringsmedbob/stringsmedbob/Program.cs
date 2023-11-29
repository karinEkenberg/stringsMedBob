
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsmedbob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Mitt \"så kallade\" liv"; // använd \ före " för att kunna använda citattecken inuti en mening i c#
            string myString2 = "När jag vill ha en ny rad\nså fungerar detta"; // \n för en ny rad
            string myString3 = "Gå till c:\\ drive"; //genom att använda dubbla \ eller 
            string myString4 = @"Använd ett snabela framför citattecknet :\ drive";

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.ReadLine();
        }
    }
}
