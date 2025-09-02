using Models;

internal class Program
{
    private static void Main(string[] args)
    {



        //Array.Sort(numeros, 0, numeros.Length);


        Sort sort = new();

        Console.WriteLine("Bubble");
        int[] numeros1 = { 7, 6, 5, 17, 3, 18, 11 };
        sort.BubbleSort(numeros1);

        // Console.WriteLine("Insertion");
        // int[] numeros2 = { 7, 6, 5, 17, 3, 18, 11 };
        // sort.InsertionSort(numeros2);


        // Console.WriteLine("Selection");
        // int[] numeros3 = { 7, 6, 5, 17, 3, 18, 11 };
        // sort.SelectionSort(numeros3);

        //Console.WriteLine("Merge");
        //int[] numeros4 = { 7, 6, 5, 17, 3, 18, 11 };
        //var merge = sort.MergeSort(numeros4);
        //sort.Show(merge, true);


        // foreach (var n in numeros)
        // {
        //     Console.Write(n + ", ");
        // }


        // int valorBuscado = 96;

        // Busqueda busqueda = new BusquedaRecursiva();
        // int indice = busqueda.ObtenerPosicion(numeros, 96);

        // if (indice == -1)
        //     System.Console.WriteLine("Valor de busqueda no encontrado");
        // else
        //     System.Console.WriteLine("El elemento " + valorBuscado.ToString() + " se encuentra en la posición: " + indice.ToString());

    }
}