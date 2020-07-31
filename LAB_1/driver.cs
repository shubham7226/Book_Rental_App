using SimpleMaths;
using System;  
namespace usingDLL
{
	public class getResult
	{
		public static void main(string[] args)
		{
			Operations c = new Operations();
			int ans=c.add(2,3);
			Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}