using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordSetUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "helloworldandboygirls";
            string[] wordSet = {"hello", "and", "girls", "boy", "world"};
            var slicedWords = WordSetUtil.GetSlicedWord(line, wordSet);
            if(slicedWords.Length > 0)
            {
                Console.WriteLine(string.Format("{0}\n{1}", "切割成功", slicedWords));
            }
            else
            {
                Console.WriteLine("切割失败！");
            }

            Console.ReadLine();
        }
    }
}
