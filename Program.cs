namespace tpmodul5_103022300154
{
    class Program
    {
        public static void Main(string[] args)
        {
            HaloGeneric.SapaUser("Afriza Gilleon");
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine($"Hello user {nama}");
        }
    }
}