using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerAlgorithm
{

    class Security
    {
        const int RESRCNUM = 3;//资源数
        const int PRONUM = 5;//进程数

        private static void ShowSituation(int[] SafeSeq, int[,] Allocation, int[,] Need, int[] Available)
        {
            int Proce;
            Console.WriteLine("进程" + '\t' + "Allocation" + '\t' + "Need" + '\t' + "Available");
            for (int i = 0; i < PRONUM; i++)
            {
                Proce = SafeSeq[i];
                Console.WriteLine("  " + Proce);
                for (int j = 0; j < RESRCNUM; j++)
                {
                    Console.Write('\t' + "   " + Allocation[Proce, j] + '\t' + '\t' + ' ' + Need[Proce, j] + '\t' + "   " + Available[j]);//空格加在\t之后才有效
                }
                Console.WriteLine();
            }
        }

        //安全性算法
        public static bool IsSecurity(int[,] Allocation, int[,] Need, int[] Available)
        {
            int[] SafeSeq = new int[PRONUM];//记录安全序列
            int[] Work = new int[RESRCNUM];
            bool[] Finish = new bool[PRONUM];
            int FinNum = 0;//Finish为true的数目

            for (int i = 0; i < PRONUM; i++)
                Finish[i] = false;//FINISH记录每个进程是否安全  
            for (int i = 0; i < RESRCNUM; i++)
                Work[i] = Available[i];

            bool flag = true;
            for (int i = 0; flag; i++)
            {
                flag = false;//若循环之后没得到成功的结果，退出循环

                i = i % PRONUM;//保证i在0-4之间

                int j = 0;
                for (; j < RESRCNUM && Finish[i] == false; j++)//检测第i进程需要的所有资源 是否大于 系统现有的资源
                    if (Need[i, j] > Work[j])
                        break;//不能通过的话，进行下一个进程的检测

                if (j == RESRCNUM)//第i进程可以分配到资源
                {
                    Finish[i] = true;
                    for (int a = 0; a < RESRCNUM; a++)//释放该进程的资源
                        Work[a] += Allocation[i, a];
                    SafeSeq[FinNum++] = i;
                    flag = true;
                }
                else
                {
                    if (i < PRONUM - 1)//循环，如果又到达最后一个时，还没有找到可分配的，就说明不安全
                        flag = true;
                    continue;
                }

                if (FinNum == PRONUM)//Finish全为true
                {
                    Console.WriteLine("系统是安全的");
                    Console.WriteLine("安全序列:");
                    for (int i1 = 0; i1 < PRONUM; i1++)
                    {
                        Console.WriteLine(SafeSeq[i1]);
                        if (i1 != PRONUM - 1)
                            Console.WriteLine(" ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowSituation(SafeSeq, Allocation, Need, Available);
                    return true;
                }
            }
            return false;
        }
    }
}
