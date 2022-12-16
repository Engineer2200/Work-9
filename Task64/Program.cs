void ShowNaturalNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNaturalNumbers(number - 1); 
}
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(n);
