using Classes_WIth_Arrays;

Console.WriteLine("Enter the number of MaxIndex of the array");
Console.WriteLine("Needed so you can input the values for the array");
bool StopInputing=false;
string pause;
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n && !StopInputing; i++)
{
    Console.WriteLine($"Enter the value for the index: {i} of the array:");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Continue? enter anything then press enter");
pause  = Console.ReadLine();
Console.Clear();
Console.WriteLine("Original array: ");
Class1.PrintArr(arr);
Console.WriteLine("");
Console.WriteLine("Sum of array: " + Class1.SumArr(arr));
Console.WriteLine("Average of array: " + Class1.AvgArr(arr));
Console.WriteLine("Multiplication of array: " + Class1.MulArr(arr));
Console.WriteLine("Max Index: " + Class1.IndexMax(arr));
Console.WriteLine("Min Value: " + Class1.GetMin(arr));
Console.WriteLine("Is Ascending Order: " + Class1.IsAscendingOrder(arr));
Console.WriteLine("Contains number 2: " + Class1.ContainsNumber(arr, 2));
Console.WriteLine("Sum Appearance Counter: " + Class1.SumAppearanceCounter(arr, 2));
Console.WriteLine("");
Console.WriteLine("Odd to even array: ");
Class1.Odd2EvenArr(arr);
Class1.PrintArr(arr);
Console.WriteLine("");
Console.WriteLine("Divisible by 3: ");
Class1.DivNumArr(arr, 3);