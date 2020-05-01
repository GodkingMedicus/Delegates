using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace FileParser {
    public class FileHandler {
       
        public FileHandler() { }

        /// <summary>
        /// Reads a file returning each line in a list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<string> ReadFile(string filePath) {
            List<string> lines = new List<string>();
            string line;

            using(StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            
            return lines; //-- return result here
        }

        
        /// <summary>
        /// Takes a list of a list of data.  Writes to file, using delimeter to seperate data.  Always overwrites.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimeter"></param>
        /// <param name="rows"></param>
        public void WriteFile(string filePath, char delimeter, List<List<string>> rows) {

            using(StreamWriter file = new StreamWriter(filePath))
            {
                foreach(List<string> row in rows)
                {
                    file.WriteLine(String.Join(delimeter.ToString(), row));
                }
            }
        }
        
        /// <summary>
        /// Takes a list of strings and seperates based on delimeter.  Returns a list of a list of strings seperated by delimeter.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public List<List<string>> ParseData(List<string> data, char delimiter) {
            List<List<string>> result = new List<List<string>>();
            List<string> temp = new List<string>();

            foreach (string line in data)
            {
                string[] splitLine = line.Split(delimiter);
                temp = new List<string>();

                foreach (string splitData in splitLine)
                {
                    temp.Add(splitData);
                }
                result.Add(temp);
            }

            return result; //-- return result here
        }
        
        /// <summary>
        /// Takes a list of strings and seperates on comma.  Returns list of list of strings seperated by comma.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> ParseCsv(List<string> data) {

            return ParseData(data, ',');
            //return new List<List<string>>();  //-- return result here
        }
    }
}