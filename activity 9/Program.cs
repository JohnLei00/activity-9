internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string>();
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Enter full name: ");
            string name = Console.ReadLine();
            string formattedName = string.Join(" ", name.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
            names.Add(formattedName);
        }

        Console.WriteLine("Formatted Names: ");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}