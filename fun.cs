using HelloWorld

Console.WriteLine("***** Fun with Class Types *****\n");

Program myProgram = new Program();
myProgram.programName = "SwagRat";
myProgram.swagLevel = 3;

myProgram.PrintState();

for (int i = 0; i <= 10; i++) {
    myProgram.increaseSwag(2);
    myProgram.PrintState();
}
Console.ReadLine();