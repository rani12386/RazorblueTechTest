namespace RazorblueTechTest.Anagram
{
    public static class Anagram
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            var s1Array = str1.ToLower().ToCharArray();
            var s2Array = str2.ToLower().ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            str1 = new string(s1Array);
            str2 = new string(s2Array);

            return str1 == str2;
        }
    }
}
