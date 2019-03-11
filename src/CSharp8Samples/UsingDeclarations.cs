using System;
using System.IO;

namespace CSharp8
{
    public class UsingDeclarations
    {
        public void ProcessFile()
        {
            var fileName = "TestFile.txt";

            using var reader = File.OpenText(fileName);

            // ...

            Console.WriteLine(reader.ReadToEnd());

            // ...

            // disposed here
        }

        // Alternative
        public void ProcessFileOld()
        {
            var fileName = "TestFile.txt";

            using (var reader = File.OpenText(fileName))
            {
                // ...

                Console.WriteLine(reader.ReadToEnd());

                // ...
            }
        }
    }
}
