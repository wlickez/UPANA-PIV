using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        long t1, t2;
        int limit = 20;
        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();
        List<Task> tasks = new List<Task>();
        for (int i = 0; i < limit; i++)
        {
            int taskId = i;

            tasks.Add(Task.Run(async () =>
            {
                await PrintInitialization(taskId);
                await AddWaitTime(taskId);
                await PrintFinalization(taskId);

            }));

        }

        await Task.WhenAll(tasks);
        sw.Stop();


        t1 = sw.ElapsedMilliseconds;

        sw.Start();
        for (int i = 0; i < limit; i++)
        {
            await PrintInitialization(i);
            await AddWaitTime(i);
            await PrintFinalization(i);
        }
        sw.Stop();
        t2 = sw.ElapsedMilliseconds;

        Console.WriteLine($"Time elapsed using threads: {t1}");
        Console.WriteLine($"Time elapsed using no threads: {t2}");

        Console.ReadLine();
    }

    private static async Task PrintInitialization(int taskId)
    {
        Console.WriteLine($"Task {taskId} starting...");
        await Task.Delay(100);
    }

    private static async Task AddWaitTime(int taskId)
    {
        Console.WriteLine($"Task {taskId} time to wait...{1000 * taskId}");
        await Task.Delay(1000 * taskId); // simulate work
    }

    private static async Task PrintFinalization(int taskId)
    {
        Console.WriteLine($"Task {taskId} completed.");
        await Task.Delay(100);
    }
}