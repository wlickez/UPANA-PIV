namespace AsyncVsParallel
{
    public class Metodos
    {
        public async Task OperacionAsync(IProgress<int> elementosOperados, IProgress<string> log, IProgress<Task> tarea)
        {
            List<Task> tasks = [];
            for (int i = 0; i < 15; i++)
            {                
                tasks.Add(Task.Run(async () =>
                {
                    // Simular una operación que toma tiempo
                    await Task.Delay(10000);
                    elementosOperados.Report(1);
                    //log.Report($"Elemento {i} operado.");
                    tarea.Report(new Task( () => 
                    {
                        log.Report($"E {i}");
                    }));
                }));                
            }
            await Task.WhenAll(tasks);
        }
    }
}
