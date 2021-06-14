using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BGUFS
{
    class FileSystem
    {
        private FileObject[] Header;
        private Byte[] Content;
        private String Name;
        private int HeaderNextIndex;
        private int ContentNextIndex;


        public FileSystem(String name)
        {
            this.Name = name;
            this.Header = new FileObject[1000];
            this.Content = new byte[1000000];
            this.HeaderNextIndex = 0;
            this.ContentNextIndex = 0;
        }

        public bool addFile(String fileName)
        {
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i].getFileName().Equals(fileName))
                {
                    return false;
                }
            }
            Byte[] newFileBytes = File.ReadAllBytes(fileName);
            FileObject f = new FileObject(fileName);
            f.setLength(newFileBytes.Length);
            f.setLocation(ContentNextIndex);
            Header[HeaderNextIndex] = f;
            HeaderNextIndex++;
            if (ContentNextIndex + newFileBytes.Length > Content.Length)
            {
                Byte[] temp2 = new byte[Content.Length + newFileBytes.Length];
                for (int i = 0; i < Content.Length; i++)
                {
                    temp2[i] = Content[i];
                }
                Content = temp2;

            }

            for (int i = 0; i < newFileBytes.Length; i++)
            {
                Content[ContentNextIndex] = newFileBytes[i];
                ContentNextIndex++;
            }
            return true;
        }

        public bool removeFile(String fileName)
        {
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i].getFileName().Equals(fileName) && !Header[i].IsDeleted())
                {
                    Header[i].delete();
                    return true;
                }
            }
            return false;
        }

        public bool rename(String fileName, String NewFileName)
        {
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i].getFileName().Equals(fileName) && !Header[i].IsDeleted())
                {
                    Header[i].setFileName(NewFileName);
                    return true;
                }
            }
            return false;
        }

        public bool extract(String fileName, String extractedFileName)
        {
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i].getFileName().Equals(fileName) && !Header[i].IsDeleted())
                {
                    Byte[] bytes = File.ReadAllBytes(fileName);
                    File.WriteAllBytes(extractedFileName, bytes);
                    return true;
                }
            }
            return false;
        }

        public String dir()
        {
            String str = "";
            for (int i = 0; i < Header.Length; i++)
            {
                str += Header[i].getFileName();
                str += ",";
                str += Header[i].getLength();
                str += ",";
                str += Header[i].getDateAndTime().ToString();
                str += "regular"; //need to add link
                str += "\n";
            }
            return str;
        }

        public String hash(String fileName)
        {
            String str = "";
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i].getFileName().Equals(fileName) && !Header[i].IsDeleted())
                {
                    str = checkMD5(fileName);
                    return str;
                }

            }
            return null;
        }






        private string checkMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return Encoding.Default.GetString(md5.ComputeHash(stream));
                }
            }
        }

       
    }
}
