// Покажите кубы чисел, заканчивающихся на чётную цифру.

bool result = true;
string messageIn = String.Empty;
double number = 0;

while (number <= 0)
{
    Console.WriteLine("Введите число > 0: ");
    messageIn = Console.ReadLine();
    result = double.TryParse(messageIn, out number);
}
Console.WriteLine($"Кубы чисел заканчивающиеся на четную цифру {number}");
for(double i = 1; i <= number; i++)
{
    double j = Math.Pow(i,3);
    double resultOst = j % 10;

    if(resultOst % 2 == 0 && resultOst != 0)
    Console.Write($"{j}");
}