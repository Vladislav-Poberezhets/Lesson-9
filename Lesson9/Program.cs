using System.Text.RegularExpressions;



var appPath = "D:\\C#\\Lesson8\\Task\\Book.csv";
var phonebook = ReadFile(appPath);
try
{
    AddPerson(appPath);
}
catch (Exception ex)
{
    Console.WriteLine("Не вдалось добавити людину в телефонну книгу!");
    Console.WriteLine($"{ex.Message}"); 
}

try
{
    phonebook = ReadFile(appPath);
}
catch (Exception ex)
{
    Console.WriteLine("Помилка читання файлу!");
    Console.WriteLine($"{ex.Message}");
}
try
{
    Console.WriteLine("Search person");
    var person = SearchPerson(Console.ReadLine(), phonebook);
    Console.WriteLine(person);
}
catch (Exception ex)
{

    Console.WriteLine("Помилка пошуку людини!");
    Console.WriteLine($"{ex.Message}");
}


List<(string FirstName, string SecondName, string PhoneNumber)> ReadFile(string path)
{
    if (!File.Exists(path)) return null;
    var book = new List<(string FirstName, string SecondName, string PhoneNumber)>();
    var lines = File.ReadAllLines(path);
    try
    {
        foreach (var line in lines)
        {
            var split = line.Split(",");
            book.Add((split[0], split[1], split[2]));
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine("Помилка перебору колекції!");
        Console.WriteLine($"{ex.Message}");
    }
    try
    {
        book.Sort();
    }
    catch (Exception ex)
    {

        Console.WriteLine("Помилка сортування!");
        Console.WriteLine($"{ex.Message}");
    }
   
    return book;

}

(string, string, string) SearchPerson(
    string input,
    List<(string, string, string)> collection)
{
    return collection.FirstOrDefault(person =>
    person.Item1.Contains(input, StringComparison.OrdinalIgnoreCase) ||
    person.Item2.Contains(input, StringComparison.OrdinalIgnoreCase) ||
    person.Item3.Contains(input, StringComparison.OrdinalIgnoreCase));
}

void AddPerson(string path)
{
    InputValue(out var FirstName, "FirstName");
    InputValue(out var SecondName, "SecondName");
    InputValue(out var PhoneNumber, "PhoneNumber");
    File.AppendAllLines(
        path,
        new[] { $"{FirstName},{SecondName},{PhoneNumber}" });
}
void InputValue(out string result, string fieldName)
{
    Console.WriteLine($"Enter {fieldName}:");
    result = Console.ReadLine();
    Console.WriteLine($"{fieldName} submitted: {result}");
}  