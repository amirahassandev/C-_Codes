using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace ProblemSolving
{
    // 705. Design HashSet
    public class MyHashSet
    {
        //List<int> hashSet = new List<int>();
        private bool[] set = new bool[1];

        public MyHashSet()
        {
            
        }

        public void Add(int key)
        {
            //if (!this.Contains(key))
            //{
            //    this.hashSet.Add(key);
            //}
            if(key >= set.Length)
            {
                Array.Resize(ref set, key + 1); 
            }

            set[key] = true;
        }

        public void Remove(int key)
        {
            //this.hashSet.Remove(key);
            if (key < set.Length)
            {
                set[key] = false;
            }
        }

        public bool Contains(int key)
        {
            //return this.hashSet.Contains(key);
            if (key < set.Length)
            {
                return set[key];
            }

            return false;
        }
    }

    // 706. Design HashMap
    public class MyHashMap
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        public MyHashMap()
        {

        }

        public void Put(int key, int value)
        {
            map[key] = value;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                return map[key];
            }
            return -1;
        }

        public void Remove(int key)
        {
            map.Remove(key);
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */


    internal class Program
    {
        // Concatenation Of Array (1929)
        public static int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                ans[i] = ans[i+n] = nums[i];
            }
            return ans;
        }


        // Contains Dublicate

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if(set.Contains(num)) return true;
                set.Add(num);
            }
            return false;
        }


        // Valid Anagram
        //public static bool IsAnagram(string s, string t)
        //{
        //    if(s.Length != t.Length)
        //    {
        //        return false;
        //    }

        //    var sSorted = s.ToLower().ToList();
        //    sSorted.Sort();
        //    var tSorted = t.ToLower().ToList();
        //    tSorted.Sort();

        //    for(int i = 0; i < sSorted.Count; i++)
        //    {
        //        if (tSorted[i] != sSorted[i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] checking = new int[26] ;

            for(int i = 0; i<s.Length; i++)
            {
                checking[s[i] - 'a']++;
                checking[t[i] - 'a']--;
            }

            foreach(int val in checking)
            {
                if(val != 0)
                {
                    return false;
                }
            }

            return true;
        }


        // Two sum
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i<nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.TryGetValue(complement, out int index))
                {
                    return new int[] { index, i };  
                }

                dic[nums[i]] = i;          
                    
            }

            return new int[] {};
        }

        // 14. Longest Common Prefix
        //public static string LongestCommonPrefix(string[] strs)
        //{
        //    string commonPrefix = string.Empty;
        //    int count = 0;
        //    int length = strs.MinBy(w => w.Length).Length;

        //    for(int chr = 0; chr < length; chr++)
        //    {
        //        count = 0;
        //        for (int word = 0; word < strs.Length - 1; word++)
        //        {
        //            if (strs[word][chr] == strs[word + 1][chr])
        //            {
        //                count++;
        //            }
        //        }
        //        if(count == strs.Length - 1)
        //        {
        //            commonPrefix += strs[0][chr];
        //        }
        //        else
        //        {
        //            return commonPrefix;
        //        }
        //    }
        //    return commonPrefix;
        //}


        public static string LongestCommonPrefix(string[] strs)
        {
            string commonPrefix = strs[0];
            if(strs == null)
            {
                return "";
            }

            //foreach(string word in strs)
            for (int i = 0; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(commonPrefix))
                {
                    commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);
                }
                if(commonPrefix == "")
                {
                    return "";
                }
            }
            return commonPrefix;
        }


        // 49. Group Anagrams
        //public static IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    IList<IList<string>> anagramsData = new List<IList<string>>();

        //    List <string> strsData = strs.ToList();
        //    while(strsData.Count > 0)
        //    {
        //        IList<string> group = new List<string>();
        //        group.Add(strsData[0]);

        //        strsData.Remove(strsData[0]);

        //        for(int wordIdx = 0; wordIdx < strsData.Count; wordIdx++)
        //        {

        //            if (group[0].Length != strsData[wordIdx].Length)
        //            {
        //                continue;
        //            }

        //            int count = 0, exceptChr = 0;
        //            string comparePart = group[0];

        //            for (int ch = 0; ch < strsData[wordIdx].Length; ch++)
        //            {
        //                if (comparePart.Contains(strsData[wordIdx][ch]))
        //                {
        //                    exceptChr = comparePart.IndexOf(strsData[wordIdx][ch]);

        //                    if (exceptChr + 1 == comparePart.Length)
        //                    {
        //                        comparePart = comparePart.Substring(0, exceptChr);
        //                    }
        //                    else
        //                    {
        //                        comparePart = comparePart.Substring(0, exceptChr) + comparePart.Substring(exceptChr + 1);
        //                    }

        //                    //comparePart.RemoveAll()
        //                    count++;

        //                }
        //            }

        //            if(count == strsData[wordIdx].Length)
        //            {
        //                group.Add(strsData[wordIdx]);
        //                strsData.Remove(strsData[wordIdx]);
        //                wordIdx--;
        //            }
        //        }

        //        anagramsData.Add(group);
        //    }


        //    return anagramsData;
        //}



        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach(string word in strs)
            {

                char[] countChrs = new char[26];
                foreach(char ch in word)
                {
                    countChrs[ch - 'a']++;
                }

                var key = new string(countChrs);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }
                map[key].Add(word);

            }

            return map.Values.ToList<IList<string>>();
        }


        // 27. Remove Element
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int length = nums.Length;
            for(int i = 0; i<length; i++)
            {
                if (nums[i] != val)
                {
                    k++;
                }
                else
                {
                    int temp = nums[i];
                    nums[i] = nums[length - 1];
                    nums[length - 1] = temp;
                    length--;
                    i--;
                }

                
            }

            return k;
        }


        // 169. Majority Element
        //public static int MajorityElement(int[] nums)
        //{
        //    Dictionary<int, int> occurences = new Dictionary<int, int>(); // 6, 5, 5

        //    for(int i =0; i<nums.Length; i++)
        //    {
        //        if (!occurences.ContainsKey(nums[i]))
        //        {
        //            occurences[nums[i]] = 1;
        //        }
        //        else
        //        {
        //            occurences[nums[i]]++;
        //        }
        //    }

        //    foreach(var val in occurences)
        //    {
        //        if(val.Value >= (nums.Length / 2) + 1)
        //        {
        //            return val.Key;
        //        }
        //    }

        //    return 0;
        //}



        public static int MajorityElement(int[] nums)
        {
            int commonNum = 0;
            int commonCount = 0;

            for(int i=0; i<nums.Length; i++)
            {
                if (commonCount == 0)
                {
                    commonNum = nums[i];
                }

                if(commonNum == nums[i])
                {
                    commonCount++;
                }
                else
                {
                    commonCount--;
                }
            }

            return commonNum;
        }


        // 912. Sort an Array
        public int[] SortArray(int[] nums)
        {
            for(int i =0; i< nums.Length; i++)
            {

            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(1, 1); // The map is now [[1,1]]
            myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
            Console.WriteLine(myHashMap.Get(1));    // return 1, The map is now [[1,1], [2,2]]
            Console.WriteLine(myHashMap.Get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            Console.WriteLine(myHashMap.Get(2));    // return 1, The map is now [[1,1], [2,1]]
            myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
            Console.WriteLine(myHashMap.Get(2));    // return -1 (i.e., not found), The map is now [[1,1]]


            //Console.WriteLine(MajorityElement([6,5,5]));



            Console.ReadKey();
        }
    }
}
