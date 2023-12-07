using System;
namespace sayhello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");//Chỉ viết thì ko cần WriteLine
            string name = Console.ReadLine();//Sử dụng phương thức ReadLine() của lớp System.Console để nhập tên từ bàn phím. Gán thì ko cần Console
            Console.WriteLine("Hello " + name + "!");//Sử dụng phương thức WriteLine() để hiển thị lời chào.
            Console.Write("Very nice to meet you!");
        }
    }
}