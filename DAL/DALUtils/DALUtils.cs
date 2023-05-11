using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUtils
{
    public class DALUtils
    {
        public string ReplaceWithCurrentLocation(string connStr)
        {
            string str = AppDomain.CurrentDomain.BaseDirectory;
            string directryAboveBin = str.Substring(0, str.IndexOf("\\bin"));
            string twoDirectoriesAboveBin = directryAboveBin.Substring(0, directryAboveBin.LastIndexOf("\\"));
            connStr = string.Format(connStr, twoDirectoriesAboveBin);
            return connStr;
        }
    }
}
