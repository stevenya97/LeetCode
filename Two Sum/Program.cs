// See https://aka.ms/new-console-template for more information
using TwoSum;
int[] arr = { 1, 2, 3, 4, 5 };
var solver = new CalcTwoSum();
var solution = solver.Calc(arr, 3);
Console.WriteLine(solution);

Console.WriteLine("Press any key...");
Console.ReadKey();