// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

    Console.WriteLine("Привет, давай зашифруем какое-нибудь предложение))");
    Console.WriteLine("Введи текст, но без знаков перпинания:");

    string sentence =  Console.ReadLine() ;
    string[] sentenceSplit;
    sentenceSplit = sentence.Split(' ');

    int sentenceCount = sentenceSplit.Length;//Количество слов
    Console.WriteLine($"Количество слов {sentenceCount}");

    string result = String.Concat(sentenceSplit.Select(word => char.ToUpper(word[0])));
    
    Console.WriteLine($"{result}");


    Console.WriteLine("Теперь просто всякую ерунду поделаем");
    Console.WriteLine("Введи текст:");

    string word =  Console.ReadLine();
    
    word = word.Replace("а", "о").Replace("ж", "я").Replace("щ", "ч").Replace("ф", "х").Replace("и", "е");
    Console.WriteLine($"{word}");
    
    
    Console.WriteLine($"А теперь проверим кое-что, вводи текст");
    
    string text = Console.ReadLine();
    
    string a = "гей";
    string b = "геи";
    string c = "голубой";
    string d = "гомо";
    string e = "радуга";
    string f = "радужный";
    string g = "счастливый";
    string h = "утончённый";
    string i = "женственный";
    string j = "интеллигентный";
    string k = "стильный";
    string l = "дизайнер";
    string m = "свободомыслящий";
    string n = "не ватник";
    string o = "личность";
    string p = "яркий";
    string q = "эмигрант";


 
    if (text.Contains(a)||
        text.Contains(b)||
        text.Contains(c)||
        text.Contains(d)||
        text.Contains(e)||
        text.Contains(f)||
        text.Contains(g)||
        text.Contains(h)||
        text.Contains(i)||
        text.Contains(j)||
        text.Contains(k)||
        text.Contains(l)||
        text.Contains(m)||
        text.Contains(n))
        
        Console.WriteLine("Ах ты, злостный нарушитель, езжай на нары к насильникам и убийцам за пропаганду гомосексуализма");
        
 