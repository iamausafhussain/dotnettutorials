namespace voconsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter a String to find number of vowels and consonants: ");

            name = Console.ReadLine();

            VowelConsonants obj = new VowelConsonants();
            obj.getString(name);
        }
    }
}

public class VowelConsonants
{
    public int count_vowels = 0;
    public int count_consonants = 0;
    public void getString(String name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] is 'a' || name[i] is 'A' || 
                name[i] is 'e' || name[i] is 'E'||
                name[i] is 'i' || name[i] is 'I' ||
                name[i] is 'o' || name[i] is 'O' ||
                name[i] is 'u' || name[i] is 'U')
            {
                count_vowels++;
            }
            else
            {
                if (name[i] is ' ')
                {
                    continue;
                }
                else
                {
                    count_consonants++;
                }

            }
        }
        Console.WriteLine($"Vowels: {count_vowels}");
        Console.WriteLine($"Consontants: {count_consonants}");

    }
}