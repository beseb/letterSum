namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "Y";
            string motSaisie = "";


            do { 
            Console.WriteLine("Entre un mot :");
            motSaisie = Console.ReadLine();
            char[] charMot = motSaisie.ToCharArray();

            // Comptage des lettres dans charMot[]
            int indexAlpha = 0;
            int total = 0;
            // Declaration Alphabet
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            // Recherche des lettres
            for (int i = 0; i < charMot.Length; i++)
            {
                total += Array.IndexOf(alphabet, charMot[i]) + 1;

            }


            Console.WriteLine($"Le résultat de l'addition des lettres du mot saisi est :{total} ");
            Console.WriteLine("Recommencer ? Y/N ?");
            recommencer = Console.ReadLine().ToUpper();

        }while (recommencer != "N") ;
        }

    }
}
