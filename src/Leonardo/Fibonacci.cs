namespace Leonardo;

public class Fibonacci
{
    private static int Run(int i)
    {
        if (i <= 2)
        {
            return 1;
        }

        return Run(i - 1) + Run(i - 2);
    }
    
    public static async Task<IList<int>> RunAsync(string[] args)
    {

        if (args.Length >= 100)
        {
            throw new ArgumentException("Too much");
        }
        
        IList<int> results = new List<int>();

        var tasks = new List<Task<int>>();
        foreach (var arg in args)
        {
            var task = Task.Run(() =>
            {
                var result = Fibonacci.Run(int.Parse(arg));
                return result;
            });
            tasks.Add(task);
        }

        foreach (var task in tasks)
        {
            var result = await task;
            //var result = task.Result; -> // Même chose que la ligne du dessus
            Console.WriteLine($"Result : {result}");
            results.Add(task.Result);
        }

        return results;
    }
}
