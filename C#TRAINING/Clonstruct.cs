public class MyClass
{
    public int id { get; private set; }

    public string name;
    public MyClass()
    {
    }
    public MyClass(int id) : this()
    {
        this.id = id;
        
    }
    public MyClass(int id, string name) : this(id)

    {
        this.id = id;
        this.name = name;
        Console.WriteLine(id+name);
    }

}
