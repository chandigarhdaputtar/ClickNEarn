using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiler
{
    public static class MethodProfile
    {
        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            
            return sf.GetMethod().Name;
        }

        public static string GetFileName()
        {
            string thisFile = new StackTrace().GetFrame(1).GetFileName();
            var files = thisFile.Split('\\');
            string fileName =  files[files.Length - 1];
            return fileName;
        }

        public static string GetProjectName()
        {
            var stack = new StackTrace();//.GetFrame(1).GetFileName();
            stack.GetFrame(1);
            //var files = thisFile.Split('\\');
            //var projectName =  files[files.Length - 2];
            //return projectName;
            return null;
        }

        public static string GetClassName(object obj)
        {
            string type = obj.GetType().Name;
            return type;
        }

        public static void Profile(string projectName,string fileName,string MethodName,Stopwatch st)
        {
            var t = st.Elapsed;
            //log sw.Elapsed;
            using (StreamWriter sw = File.AppendText(@"D:\logs.txt"))
            {
                sw.WriteLine(projectName+" ----- "+fileName+" ----- "+/*className+" ----- "+*/ MethodName + " ----- "+ t);
                sw.WriteLine();                
            }
        }

    }
}
