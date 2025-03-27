using Singleton;

Console.WriteLine("Hello, Singleton!");

var firstInstance = TypicalSingleton.Instance;
var secondInstance = TypicalSingleton.Instance;
var thirdnstance = TypicalSingleton.Instance;

Logger.GetLogs().ForEach(Console.WriteLine);
/*var ints = new List<int>() { 1, 2, 3 };
var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = 3 };
var instances = new List<TypicalSingleton>();
Parallel.ForEach(ints, parallelOptions, instance =>
{
   instances.Add(TypicalSingleton.Instance); 
});*/