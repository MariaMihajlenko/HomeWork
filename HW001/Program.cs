    Console.WriteLine("Введите первое число ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число ");
    int number2 = Convert.ToInt32(Console.ReadLine());


    if (number1 > number2)
    {
        Console.WriteLine("большее число");
        Console.WriteLine(number1);
        Console.WriteLine("меньшее число");
        Console.WriteLine(number2);
    }
    else if (number1 <number2)
    {
        Console.WriteLine("большое число");
        Console.WriteLine(number2);
        Console.WriteLine("меньшее число");
        Console.WriteLine(number1);

    }
    else if (number1 == number2)

    {
        Console.WriteLine("числа равны");
      
    }
    
    