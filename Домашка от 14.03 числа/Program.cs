// See https://aka.ms/new-console-template for more information


    Console.WriteLine("Привет, как тебя зовут?");
    
        string name = Console.ReadLine();
    
    Console.WriteLine("Введи первое целое число:");

        string read1 = Console.ReadLine();

    Console.WriteLine("Введи второе целое число:");

        string read2 = Console.ReadLine();

    bool result1 = Int32.TryParse(read1, out int a);

    bool result2 = Int32.TryParse(read2, out int b);

    Console.WriteLine($"{name}, твои числа: {a} и {b}");

        if (a > b)
            Console.WriteLine("Первое число больше второго");
            
        if (a < b)
            Console.WriteLine("Второе число больше первого"); 
            
        else
            Console.WriteLine("Оба числа равны");

    Console.ReadLine();
    
    Console.WriteLine($"{name}, давай вычислим среднее арифметическое из двух новых чисел");

    Console.WriteLine("Введи первое целое число:");

        string read3 = Console.ReadLine();

    Console.WriteLine("Введи второе целое число:");

        string read4 = Console.ReadLine();

    bool result3 = Int32.TryParse(read3, out int c);

    bool result4 = Int32.TryParse(read4, out int d);

    int count = 2;

    float sum = c + d;
    
    float average = sum/count;
    
    Console.WriteLine($"{name}, вот твоё среднее арифметическое: {average}");
    
    Console.ReadLine();
    
    Console.WriteLine($"Чего ещё такого мы могли бы сделать, {name}, вводи скорее новое число:");
    
        string read5 = Console.ReadLine();
        
    Console.WriteLine("теперь второе:");
    
        string read6 = Console.ReadLine();
        
    bool result5 = Double.TryParse(read5, out double e);

    bool result6 = Double.TryParse(read6, out double f);

    double g = e + f;
    
    double h = e*f;
    
    double i = e/f;
    
    double j = e-f;
    
    double k = f-e;
    
    Console.WriteLine($"{name}, вот сумма: {g}");
    Console.WriteLine($"{name}, вот произведение: {h}");
    Console.WriteLine($"{name}, вот частное: {i}");
    Console.WriteLine($"{name}, вот разница первого и второго: {j}");
    Console.WriteLine($"{name}, вот разница второго и первого: {k}");

    Console.ReadLine();