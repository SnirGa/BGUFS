using System;
using  System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGUFS
{
    class FileObject
    {
        private int location;
        private int length;
        private String fileName;
        private DateTime dateAndTime;
        bool isDeleted;
        String type;
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

    }



}
