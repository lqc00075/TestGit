namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("第二次提交测试");
            Console.WriteLine("第三次提交测试");
            Console.WriteLine("第四次提交测试");
            int[] arr = new int[6] { 2, 5, 3, 6, 1, 2 };
            PrintfArr(arr);

        }
        public static void PrintfArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
