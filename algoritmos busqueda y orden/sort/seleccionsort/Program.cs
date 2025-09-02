internal class Program
{
    private static void Main(string[] args)
    {
        List<int> disOrderNumbers = new() { 4, 2, 1, 3, 20, 5, 6, 7, 8, 55, 0 };
        List<int> orderNumbers = new();

        Func<int, int> order = x => x;

        disOrderNumbers.OrderByDescending(order);

        int iteraciones = 0;
        bool flag = true;

        while (flag == true)
        {
            Console.WriteLine(string.Concat("Antes   Nuevo    => ", string.Join(",", orderNumbers)));
            Console.WriteLine(string.Concat("Antes   Original => ", string.Join(",", disOrderNumbers)));

            int minusNumber = -1;
            int currentValue = -1;
            flag = false;
            for (int i = 0; i < disOrderNumbers.Count; i++)
            {
                flag = true;
                currentValue = disOrderNumbers[i];
                //minusNumber = currentValue;

                if (i == 0)
                {
                    minusNumber = currentValue;
                    continue;
                }
                else
                {
                    if (currentValue < minusNumber)
                        minusNumber = currentValue;
                }
                iteraciones++;
            }

            disOrderNumbers.Remove(minusNumber);
            orderNumbers.Add(minusNumber);

            if (disOrderNumbers.Count == 0)
                flag = false;

            Console.WriteLine(string.Concat("Despues   Original => ", string.Join(",", disOrderNumbers)));
            Console.WriteLine(string.Concat("Despues   Nuevo    => ", string.Join(",", orderNumbers)));
        }
        
        Console.WriteLine("Iteraciones " + iteraciones.ToString());
    }
}