// See https://aka.ms/new-console-template for more information
Console.WriteLine("******************************************");

var time = 8;
var day = 12;
var month = 5;
var year = 2021;

if (time < 0 || time > 24)
{ Console.WriteLine("Please check the time!"); }

if (time < 12 && time >= 0)
{ Console.WriteLine("Good Morning Sunshine!"); }
if (time > 13 && time < 19)
{ Console.WriteLine("Good Afternoon. Work Hard!"); }
if (time > 20 && time < 24)
{ Console.WriteLine("Good Evening. Get some rest!"); }

if ((month == 4 || month == 6 || month == 9 || month == 11) && (day < 1 || day > 30))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day < 1 || day > 31))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if (month == 2 && (day < 1 || day > 28) && (year % 4 != 0))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if (month == 2 && (day < 1 || day > 29) && (year % 4 == 0))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if (month < 1 || month > 12)
{ Console.WriteLine("Please check the month - it's not correct!"); }

if (year < 0)
{ Console.WriteLine("Please check the year - it's not correct!"); }}

Console.WriteLine($"{year}/{month}/{day}");

Console.WriteLine("******************************************");
Console.WriteLine("Please write the day!");
string dayString = Console.ReadLine();
Console.WriteLine("Please write the month!");
string monthString = Console.ReadLine();
Console.WriteLine("Please write the year!");
string yearString = Console.ReadLine();

day = Convert.ToInt32(dayString);
month = Convert.ToInt32(monthString);
year = Convert.ToInt32(yearString);

Console.WriteLine($"Please select date format: press '1' for YYYY/MM/DD  or press '2' for DD.MM.YYYY");
string format = Console.ReadLine();

Console.WriteLine("***********************************************************");
if ((month == 4 || month == 6 || month == 9 || month == 11) && (day < 1 || day > 30))
{ Console.WriteLine("Please check the date - it's not correct!"); }

if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day < 1 || day > 31))
{ Console.WriteLine("Please check the date - it's not correct!"); }

if (month == 2 && (day < 1 || day > 28) && (year % 4 != 0))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if (month == 2 && (day < 1 || day > 29) && (year % 4 == 0))
{ Console.WriteLine("Please check the day - it's not correct!"); }

if (month < 1 || month > 12)
{ Console.WriteLine("Please check the month - it's not correct!"); }

if (year < 0)
{ Console.WriteLine("Please check the year - it's not correct!"); }


if (format == "1")
{ Console.WriteLine($"Your date is {year}/{month}/{day}"); }
else if (format == "2")
{ Console.WriteLine($"Your date is {day}.{month}.{year}"); }

Console.WriteLine("***********************************************************");
