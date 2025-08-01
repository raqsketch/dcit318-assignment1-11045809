       using System;

       class TicketPriceCalculator
       {
           static void Main()
           {
               Console.Write("Enter your age: ");
               int age = int.Parse(Console.ReadLine() ?? "0");
               int ticketPrice = (age >= 65 || age <= 12) ? 7 : 10;

               Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
           }
       }
       
