using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P105032013125_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("欢迎您来到未来世界，请输入您需要提供服务的代码:");
                Console.WriteLine("0:收听服务在线");
                Console.WriteLine("1:观看未来在线视频");
                Console.WriteLine("2:退出");
                int s = Int32.Parse(Console.ReadLine());

                switch (s)
                {
                    case 0:
                        Console.WriteLine("欢迎您收听服务在线，频道接收中...");
                        Console.WriteLine("按回车继续选择其他服务");
                        while (Console.ReadLine() != "") ; break;
                    case 1:
                        Console.WriteLine("欢迎观看未来在线视频，视频播放中..");
                        Console.WriteLine("按回车继续选择其他服务");
                        while (Console.ReadLine() != "") ; break;
                    case 2:
                        Console.WriteLine("您确定需要退出吗？");
                        Console.WriteLine("按回车退出，其他任意键后回车则继续选择其他服务");
                        if (Console.ReadLine() != "") break;
                        return;
                }
            }
        }
    }
}
