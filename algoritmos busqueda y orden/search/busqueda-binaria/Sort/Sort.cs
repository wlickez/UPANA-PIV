namespace Models
{
    public class Sort
    {
        public void Show(int[] numbers, bool todos = false)
        {
            Console.WriteLine();
            if (todos)
            {
                Console.Write(string.Join(',', numbers));
                return;
            }
            foreach (var number in numbers)
            {
                Console.Write(number + ",");

            }

            Console.WriteLine("\n");
        }

        public int[] BubbleSort(int[] numeros)
        {

            Show(numeros, true);

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {

                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;

                    }
                    Show(numeros);

                }
            }
            Show(numeros, true);
            return numeros;

        }

        public int[] InsertionSort(int[] arreglo)
        {

            for (int i = 1; i < arreglo.Length; i++)
            {
                int actual = arreglo[i];
                int j = i - 1;

                // Mover elementos mayores hacia la derecha
                while (j >= 0 && arreglo[j] > actual)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                    Show(arreglo);
                }

                // Insertar el elemento en su posición correcta
                arreglo[j + 1] = actual;
            }
            Show(arreglo, true);
            return arreglo;

        }
        public int[] SelectionSort(int[] numeros)
        {

            if (numeros.Length <= 1)
                return numeros;

            Show(numeros, true);

            for (int i = 1; i < numeros.Length; i++)
            {

                if (numeros[i] < numeros[i - 1])
                {

                    int valorInsertar = numeros[i];
                    int indiceStop = i;

                    while (indiceStop > 0)
                    {
                        int temp2 = numeros[indiceStop];
                        int temp1 = numeros[indiceStop - 1];

                        if (temp2 < temp1)
                        {
                            numeros[indiceStop - 1] = temp2;
                            numeros[indiceStop] = temp1;
                        }
                        indiceStop--;

                        Show(numeros);
                    }

                }


            }

            Show(numeros, true);


            return numeros;
        }

        public int[] MergeSort(int[] arreglo)
        {
            if (arreglo.Length == 1)
                return arreglo;

            int medio = Convert.ToInt32(Math.Floor(Convert.ToDouble(arreglo.Length) / 2));

            int[] leftArray = arreglo.Take(medio).ToArray();
            int[] rightArray = arreglo.Skip(medio).Take(arreglo.Length - medio).ToArray();

            int[] sortedLeft = MergeSort(leftArray);
            int[] sortedRight = MergeSort(rightArray);

            return Merge(leftArray.ToList(), rightArray.ToList());
        }

        int[] Merge(List<int> leftArray, List<int> rightArray)
        {
            List<int> totalArray = new List<int>();


            while (leftArray.Count > 0 && rightArray.Count > 0)
            {
                if (leftArray[0] > rightArray[0])
                {
                    totalArray.Add(rightArray[0]);
                    rightArray.Remove(rightArray[0]);
                }
                else
                {
                    totalArray.Add(leftArray[0]);
                    leftArray.Remove(leftArray[0]);
                }

            }

            while (leftArray.Count > 0)
            {
                totalArray.Add(leftArray[0]);
                leftArray.Remove(leftArray[0]);

            }

            while (rightArray.Count > 0)
            {
                totalArray.Add(rightArray[0]);
                rightArray.Remove(rightArray[0]);


            }

            return totalArray.ToArray();
        }

    }
}