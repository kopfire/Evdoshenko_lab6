using System.Text.RegularExpressions;

Console.WriteLine("Для выхода из задания введите exit.");
while (true)
{
    Console.Write("Выберите номер задания: ");
    switch (Console.ReadLine())
    {
        case "1":
            while (true)
            {
                Console.Write("Введите строку - ");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Console.WriteLine(Task1(input));
            }
            break;
        case "2":
            while (true)
            {
                Console.Write("Введите строку - ");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Task2(input);
            }
            break;
        case "3":
            while (true)
            {
                Console.Write("Введите строку - ");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Console.WriteLine(Task3(input));
            }
            break;
        case "4":
            while (true)
            {
                Console.Write("Введите строку - ");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Console.WriteLine(Task4(input));
            }
            break;
        case "5":
            while (true)
            {
                Console.Write("Введите строку - ");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Console.WriteLine(Task5(input));
            }
            break;

    }
}

string Task1(string _string)
{
    return Regex.Replace(_string, @"(\d)\1", "*");
}

void Task2(string _string)
{
    Regex regexToken = new Regex(@"(\w+[-]{1}\w+)|(\w+)|([""]{1}[^""]+[""]{1})");
    foreach (Match match in regexToken.Matches(_string))
        Console.WriteLine(match.Groups[0].Value);
    return;
}

string Task3(string _string)
{
    Regex regexPrivate = new Regex(@"(^[А-Я]{1}\d{3}[А-Я]{2}\d{3}$)|(^[А-Я]{1}\d{3}[А-Я]{2}\d{2}$)");
    Regex regexTaxi = new Regex(@"(^[А-Я]{2}\d{5}$)|(^[А-Я]{2}\d{6}$)");
    return regexPrivate.IsMatch(_string) ? "Частный" : regexTaxi.IsMatch(_string) ? "Такси" : "Неверно";
}

string Task4(string _string)
{
    return Regex.Replace(_string, @"[""]{1}[^""]+[""]{1}", delegate (Match m)
    {
        return string.Join("", m.Value.Replace("\"", "").Split(" ").Select(p => p.First())).ToUpper();
    });
}

string Task5(string _string)
{
    return Regex.Replace(_string, @"((0|1)[0-9]|2[0-3]):[0-5][0-9](:[0-5][0-9])?", "TBD");
}