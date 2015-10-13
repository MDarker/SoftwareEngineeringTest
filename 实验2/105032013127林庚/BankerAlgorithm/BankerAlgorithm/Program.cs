using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RESRCNUM = 3;//资源数
            const int PRONUM = 5;//进程数

            int iProcess;//请求分配资源的进程数

            //最大需求的资源
            int[,] iMax = { { 7, 5, 3 }, { 3, 2, 2 }, { 9, 0, 2 }, { 2, 2, 2 }, { 4, 3, 3 } };

            //已经分配的资源
            int[,] iAllocation = { { 0, 1, 0 }, { 2, 0, 0 }, { 3, 0, 2 }, { 2, 1, 1 }, { 0, 0, 2 } };

            //还需要的资源
            int[,] iNeed = { { 7, 4, 3 }, { 1, 2, 2 }, { 6, 0, 0 }, { 0, 1, 1 }, { 4, 3, 1 } };

            //还可利用的资源
            int[] iAvailable = { 3, 3, 2 };

            int[,] iRequest = new int[PRONUM, RESRCNUM];

            if (Security.IsSecurity(iAllocation, iNeed, iAvailable))//如果安全
            {
                Console.WriteLine("请输入要申请资源的进程号(0-4)");
                iProcess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入进程所请求的各资源的数量");
                for (int j = 0; j < RESRCNUM; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                    iRequest[iProcess, j] = Convert.ToInt32(Console.ReadLine()); ;
                }
                if (Banker.Request(iProcess,iNeed, iAvailable, iRequest))
                {
                    Banker.BankerAllocate(iProcess,iAllocation, iNeed, iAvailable, iRequest);
                }
                else
                {
                    Console.WriteLine("请求分配失败");
                }
            }
            else
                Console.WriteLine("0时刻分配使系统不安全，失败");
            Console.ReadKey();
        }
    }
}
