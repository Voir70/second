Console.WriteLine("Write number 1");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Write number 2");
int number_2 = int.Parse(Console.ReadLine());
if (number*number==number_2 || number_2*number_2==number)
{
    Console.Write("Yes");
}
else 
{
    Console.Write("No");
}
