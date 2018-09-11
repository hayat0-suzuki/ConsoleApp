using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************
* 入力した文字列をそのまま表示するプログラム *
**************************************/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("読み取り開始");

            // 1. Console.ReadLine()で、文字列を入力してもらう。
            // 2. Console.Write()で、入力してもらった文字列を出力（改行なし）
            Console.WriteLine(Console.ReadLine());
            // 次の文字列を出力
            Console.Write("を読み取りましたよ。");
        }
    }
}

