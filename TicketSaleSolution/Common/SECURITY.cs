using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace COM
{
    public class SECURITY
    {
        public static string STRING_TO_MD5(string ClearText)
        {

            byte[] ByteData = Encoding.ASCII.GetBytes(ClearText);
            //MD5 creating MD5 object.
            MD5 oMd5 = MD5.Create();
            //Hash değerini hesaplayalım.
            byte[] HashData = oMd5.ComputeHash(ByteData);

            //convert byte array to hex format
            StringBuilder oSb = new StringBuilder();

            for (int x = 0; x < HashData.Length; x++)
            {
                //hexadecimal string value
                oSb.Append(HashData[x].ToString("x2"));
            }
            return oSb.ToString();
        }
    }
}
