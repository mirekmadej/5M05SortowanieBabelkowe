namespace _5M05SortowanieBabelkowe
{
    class Tablica
    {
        private const int N = 50;
        private int[] tablica = new int[N];
        public Tablica()
        {

        }
        public void wylosujTablice()
        {
            Random r = new Random();
            for (int i = 0; i < N; i++)
                tablica[i] = r.Next(0, 101);
        }
        public void wypiszTablice()
        {
            foreach(int i in tablica)
                Console.Write($"{i}, ");
            Console.WriteLine();
        }
        public void sortujTablice()
        {
            for (int i = 0;i < N;i++)
            {
                for(int j = i+1; j < N;  j++)
                    if(tablica[j] < tablica[i])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[i];
                        tablica[i] = temp;
                    }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica tablica = new Tablica();
            tablica.wylosujTablice();
            Console.WriteLine("tablica nieposortowana");
            tablica.wypiszTablice();
            Console.WriteLine("tablica posortowana");
            tablica.sortujTablice();
            tablica.wypiszTablice();
        }
    }
}
