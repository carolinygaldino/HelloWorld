namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = { 12, 23, 34, 25, 56 };
            myIntArray[2] = 1234;
            System.Collections.Generic.List<int>
            myList = new System.Collections.Generic.List<int>(myIntArray);
            myList.Add(4567);
            myList[0] = 9876;

            foreach (int element in myList)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}
