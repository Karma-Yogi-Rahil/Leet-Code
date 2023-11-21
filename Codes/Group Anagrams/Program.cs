namespace Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> groupAnagramDict = new();

            foreach (string word in strs)
            {
                string sortedString = new String(word.OrderBy(c => c).ToArray());

                if (groupAnagramDict.ContainsKey(sortedString))
                {
                    groupAnagramDict[sortedString].Add(word);

                }
                else
                {

                    groupAnagramDict.Add(sortedString, new List<string>());
                    groupAnagramDict[sortedString].Add(word);

                }

            }

            IList<IList<string>> list =;

           foreach(string word in groupAnagramDict.Keys)
            {

            }




        }
    }
}