using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{//呈現1~20, 若是3的倍數顯示 foo, 若是5的倍數顯示bar, 若是15的倍數顯示foobar, 其餘顯示數值
	internal class Program
	{
		static void Main(string[] args)
		{
			int length = 20;
			for (int i = 1; i <= length; i++)
			{
				if ((i % 15) == 0)
				{
					Console.WriteLine("foobar");
				}
				else if ((i % 5) == 0)
				{
					Console.WriteLine("bar");
				}
				else if ((i % 3) == 0)
				{
					Console.WriteLine("foo");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
