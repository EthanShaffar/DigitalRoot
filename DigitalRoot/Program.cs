using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void DigitalRoot(string rootThis)
        {
            List<int> nums = new List<int>();
            var inp = rootThis;
            var count = 0;
            while(inp.Length>1)
            {
                for (int i = 0; i < inp.Length; i++)
			    {
			        nums.Add(Convert.ToInt32(inp[i].ToString));
			    }
                foreach (int s in nums)
                {
                    count += s;
	{
		 
	}
                
        }
    }
}
