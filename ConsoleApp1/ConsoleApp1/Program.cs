class Program {
    static void Main(string[] args)
    {
        Random stevilo=new Random();
        int nak=stevilo.Next(1, 101);
        int ugani = -1;
        int stevec = 0;
        while (nak != ugani)
        {
            Console.Write("Vnesi število: ");
            ugani=int.Parse(Console.ReadLine());
            stevec++;
            if (ugani < nak)
                Console.WriteLine("Število je premajhno.");
            else if (ugani > nak)
                Console.WriteLine("Število je preveliko.");
        }
        Console.WriteLine("Naključno število: "+nak);
        Console.WriteLine("Bravo, uganil si.");
        Console.WriteLine("Število poskusov: " + stevec);
    }
}