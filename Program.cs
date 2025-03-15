namespace tpmodul5_103022300154
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataGeneric<string> nim = new DataGeneric<string>("103022300154");
            DataGeneric<int> age = new DataGeneric<int>(20);

            nim.PrintData();
            age.PrintData();
        }
    }

    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

}