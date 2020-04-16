using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordSetUtil
{
    class WordSetUtil
    {
        public static string GetSlicedWord(string sourceStr, string[] wordSet)
        {
            string slicedWord = "";
            bool flag = true;
            int cnt = 0;
            while(flag)
            {
                cnt = 0;
                foreach (var item in wordSet)
                {
                    string pattern = item;
                    Regex reg = new Regex(pattern);
                    var match = reg.Match(sourceStr);
                    if(match.Success == false)
                    {
                        cnt += 1;
                        if(cnt == wordSet.Length)
                        {
                            flag = false;   //所有单词项都没有找到，结束切割
                        }
                    }
                    else if(match.Index == 0)   //为了按顺序输出，只计算最前面的单词
                    {
                        slicedWord = slicedWord + " " + (match.ToString());
                        sourceStr = reg.Replace(sourceStr, "", 1);
                    }
                }
            }

            if (sourceStr.Length > 0)
            {
                slicedWord = "";
            }

            return slicedWord;
        }
    }
}
