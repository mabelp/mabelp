using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace MabelpTools.Common
{
    public class DeflateHelper
    {
        /// <summary>
        /// 对字符串进行压缩
        /// </summary>
        /// <param name="str">待压缩的字符串</param>
        /// <returns>压缩后的字符串</returns>
        public static string CompressString(string str)
        {
            var compressString = string.Empty;
            byte[] compressBeforeByte = Encoding.UTF8.GetBytes(str);
            byte[] compressAfterByte = CompressBytes(compressBeforeByte);

            compressString = Convert.ToBase64String(compressAfterByte);
            return CompressStringReplace(compressString);
        }

        /// <summary>
        /// 对字符串进行解压缩
        /// </summary>
        /// <param name="str">待解压缩的字符串</param>
        /// <returns>解压缩后的字符串</returns>
        public static string DecompressString(string str)
        {
            var decompressString = string.Empty;
            str = DecompressStringReplace(str);
            byte[] compressBeforeByte = Convert.FromBase64String(str);
            byte[] compressAfterByte = DecompressBytes(compressBeforeByte);
            decompressString = Encoding.UTF8.GetString(compressAfterByte);
            return decompressString;
        }
        /// <summary>  
        /// 压缩二进制  
        /// </summary>  
        /// <param name="str"></param>  
        /// <returns></returns>  
        public static byte[] CompressBytes(byte[] str)
        {
            var ms = new MemoryStream(str) { Position = 0 };
            var outms = new MemoryStream();
            using (var deflateStream = new DeflateStream(outms, CompressionMode.Compress, true))
            {
                var buf = new byte[1024];
                int len;
                while ((len = ms.Read(buf, 0, buf.Length)) > 0)
                    deflateStream.Write(buf, 0, len);
            }
            return outms.ToArray();
        }
        /// <summary>  
        /// 解压二进制  
        /// </summary>  
        /// <param name="str"></param>  
        /// <returns></returns>  
        public static byte[] DecompressBytes(byte[] str)
        {
            var ms = new MemoryStream(str) { Position = 0 };
            var outms = new MemoryStream();
            using (var deflateStream = new DeflateStream(ms, CompressionMode.Decompress, true))
            {
                var buf = new byte[1024];
                int len;
                while ((len = deflateStream.Read(buf, 0, buf.Length)) > 0)
                    outms.Write(buf, 0, len);
            }
            return outms.ToArray();
        }

        private static string CompressStringReplace(string compressString)
        {
            return compressString.Replace('+', '*').Replace('/', '^').Replace('=', '.').Replace(' ', '~');
        }

        private static string DecompressStringReplace(string decompressString)
        {
            return decompressString.Replace('*', '+').Replace('^', '/').Replace('.', '=').Replace('~', ' ');
        }
    }
}
