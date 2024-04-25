// See https://aka.ms/new-console-template for more information


while (true)
{
    Console.WriteLine("input length token :");
    string? lengthInput = Console.ReadLine();

    if (int.TryParse(lengthInput, out int lengthInt))
    {
        string result = RandomString(lengthInt);
        Console.WriteLine(result);
    }
}

string RandomString(int length)
{
    Random random = new Random();
    
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}