/*
使用cloc 計算程式行數，程式碼內的空白列和註解都會被自動替除

但是因為它非編譯器，所以不會替除無用#if內容

因此該範例會偵測到31行

註解內的空白列為計算到註解的行數，而是統計在空白的計數器中

寫在程式碼後的註解也不會被統計到註解註解的行數
*/

#define DEBUG
#define MYTEST 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ifdefined
{
    class Program
    {
        static void pause()//模擬DOS的pause命令
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            #if (DEBUG && !MYTEST)
				Console.WriteLine("DEBUG is defined");  
            #elif (!DEBUG && MYTEST)
				Console.WriteLine("MYTEST is defined");  
            #elif (DEBUG && MYTEST)
				Console.WriteLine("DEBUG and MYTEST are defined");
            #else
				Console.WriteLine("DEBUG and MYTEST are not defined");  
            #endif
            pause();
        }
    }
}