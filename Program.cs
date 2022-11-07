namespace DelegatePractices
{
    class Program
    {
        static void Main(string[] args)
        {

            string folderPath = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(folderPath);
            Console.WriteLine(di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length));

            Console.Read();
        }
    }
}