using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    internal class MyArrayList01
    {
        private int [] Data;//定义一个数组
        private int N;      //定义一个变量记录数组的容量
        /// <summary>
        ///  
        /// </summary>
        /// <param name="Capacity">默认集合长度</param>
        public MyArrayList01(int Capacity)
        {
            Data = new int [ Capacity ];//初始化数组长度
            N = 0;                      //初始化数组容量
        }
    }
}
