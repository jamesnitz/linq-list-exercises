﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linqlists
{
  public class Customer
  {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }
  class Program
  {
    static void Main(string[] args)
    {
      //       // Find the words in the collection that start with the letter 'L'
      //       List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

      //       IEnumerable<string> LFruits = from fruit in fruits
      //                                     where fruit.StartsWith("L")
      //                                     select fruit;

      //       foreach (var fruit in LFruits)
      //       {
      //         Console.WriteLine($"{fruit}");
      //       }
      //       Console.WriteLine($"-----------");

      //       // Which of the following numbers are multiples of 4 or 6
      //       List<int> numbers = new List<int>()
      //     {
      //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      //     };
      //       IEnumerable<int> fourSixMultiples = numbers.Where(number =>
      //       {
      //         return number % 4 == 0 || number % 6 == 0;
      //       });
      //       foreach (var number in fourSixMultiples)
      //       {
      //         Console.WriteLine($"{number}");
      //       }
      //       Console.WriteLine($"----------------");

      //       // Order these student names alphabetically, in descending order (Z to A)
      //       List<string> names = new List<string>()
      // {
      //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
      //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
      //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
      //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
      //     "Francisco", "Tre"
      // };

      //       List<string> descend = names.OrderByDescending(name => name).ToList();
      //       foreach (var name in descend)
      //       {
      //         Console.WriteLine($"{name}");
      //       }
      // Build a collection of these numbers sorted in ascending order
      //       List<int> numbers = new List<int>()
      // {
      //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      // };
      //       var ascendingNumbers = numbers.OrderBy(x => x).ToList();
      //       foreach (var num in ascendingNumbers)
      //       {
      //         Console.WriteLine($"{num}");
      //       }

      // Output how many numbers are in this list
      //       List<int> numbers = new List<int>()
      // {
      //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      // };

      //       var numberCount = numbers.Count;
      //       Console.WriteLine($"{numberCount}");

      // How much money have we made?
      //       List<double> purchases = new List<double>()
      // {
      //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
      // };

      //       var totalPurchase = purchases.Sum();
      //       Console.WriteLine($"{totalPurchase}");


      // What is our most expensive product?
      //       List<double> prices = new List<double>()
      // {
      //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
      // };

      //       var mostPricey = prices.Max();
      //       Console.WriteLine($"{mostPricey}");

      //       List<int> wheresSquaredo = new List<int>()
      // {
      //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
      // };
      //       var squareNum = wheresSquaredo.TakeWhile(number =>
      //       {
      //         return number % Math.Sqrt(number) != 0;
      //       });

      //       foreach (var num in squareNum)
      //       {
      //         Console.Write($"{num} ");
      //       }
      List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
      var millionaireCustomers = customers.Where(customers => customers.Balance >= 1000000);

      var milionaireGroups = millionaireCustomers
        .GroupBy(customer => customer.Bank)
        .Select(Group =>
        {
          return new BankReport
          {
            millionaireCount = Group.Count(),
            bankName = Group.Key
          };
        });

      foreach (var millionaire in milionaireGroups)
      {
        Console.WriteLine($"{millionaire.bankName} {millionaire.millionaireCount}");
      }
    }
    public class BankReport
    {
      public int millionaireCount { get; set; }
      public string bankName { get; set; }
    }
  }

}
