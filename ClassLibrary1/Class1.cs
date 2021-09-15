using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int StringLength(string[] strings)
        {
            int result = 0;

            if (strings != null)//fångar upp om hela arrayen är null
            {
                foreach (var str in strings)
                {
                    if (str != null)//Fångar upp om en position i arrayen är null
                    {
                        result += str.Length;
                    }
                }
            }
            return result;
        }
    }
}
