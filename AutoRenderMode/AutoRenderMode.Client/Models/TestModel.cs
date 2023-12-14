namespace AutoRenderMode.Client.Models;

public class TestModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int Value { get; set; }
}

public enum TestModelType
{
    Foo,
    Bar,
    Baz
}
