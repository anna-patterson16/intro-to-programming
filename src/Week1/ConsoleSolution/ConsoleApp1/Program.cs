namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        //Console.WriteLine("Hello, World!");

        //Console.WriteLine("Here is another line!");

        //Console.Write("This will not have a new line at the end");


        string message = "Welcome to Class";

        DateTime now = DateTime.Now;

        string finalMessage = $"The message {message} and it is now {now:T}";

        var app = builder.Build();

        app.MapGet("/message", () =>
        {
            var response = new MessageResponseModel("This is an API: Wow!", DateTime.Now);
            return Results.Ok(finalMessage);
        });

        app.Run();


    }

}

public record MessageResponseModel(string Message, DateTime When);
