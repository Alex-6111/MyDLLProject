
using  MyLibrary;

namespace MyDLLProject
{
    internal class Program
    {
        static void Main()
        {
            
            double result = MyDLL.Multiply(3,5);
            Console.WriteLine(result);
        }
    }
}