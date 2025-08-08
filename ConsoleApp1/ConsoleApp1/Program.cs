// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics;

Console.WriteLine("--- Welcome to the Simple Form Letter Generator ---\r\nPlease provide the following information to create your letter:\r\n--------------------------------------------------");
string name1;
string name2;
string subject;
string discuss;
string date;
Console.WriteLine("What is the recipients full name?");
name1 = Console.ReadLine();
Console.WriteLine("What is the senders full name?");
name2 = Console.ReadLine();
Console.WriteLine("What is the subject of the letter?");
subject = Console.ReadLine();
Console.WriteLine("What is the specific project or task you are discussing?");
discuss = Console.ReadLine();
Console.WriteLine("When will this need to be completed or followed up on?");
date = Console.ReadLine();
Console.WriteLine("--------------------------------------------------\r\nGenerating your letter...\r\n");
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine($"\r\nTo: {name1}\r\n");
Console.WriteLine($"Dear {name1}\r\n,");
Console.WriteLine($"Subject:{subject}");
Console.WriteLine($"\r\nI am writing to you today regarding the {discuss} that we discussed.\r\nI wanted to provide a quick update on its progress.");
Console.WriteLine($"\r\nWe anticipate completing the initial phase by {date}.\r\nPlease let me know if you have any questions or require further information.");
Console.WriteLine($"\r\nSincerely,\r\n\r\n{name2}\r\n\r\n--------------------------------------------------\r\nLetter generated successfully. Press any key to exit.");