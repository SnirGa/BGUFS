using System;
using System.Collections.Generic;

namespace BGUFS
{
    class BGUFS
    {
        static void Main(string[] args)
        {
            String Argument0 = "-create";
            String Argument1 = "hello";
            List<FileSystem> FSList = new List<FileSystem>();

            switch (Argument0)
            {

                case "-create":

                    FileSystem fileSystem = new FileSystem(Argument1);
                    FSList.Add(fileSystem);
                    Console.WriteLine("hello");
                    break;
            }
        }
    }
}
