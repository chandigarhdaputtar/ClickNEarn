using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class AccountHelper
    {
        public static SecureString ToSecureString(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            SecureString ss = new SecureString();
            foreach (var character in input)
            {
                ss.AppendChar(character);
            }
            return ss;
        }
        public static string ToNormalString(this SecureString input)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(input);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
    }
}
