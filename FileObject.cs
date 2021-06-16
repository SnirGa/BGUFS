using System;
using  System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BGUFS
{
    class FileObject
    {
        public int location { get; set; } 
        public int length { get; set; }
        public String fileName { get; set; }
    public DateTime dateAndTime { get; set; }
        public bool isDeleted { get; set; }
        public String type { get; set; }


        public FileObject(String fn,String typeFile)
        {
            this.location = -1;
            this.length = -1;
            this.fileName = fn;
            FileInfo fi = new FileInfo(fn);
            this.dateAndTime =fi.CreationTime;
            this.type = typeFile;
        }

       

        public int getLocation()
        {
            return this.location;
        }

        public void setLocation(int loc)
        {
            this.location = loc;
        }

        public int getLength()
        {
            return this.length;
        }

        public void setLength(int len)
        {
            this.length = len;
        }

        public String getFileName()
        {
            return this.fileName;
        }

        public void setFileName(String name)
        {
            this.fileName = name;
        }

        public DateTime getDateAndTime()
        {
            return this.dateAndTime;
        }

        public void setDateAndTime(DateTime timeAndDate)
        {
            this.dateAndTime = timeAndDate;
        }

        public bool IsDeleted()
        {
            return this.isDeleted;
        }

        public void delete()
        {
            this.isDeleted = true;
        }

        public String getFileType()
        {
            return type;
        }

        /*public Byte[] serialize()
        {
            String output = JsonConvert.SerializeObject(this);
            Console.WriteLine(output);
            Byte[] byteOutput = Convert.FromBase64String(output);
            return byteOutput; 
        }*/

        

    }



}
