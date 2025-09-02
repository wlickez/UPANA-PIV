int[] numbers = [10, 2, 3, 4, 5, 1, 9, 8, 7, 6];

Console.WriteLine("Inicio");

bool flag = true;
for (int i = 0; i < numbers.Length && flag; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        flag = false;
        if (numbers[j] > numbers[j + 1])
        {
            int aux = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = aux;
            flag = true;
        }
        Show();
    }
}

void Show()
{
    foreach (var number in numbers)
    {
        Console.Write(number  + ",");

    }

    Console.WriteLine("\n");
}