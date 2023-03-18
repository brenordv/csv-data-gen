using CsvDataGen;

Console.WriteLine("Name Birthday CSV Generator!");
Console.WriteLine(
    "How to use: csvdatagen.exe <output filename.csv - default: data.csv> <number of records - default: 1000>");

var file = "data.csv";
var numberOfRecords = 1000;

// Hacky way to parse command line.
if (args.Length >= 1)
    file = args[0];

if (args.Length == 2)
    numberOfRecords = int.Parse(args[1]);

using var sw = new StreamWriter(file);

foreach (var person in DataGenerator.Generate(numberOfRecords))
{
    sw.WriteLine($"{person.Name},{person.Birthday:yyyy-MM-dd}");
}


Console.WriteLine($"Done! {numberOfRecords} records written to {file}");
Console.WriteLine("Bye! Have a nice day!");