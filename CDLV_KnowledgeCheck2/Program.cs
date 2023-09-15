
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using CDLV_KnowledgeCheck2;


Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Cat>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var cat = new Cat();

    Console.WriteLine("Please enter a name: ");
    cat.Name = Console.ReadLine();

    Console.WriteLine("Please enter the age: ");
    cat.Age = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the weight in pounds: ");
    cat.Weight = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Please enter fur color: ");
    cat.FurColor = Console.ReadLine();


    recordList.Add(cat);
}

// Print out the list of records using Console.WriteLine()
foreach (Cat cat in recordList)
{
    Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}, Weight: {cat.Weight}, Fur Color: {cat.FurColor}");
}


