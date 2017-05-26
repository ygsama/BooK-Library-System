using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 图书管理系统
{
    // 因为要频繁使用Dictionary<string, string> 
    // 所以用一个自定义类MyDictionary继承Dictionary<string, string> 
    public class MyDictionary : Dictionary<string, string>
    {
    }
}
