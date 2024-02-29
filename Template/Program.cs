public class Program 
{
    public static void Main(string[] args)
    {
        CreateHost(args).Build().Run();
    }

    public static IHostBuilder CreateHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
