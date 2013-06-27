using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResourceManagementSystem
{
    class GlobalClass
    {
        internal static string EmpID;
        internal static string conn;
        internal static string hostIP;
        internal static HRDepartment hrd;
        static GlobalClass()
        {


            GlobalClass.hostIP = "";

        }
    }
}
