//int amount = 1234;
//int months = 12;

//Console.WriteLine(CalculateYearlyWage(amount, months));

//Console.ReadLine();

//static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
//{
//    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
//    return monthlyWage * numberOfMonthsWorked;
//}



int numInt = 500;

// get type of numInt
Type n = numInt.GetType();

// Implicit Conversion
double numDouble = numInt;

// get type of numDouble
Type n1 = numDouble.GetType();

// Value before conversion
Console.WriteLine("numInt value: " + numInt);
Console.WriteLine("numInt Type: " + n);

// Value after conversion
Console.WriteLine("numDouble value: " + numDouble);
Console.WriteLine("numDouble Type: " + n1);
Console.ReadLine();
