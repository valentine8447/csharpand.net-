﻿#region Usings

#endregion

#region MainMethod

const string myName = "valentine";
const string niceName = "andrea";
const string sillyName = "ploppy";
string name;
Console.WriteLine("What is your name?");
name = Console.ReadLine();
switch (name.ToLower())
{
    case myName:
        Console.WriteLine("You have the same name as me!");
        break;
        case niceName:
        Console.WriteLine("My, what a nice name you have!");
        break;
        case sillyName:
        Console.WriteLine("Thats a very silly name!");
        break ;

}

Console.WriteLine($"Hello { name}!");
    Console.ReadKey();


#endregion