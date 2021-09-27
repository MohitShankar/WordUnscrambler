using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
           
            string[] Splitter(string input)
            {
                return Regex.Split(input, @"\W+");
            }
            //Creates Arraylist to store value from File.txt into an Array.
            List<String[]> arrayList = new List<String[]>();

            //fStream (attribute of name FileStream) will open and read file store in the following path position.
            using (FileStream fStream = File.OpenRead(@" C: \Users\IT\Documents\.net programming\Lab2\wordlist.txt"))
            using (TextReader reader = new StreamReader(fStream))
            {
                //empty string called line
                string line = "";
                //Shows if string is empty or null
                while (!String.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    arrayList.Add(Splitter(line));
                }
            }

            return null;
        }
    }
}

