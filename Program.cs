namespace _4_modul_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(() =>
            //{
            //    int a = 0;
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        a++;
            //    }
            //    Console.WriteLine(a);
            //});

            //thread.Start();

            //add for git ignore test

            //int b = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    b++;
            //}
            //Console.WriteLine(b);

            Do();
        }
        public static async Task Do()
        {
            Console.WriteLine("sfssf");
            Task.Run(() =>
            {
                Test();
            });
        }
        public static void Test(object? obj = null)
        {
            Thread.Sleep(10000);
        }
    }
}