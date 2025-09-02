using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // for (int i = 0; i < 20; i++)
        // {
        //     await Task.Delay(500);
        //     System.Console.WriteLine(i);
        // }

        List<Task> tareas = [];

        for (int i = 0; i < 20; i++)
        {
            tareas.Add(Task.Run(async () =>
            {
                System.Console.WriteLine(i);
            }));
        }

        await Task.WhenAll(tareas);
    }
}