Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0){
    Console.Write("Yes");
}
else 
    Console.Write("no");
