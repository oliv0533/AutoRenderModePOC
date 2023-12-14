using AutoRenderMode.Client.Models;
using Bogus;

namespace AutoRenderMode.Client.Data;

public static class TestDataProvider
{
    public static List<TestModel> GetTestData()
    {
        var testData = new List<TestModel>();

        Thread.Sleep(100);

        var faker = new Faker();

        for (int i = 0; i < 500; i++)
        {
            testData.Add(new TestModel
            {
                Name = faker.Name.FullName(),
                Description = faker.Lorem.Sentence(),
                Type = faker.PickRandom<TestModelType>().ToString(),
                Value = faker.Random.Int(0, 100)
            });
        }

        return testData;
    }
}
