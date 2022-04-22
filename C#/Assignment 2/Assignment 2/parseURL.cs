using System;
using System.Text.RegularExpressions;

public class ParseURL
{
   public static void Main()
   {
      string url = "https://www.apple.com/iphone";

      Regex r = new Regex(@"^(?<protocol>\w+)://[^/]+?//(?<server>)?/(?<resource>)?/",
                          RegexOptions.None, TimeSpan.FromMilliseconds(150));
      Match m = r.Match(url);
      if (m.Success)
         Console.WriteLine(m.Result("${protocol}${server}${resource}"));
   }
}