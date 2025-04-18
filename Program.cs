

public class Program
{
    public static void WriteToFile(List<string> lines)
    {
         File.WriteAllLinesAsync("Emails.txt", lines);
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Enter number of emails:");
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter length of email");
        int emailLength = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter domain name of email (xxxx@_____)");
        string domain = Console.ReadLine();

        List<string> emails = new List<string>() { };
        Random random = new Random();
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l",
            "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };


        int emailCount = 0;
        while (emailCount <= amount)
        {
            string Name = "";
            Name += consonants[random.Next(consonants.Length)];
            Name += vowels[random.Next(vowels.Length)];

            int i = 2;
            while (i < emailLength)
            {
                Name += consonants[random.Next(consonants.Length)];
                i++;
                Name += vowels[random.Next(vowels.Length)];
                i++;
            }
            Name += "@" + domain;
            if (!emails.Contains(Name))
            {
                emailCount++;
                emails.Add(Name);
            } 
        }
        WriteToFile(emails);
        Console.WriteLine("Done, check Emails.txt file");
    }
}

