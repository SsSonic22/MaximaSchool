// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Привет-привет, сегодня мы учиться писать самое простое сердечное признание для открытки");

    Console.WriteLine("Для начала представься:");
    string name = Console.ReadLine();

    Console.WriteLine("Введи свой год рождения:");
    string strBirthYear = Console.ReadLine();

    Console.WriteLine("Укажи свой гендер: М или Ж:");
    string gender = Console.ReadLine();

    Console.WriteLine("Укажи имя энного возлюбленного:");
    string loversName = Console.ReadLine();

    Console.WriteLine("Теперь гендер: М или Ж:");
    string loversGender = Console.ReadLine();

    Console.WriteLine("Скажи, что ты любишь больше всего-всего:");
    string aThingToCompare = Console.ReadLine();

    Console.WriteLine("И так, готовься переписывать текст ручками, так будет гораздо романтичнее, чем в тг или другом мессенджере:");

    int birthYear = Int16.Parse(strBirthYear);
    DateTime now = DateTime.Today;
    int almostConsciousAge = now.Year - birthYear - 10;

    if (loversGender == "Ж" || loversGender == "ж")
        Console.WriteLine($"    Дорогая {loversName},");

    if (loversGender == "М" || loversGender == "м")
        Console.WriteLine($"    Дорогой {loversName},");

    if (gender == "Ж" || gender == "ж")
    {
        Console.WriteLine($"с тех пор, как я могу относительно здраво мыслить, последние лет {almostConsciousAge}, ");
        Console.WriteLine("я чувствовал и знал, что обязательно встречу именно тебя. Никаких слов не хватит описать то, насколько счастливым ты меня делаешь каждый день, и,");
        Console.WriteLine("как сильно я тобой дорожу.");
        Console.WriteLine($"  Сладкая ты булка, {loversName}, я не знаю, как описать свои чувства к тебе.");
        Console.WriteLine("Рядом с тобой я ощущаю себя сильнее и теплее, я могу тебе доверить всё, что угодно. Я хочу видеть, как ты улыбаешься каждый день.");
        Console.WriteLine("Мою любовь к тебе невозможно измерить в количестве подарков, силе объятий или в том, как часто я думаю о тебе в течение дня.");
        Console.WriteLine($"В это почти невозможно поверить, но я люблю тебя даже больше чем {aThingToCompare}.");
        Console.WriteLine($"Ты, {loversName}, лучшее, что случалось со мной в этой жизни.");
        Console.WriteLine("Я буду бесконечно ждать и делать всё ради нашего счастливого совместного будущего.");
        Console.WriteLine("        С любовью,");
        Console.WriteLine($"            твоя {name}");
    }

    if (gender == "М" || gender == "м")
    {
        Console.WriteLine($"с тех пор, как я могу относительно здраво мыслить, последние лет {almostConsciousAge},");
        Console.WriteLine("я чувствовал и знал, что обязательно встречу именно тебя. Никаких слов не хватит описать то, насколько счастливым ты меня делаешь каждый день, и,");
        Console.WriteLine("как сильно я тобой дорожу.");
        Console.WriteLine($"  Сладкая ты булка, {loversName}, я не знаю, как описать свои чувства к тебе.");
        Console.WriteLine("Рядом с тобой я ощущаю себя сильнее и теплее, я могу тебе доверить всё, что угодно. Я хочу видеть, как ты улыбаешься каждый день");
        Console.WriteLine("Мою любовь к тебе невозможно измерить в количестве подарков, силе объятий или в том, как часто я думаю о тебе в течение дня.");
        Console.WriteLine($"В это почти невозможно поверить, но я люблю тебя даже больше чем {aThingToCompare}.");
        Console.WriteLine($"Ты, {loversName}, лучшее, что случалось со мной в этой жизни.");
        Console.WriteLine("Я буду бесконечно ждать и делать всё ради нашего счастливого совместного будущего.");
        Console.WriteLine("        С любовью,");
        Console.WriteLine($"            твой {name}");
    }

    Console.ReadLine();
