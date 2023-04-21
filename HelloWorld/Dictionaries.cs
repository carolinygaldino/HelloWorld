
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<string, string>
            myDict = new System.Collections.Generic.Dictionary<string, string>();
            myDict.Add("Jim", "07892 123 123");
            myDict.Add("tim", "07892 123 123");
            myDict.Add("bim", "07892 123 123");
            myDict.Add("lim", "07892 123 123");
            myDict.Add("gim", "07892 123 123");
            myDict["gim"] = "gim's new number";
            foreach (System.Collections.Generic.KeyValuePair<string, string> el in myDict)

            System.Console.WriteLine(el);


        }
    }
}
