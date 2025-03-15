namespace tpmodul5_103022300154
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    class DataGeneric<T>
    {
        private T data;
        DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

}