using CsvDataGen.Models;

namespace CsvDataGen;

public static class DataGenerator
{
    public static IEnumerable<Person> Generate(int count)
    {
        var faker = new Bogus.Faker<Person>()
            .RuleFor(p => p.Name, f => f.Name.FullName())
            .RuleFor(p => p.Birthday, f =>
                f.Date.Between(
                    new DateTime(1970, 1, 1),
                    DateTime.Now.AddDays(-1)
                )
            );

        return faker.Generate(count);
    }
}