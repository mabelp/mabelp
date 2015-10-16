using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Reflection;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Xml;
using System.Xml.Serialization;
using Package.Framework2.Caching.RuntimeCache;
using System.Linq;
using System.Collections.Specialized;
using Arch.Framework.Utility;

namespace MabelpTools.Common
{
    public static class CommonFunc
    {
        /// <summary>
        /// 将对象序列化为XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serializer<T>(object obj)
        {
            var str = string.Empty;
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (var ms = new System.IO.MemoryStream())
            {
                xmlSerializer.Serialize(ms, obj);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                using (var sr = new System.IO.StreamReader(ms, Encoding.UTF8))
                {
                    str = sr.ReadToEnd();
                }
            }
            return str;
        }

        /// <summary>
        /// 将对象序列化为Protobuf
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ProtBufSerializer(object obj)
        {
            var str = string.Empty;
            using (var ms = new System.IO.MemoryStream())
            {
                ProtoBuf.Serializer.NonGeneric.Serialize(ms, obj);
                str = Convert.ToBase64String(ms.ToArray());
            }
            return str;
        }

        /// <summary>
        /// 将Protobuf反序列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ProtBufDeSerializer<T>(string protobufString) where T : new()
        {
            T t = new T();
            if (!string.IsNullOrEmpty(protobufString))
            {
                byte[] bytes = Convert.FromBase64String(protobufString);
                using (System.IO.MemoryStream stream = new System.IO.MemoryStream(bytes))
                {
                    var obj = ProtoBuf.Serializer.NonGeneric.Deserialize(typeof(T), stream);
                    if (obj != null)
                    {
                        t = (T)Convert.ChangeType(obj, typeof(T));
                    }
                }
            }
            return t;
        }     
       
    }
}
