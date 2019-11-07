using System;
using System.Collections.Generic;
using System.Text;

namespace HanoiGameMain
{
    class HanoiGame
    {
        int disk;
        int from;
        int to;
        int aux = 0;

        int isInt = 0;

        bool m_bWhile = true;

        public void Setup()
        {
            //輸入高度
            while (m_bWhile == true)
            {
                Console.WriteLine("請輸入河內塔的高度：");
                string input = Console.ReadLine();
                //disk = int.Parse(input);

                if (int.TryParse(input, out isInt))
                {
                    if (isInt <= 0 || isInt > 9)
                    {
                        Console.WriteLine("超出範圍，請重新輸入\r\n");
                    }
                    else
                    {
                        disk = int.Parse(input);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("輸入失敗，請重新輸入\r\n");
                }
            }



            while (m_bWhile == true)
            {
                Console.WriteLine("起始地的柱子:(1,2,3)");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out isInt))
                {
                    if (isInt == 1 || isInt == 2 || isInt == 3)
                    {
                        from = int.Parse(input1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("超出範圍，請重新輸入\r\n");
                    }
                }
                else
                {
                    Console.WriteLine("輸入失敗，請重新輸入\r\n");
                }
            }

            while (m_bWhile == true)
            {
                Console.WriteLine("目的地的柱子：(1,2,3)");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out isInt))
                {
                    if (isInt == 1 || isInt == 2 || isInt == 3)
                    {
                        to = int.Parse(input2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("超出範圍，請重新輸入\r\n");
                    }
                }
                else
                {
                    Console.WriteLine("輸入失敗，請重新輸入\r\n");
                }
            }



            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }
            #endregion

        }

        public void Play()
        {
            Hanoi(disk, from, to, aux);
        }


        //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
        //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
        public static void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }
    }
}
