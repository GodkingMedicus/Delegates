using System.Collections.Generic;

namespace FileParser {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {

            List<List<string>> result = new List<List<string>>();
            List<string> temp = new List<string>();

            foreach (List<string> line in data)
            {
                temp = new List<string>();
                foreach (string var in line)
                {
                    temp.Add(var.Trim());
                }
                result.Add(temp);
            }

            return result; //-- return result here
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {

            List<List<string>> result = new List<List<string>>();
            List<string> temp = new List<string>();

            foreach (List<string> line in data)
            {
                temp = new List<string>();
                foreach (string var in line)
                {
                    temp.Add(var.Trim('"'));
                }
                result.Add(temp);
            }
            
            return result; //-- return result here
        }

    }
}