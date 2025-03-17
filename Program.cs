namespace HelloWorld;

// source: Pro C# 10 book, chapter 5

class Program {
    public string programName;
    public int swagLevel;

    public void PrintState()
        => Console.WriteLine("Hello! {0} has a swaglevel of {1}!", programName, swagLevel);

    public void increaseSwag(int swag)
        => swagLevel += swag;
}
