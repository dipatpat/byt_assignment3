namespace Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        Calculator addCalculator = new Calculator(4, 5, '+');
        Console.WriteLine(addCalculator.AddNumbers());
        Calculator subtractCalculator = new Calculator(4, 5, '-');
        Console.WriteLine(subtractCalculator.SubtractNumbers());
        Calculator multiplyCalculator = new Calculator(4, 5, '*');
        Console.WriteLine(multiplyCalculator.MultiplyNumbers());
        Calculator divideCalculator = new Calculator(4, 5, '/');
        Console.WriteLine(divideCalculator.DivideNumbers());
        Calculator divideCalculatorZero = new Calculator(4, 0, '/');
        Console.WriteLine(divideCalculator.DivideNumbers());


        app.Run();
    }
}