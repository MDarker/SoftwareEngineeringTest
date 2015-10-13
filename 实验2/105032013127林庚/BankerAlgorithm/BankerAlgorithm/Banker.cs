using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerAlgorithm
{
    class Banker
    {
        const int RESRCNUM = 3;//资源数
        const int PRONUM = 5;//进程数

        //进行分配
        public static void BankerAllocate(int iProcess, int[,] Allocation, int[,] Need, int[] Available, int[,] Request)
        {
            for (int j = 0; j < RESRCNUM; j++)
            {
                Available[j] -= Request[iProcess, j];
                Allocation[iProcess, j] += Request[iProcess, j];
                Need[iProcess, j] -= Request[iProcess, j];
            }

            if (Security.IsSecurity(Allocation, Need, Available))
                Console.WriteLine("分配成功");
            else
            {
                for (int j = 0; j < RESRCNUM; j++)
                {
                    Available[j] += Request[iProcess, j];
                    Allocation[iProcess, j] -= Request[iProcess, j];
                    Need[iProcess, j] += Request[iProcess, j];
                }
                Console.WriteLine("此次分配使系统不安全，分配失败");
            }
        }

        //判断请求的资源数是否合理
        public static bool Request(int iProcess, int[,] Need, int[] Available, int[,] Request)
        {
            int j;
            for (j = 0; j < RESRCNUM; j++)
            {
                if (Request[iProcess, j] <= Need[iProcess, j])
                {
                    if (Request[iProcess, j] <= Available[j])
                        continue;
                    else
                    {
                        Console.WriteLine("尚无足够的资源");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("所要求的资源数超过进程需要的资源数");
                    break;
                }
            }
            if (j == RESRCNUM)
                return true;
            else
                return false;
        }
    }
}
