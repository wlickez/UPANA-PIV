List<int> enteros = new() { 5, 3, 8, 4, 6 , 10 , 1, 20,15, 100, 1000, 99, 89};

for (int i = 0; i < enteros.Count; i++)
{
    for (int j = 0; j < enteros.Count - 1; j++)
    {
        if (enteros[j] > enteros[j + 1])
        {
            int temp = enteros[j];
            enteros[j] = enteros[j + 1];
            enteros[j + 1] = temp;
            Console.WriteLine(string.Join(',', enteros));
        }
    }
}
