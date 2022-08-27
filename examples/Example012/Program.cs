


void Method1()
{
    System.Console.WriteLine("Автор...");
}
// Method1(); // вызов метода

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2(msg: "Text");


void Method21(string msg, int count);
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4);