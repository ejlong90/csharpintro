// See https://aka.ms/new-console-template for more information\

//int Age = 32;

//Console.WriteLine("hello everyone!");

//Console.WriteLine("please enter your name");

//string name = Console.ReadLine();
//Console.WriteLine("hello " + name);

//Console.WriteLine("What is your middle name?");

//string middleName = Console.ReadLine();

//Console.WriteLine("what is your last name?");

//string lastName = Console.ReadLine();
//Console.WriteLine("Hello " + name + " " + middleName + " " + lastName + ", you are " + Age);

string ratePerHour = "What do you make per hour?";
string numberOfHoursWorked = "How many hours did you work this month?";
string name = "What is your name";

Console.WriteLine(name);
string employeeName = Console.ReadLine();

Console.WriteLine(ratePerHour);
Double rate = Convert.ToDouble(Console.ReadLine()); // save user input to variable
rate += 3; // rate = rate + 3

Console.WriteLine(employeeName + ", your new hourly rate is " + rate);


Console.WriteLine(numberOfHoursWorked);
Double hours = Convert.ToDouble(Console.ReadLine()); // save user input to variable

Double monthlyWage = rate * hours;
Console.WriteLine(monthlyWage);











