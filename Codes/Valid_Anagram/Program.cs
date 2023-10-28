namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsAanagram("anagram2$β", "nagaram$2β"));

        }

        internal static bool IsAanagram(string s, string t)
        {

            if(s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char,int> stringDict = new Dictionary<char,int>();

            foreach(char  s2 in s)
            {
                if (stringDict.ContainsKey(s2))
                {
                    stringDict[s2]++;
                }
                else
                {
                    stringDict.Add(s2, 1);
                }

            }

            foreach(char t2 in t)
            {
                if (stringDict.ContainsKey(t2))
                {
                    stringDict[(char)t2]--;
                    if (stringDict[t2] == 0)
                    {
                        stringDict.Remove(t2);
                    }
                }
            }

            if(stringDict.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }


            //return false;

        }

    }
}