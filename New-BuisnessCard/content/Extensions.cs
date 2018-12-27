using System.Text;

namespace content
{
    public static class Extensions
    {
        public static string Repeat(this string s, int n)
        {
            return new StringBuilder(s.Length * n)
                        .AppendJoin(s, new string[n+1])
                        .ToString();
        }
    }
}