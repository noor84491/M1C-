class MC
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the rip-off of hangman");
        Console.WriteLine("Guess the word by entering 1 latter ata time");


        int attemp = 6;
        bool guessed = false;
        string wordtoguess = "apple";
        char[] letters = new string('_', wordtoguess.Length).ToCharArray();


        while (attemp > 0 && !guessed)
        {


            Console.WriteLine(wordtoguess);
            Console.WriteLine('Guessed Wrong: ' + attemp);
            Console.WriteLine('Enter a Letter: ');
            char input = char.ToLower(Console.ReadKey().KeyChar);



        }

    }
}

