using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MabelpTools.Common;
using DIY.Product.FlightServices.Contract;
using Newtonsoft.Json;
using Ctrip.SOA.Comm;
using System.Web;
using Package.Tour.ShoppingService.Contract;
using MabelpTools.Entity;

namespace MabelpTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string ccc = EncryManager.DecryFromString(TmpOrderID);
        }

        private void btnProtobuf_Click(object sender, EventArgs e)
        {
            if (ProtobufType.Text == "CanBooking")
                SetProBufReturn<OrderCanBookingResponse>();
            else if (ProtobufType.Text == "ResourceSearch")
                SetProBufReturn<ResourceSearchResponse>();
            else if (ProtobufType.Text == "FlightMarkInfo")
                SetProBufReturn<FlightMarkInfoDTO>();
            else if (ProtobufType.Text == "CheckHotel")
                SetProBufReturn<List<CheckHotel>>();
            else
            { 
            
            }
        }

        public void SetProBufReturn<T>() where T : new()
        {
            T t = new T();
            t = CommonFunc.ProtBufDeSerializer<T>(chkCompress.Checked ? DeflateHelper.DecompressString(this.txtProtobufTarget.Text) : this.txtProtobufTarget.Text);
            if(ProbufResultFormat.Text.ToUpper() == "JSON")
                this.txtResult.Text = JsonConvert.SerializeObject(t);
            else if (ProbufResultFormat.Text.ToUpper() == "XML")
                this.txtResult.Text = XMLSerializer.Serialize(t, typeof(T));
            else
            { 
            
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProbufResultFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ///// <summary>
        ///// 解密
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="source"></param>
        ///// <returns></returns>
        //public static string DecryFromString<T>(T source)
        //{
        //    string returnStr = string.Empty;
        //    string key = source.ToString();
        //    returnStr = Decrypto(HttpUtility.UrlDecode(key));
        //    return returnStr;
        //}

        ///// <summary>   
        ///// 解密方法   
        ///// </summary>   
        ///// <param name="Source">待解密的串</param>   
        ///// <returns>经过解密的串</returns>   
        //public string Decrypto<T>(T Source)
        //{
        //    string rtnStr = string.Empty;
        //    MemoryStream ms = null;
        //    ICryptoTransform encrypto = null;
        //    CryptoStream cs = null;
        //    StreamReader sr = null;
        //    try
        //    {
        //        byte[] bytIn = Convert.FromBase64String(Source.ToString().Replace(" ", "+"));
        //        ms = new MemoryStream(bytIn, 0, bytIn.Length);
        //        mobjCryptoService.Key = GetLegalKey();
        //        mobjCryptoService.IV = GetLegalIV();
        //        encrypto = mobjCryptoService.CreateDecryptor();
        //        cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
        //        sr = new StreamReader(cs);
        //        rtnStr = sr.ReadToEnd();
        //    }
        //    catch
        //    {
        //        throw new DecrypException();
        //    }
        //    finally
        //    {
        //        if (encrypto != null) encrypto.Dispose();
        //        if (ms != null) ms.Close();
        //        if (cs != null) cs.Close();
        //        if (sr != null) cs.Close();
        //    }
        //    return rtnStr;
        //}

    }
}
