using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BGUFS
{
    class BGUFS
    {
        static void Main(string[] args)
        {
            String Argument0 = "-create";
            String Argument1 = "hello";
            String Argument2 = "File needed to be linked";
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

        FileSystem getFileSystemFromFile(String fileName)
        {
            byte[] readFromFile;
            readFromFile = File.ReadAllBytes(fileName);
            FileSystem fs = (FileSystem)ByteArrayToObject(readFromFile);
            return fs;

        }

        private Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }


    }
}
