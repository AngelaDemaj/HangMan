using System.IO;

namespace HangMan.Helpers
{
    static class Reader
    {
        public static string[] Words =
            File.ReadAllLines(@"..\\..\\..\\Resources\\Words.txt");
    }
}
