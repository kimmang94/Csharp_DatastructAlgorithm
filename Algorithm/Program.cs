using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';
            int lastTick = 0;
            while (true)
            {
                #region 프레임관리
                // FPS 프레임 60프레임 OK 30프레임이하 NO)
                int currentTick = System.Environment.TickCount;
                // 1초는 1000ms
                if (currentTick - lastTick < WAIT_TICK)
                    continue;

                lastTick = currentTick;
                #endregion
                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}