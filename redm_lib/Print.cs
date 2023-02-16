using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace RedLib
{
    /// <summary>
    /// Console Print's
    /// </summary>
    public static class Print
    {
        public static string SuccessPrefix = "^2 ~  ";
        public static void Success(string S)
        {
            Debug.WriteLine($"{SuccessPrefix}{S}^0");
        }
        public static string LogPrefix = "^5 *  ";
        public static void Log(string S)
        {
            Debug.WriteLine($"{LogPrefix}{S}^0");
        }
        public static string WarnPrefix = "^3 ¤  ";
        public static void Warn(string S)
        {
            Debug.WriteLine($"{WarnPrefix}{S}^0");
        }
        public static string ErrorPrefix = "^1 #  ";
        public static void Error(string S)
        {
            Debug.WriteLine($"{ErrorPrefix}{S}^0");
        }
    }
}
