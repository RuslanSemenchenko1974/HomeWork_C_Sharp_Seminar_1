Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int countNamber = 1;
while (countNamber<number)
{
    countNamber++;
    if (countNamber%2==0)
    Console.Write($" {countNamber}");
}
