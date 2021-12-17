using System;

class Program
{
    static void Main()
    {
        // Q1 
        string name, number;
        int price;

        number = int.Parse(Console.ReadLine());
        name = Console.ReadLine();
        if (number > 8)
        {
            price = number*30 - 20;
        }
        else
        {
            price = number*30;
        }

        Console.WriteLine(name + price);


        // Q2
        string name;
        char code;
        
        name = Console.ReadLine();
        code = char.Parse(Console.ReadLine());

        Console.WriteLine(name);
        if (code == '1')
        {
            Console.WriteLine("Code 1: Pays 50 shekels");
            onsole.WriteLine("SPECIAL PRICE");
        }
        else if (code == '2')
        {
            Console.WriteLine("Code 2: Pays 30 shekels");
        }

        // Q3
        string name;
        int number, total, price;

        number = int.Parse(Console.ReadLine());
        name = Console.ReadLine();

        if (number >= 100)
        {
            price = 45;
        }
        else
        {
            price = 50;
        }

        total = number * price;
        Console.WriteLine("Name of participant: " + name + " Price for 1 person: " + price + " Total price is: " + total);

        // Q4
        string name;
        int numSmall, numBig, price;

        name = Console.ReadLine();
        numSmall = int.Parse(Console.ReadLine());
        numBig = int.Parse(Console.ReadLine());

        price = numSmall*30 + numBig*45;
        Console.WriteLine("Family name is: " + name + " Price is: " + price);
    }
}