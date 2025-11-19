using EverybodyCodes2025;

ISolution solution = new EverybodyCodes2025.Quest2.Part3.Solution();
Console.WriteLine("Running for {0}...", solution.GetType().FullName);

var startDateTime = DateTime.Now;
solution.Run();

Console.WriteLine("Completed (took {0}ms)", (DateTime.Now - startDateTime).Milliseconds);
Console.WriteLine("Press any key to quit");
Console.ReadKey();
