﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTools.CShape
{
    public class IRepository
    {
        private static string template = Util.IOHelper.FileRead(String.Format("{0}\\Template\\{1}", System.Environment.CurrentDirectory, "CIRepository.tml"));
        public static String Genrate(String nameSpace, String className)
        {
            return template.Replace("$namespace$", nameSpace).Replace("$classname$", className);

        }
    }
}
