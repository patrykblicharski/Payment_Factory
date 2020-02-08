using System;

namespace Bankowosc.Tools
{
    public static class CColor
    {
        public static void SetCcolor(ConsoleColor back, ConsoleColor litery)
        {
            Console.BackgroundColor = back;
            Console.ForegroundColor = litery;
        }

        public static void ResetCColor()
        {
            Console.ResetColor();
        }
    }

}
/*
 * public enum ConsoleColor
  {
   
0    Black,
1    DarkBlue,
2    DarkGreen,
3    DarkCyan,
4    DarkRed,
5    DarkMagenta,
6    DarkYellow,
7    Gray,
8    DarkGray,
9   Blue,
10    Green,
11   Cyan,
12   Red,
13   Magenta,
14   Yellow,
15   White,
  }
 */
