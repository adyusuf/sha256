using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace sha256
{
    public partial class Form1 : Form
    {

        MemoryStream ms = new MemoryStream();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(lblInt2, lblHex2, lblTime2, lblAvg2, lblHash2);
        }

        private string GetRandom()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();


            var byteArray2 = new byte[8];
            provider.GetBytes(byteArray2);
            
            var random64 = BitConverter.ToInt64(byteArray2, 0);

            return random64.ToString("x16");
        }

        private void Calculate(Label _lblInt, Label _lblHex, Label _lblTime, Label _lblAvg, Label _lblHash)
        {
            var i = 0;
            var secs = 0.0;
            var start = DateTime.Now;
            var hash = "";
            var strm = new MemoryStream();
            var max = Convert.ToInt64(txtCount.Text);


            //FileStream fs = File.Open("c:\\temp\\all." + DateTime.Now.ToString("yyyyMMddHHmmss.fffffff") + ".txt", FileMode.OpenOrCreate);
            //FileStream fs1 = File.Open("c:\\temp\\txt." + DateTime.Now.ToString("yyyyMMddHHmmss.fffffff") + ".txt", FileMode.OpenOrCreate);
            FileStream fs2 = File.Open("c:\\temp\\hash." + DateTime.Now.ToString("yyyyMMddHHmmss.fffffff") + ".txt", FileMode.OpenOrCreate);


            for (; i < max * 1000;)
            {
                var hex = GetRandom();
                hash = ComputeSha256Hash(hex);

                //byte[] buffer = Encoding.UTF8.GetBytes(hex + ":" + hash + Environment.NewLine);
                //fs.Write(buffer, 0, buffer.Length);
                //byte[] buffer1 = Encoding.UTF8.GetBytes(hex + Environment.NewLine);
                //fs1.Write(buffer1, 0, buffer1.Length);
                byte[] buffer2 = Encoding.UTF8.GetBytes(hash + Environment.NewLine);
                fs2.Write(buffer2, 0, buffer2.Length);
                i++;

                if (i % 100000 == 0)
                {
                    secs = (DateTime.Now - start).TotalMilliseconds / 1000;
                    _lblInt.Text = i.ToString("###,##0");
                    _lblHex.Text = hex;
                    _lblTime.Text = secs.ToString("###,##0.0###");
                    _lblAvg.Text = (i / secs).ToString("###,##0.0###");
                    _lblHash.Text = hash;
                    Refresh();
                }
                Application.DoEvents();
            }

            //fs.Close();
            //fs1.Close();
            fs2.Close();
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
