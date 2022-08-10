Console.WriteLine("Введите число");
while (true)
{
    string input = Console.ReadLine();
    if (!input.Equals("exit"))
        Console.WriteLine("{0}->{1}", input, input[2]);
    else
        break;
}

// команда exit - выход