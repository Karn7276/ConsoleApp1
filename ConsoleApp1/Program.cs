// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Me!");
string name = "5 3 1 2 4 0 1 4";
string[] numbers = name.Split(' ');
Console.WriteLine("The numbers are: ");
var arranum = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    arranum[i] = int.Parse(numbers[i]);
}
Array.Sort(arranum);
Console.WriteLine(Convert.ToString(arranum.Last()) +" "+ Convert.ToString(arranum.First()));
