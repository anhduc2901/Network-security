using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            // IP là địa chỉ mà client connect đến
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            //                              CLIENT 
            // AddressFamily.InterNetwork : trả về họ của ip hiện hành cụ thể ở đây là Ipv4 
            // SocketType.Stream          : Kiểu kết nối Socket , ở đây dùng luồng stream để nhận dữ liệu
            // ProtocolType.IP            : kiểu kết nối 
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            //Bắt đầu kết nối
            //Dùng try catch để báo lỗi kết nối
            try
            {
                client.Connect(IP);
            }
            catch 
            {

                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }
        void Close()
        {
            client.Close();
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    //tạo mảng 1 byte để lưu dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    // nhận data từ Socket và lưu vào buffer "data"
                    client.Receive(data);
                    //Gom mảnh data sang dạng string
                    string msg = (string)Deserialize(data);
                    AddMessage(msg);
               }
            }
            catch 
            {
                Close();
            }
          
        }       
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage2.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            
        }
        //Gửi dữ liệu
        void Send()
        {
            // txbMessgae khác rỗng ms gửi
            if(txbMessage2.Text!=string.Empty)
            {
                client.Send(Serialize(txbName.Text + " : " + txbMessage2.Text));
            }
        }
        object Deserialize(byte[] data)
        {
            //Khởi tạo stream để lưu trữ mảng byte
            MemoryStream stream = new MemoryStream(data);
            // Khởi tạo đổi tượng để chuyển đổi
            BinaryFormatter bf = new BinaryFormatter();
            //Chuyển đổi và return lại dữ liệu
            return bf.Deserialize(stream);
        }
        byte[] Serialize(object obj)
        {
            //Khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //Khởi tạo đổi tượng để phân mảnh
            BinaryFormatter bf = new BinaryFormatter();
            //Phân mảnh 1 object và lưu nó lại dưới 1 mảng byte và lưu vào "stream"
            bf.Serialize(stream, obj); 
            //Trả về kết quả là 1 mảng byte để chuẩn bị gửi đi
            return stream.ToArray();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
        

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string message = txbMessage.Text;
            string key = txbKey_encrypt.Text;

            // Create sha256 hash
            // Tạo hàm băm password thành 256 bit : 32 byte
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] key2 = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(txbKey_encrypt.Text));

            //Mã hóa và lưu ciphertext vào (encrypted)
            string encrypted = this.EncryptString2(message, key2, iv);
            //Hiện ra màn hình
            txbCiphertex.Text = encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            
                // Create sha256 hash
                // Tạo hàm băm password thành 256 bit : 32 byte
                SHA256 mySHA256 = SHA256Managed.Create();
                try
                {
                    byte[] key2 = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(txbKey_decrypt.Text));
                    // Giải mã
                    string decrypted = this.DecryptString2(txbCipher2.Text, key2, iv);

                    // Hiển thị
                    txbPlaintext.Text = decrypted;
                }
                catch (Exception)
                {

                    MessageBox.Show("Bạn chưa nhập key để giải mã !");
                }


            

        }
        
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public string EncryptString2(string plainText, byte[] key, byte[] iv)
        {

            // Khởi tạo một đối tượng Aes mới để thực hiện mã hóa chuỗi đối xứng 
            // Là một đối tượng cryptographic (encryptor) được sử dụng để thực hiện thuật toán đối xứng
            Aes encryptor = Aes.Create();

            // Mode để mã hóa khối là (CBC)

            //Trước khi mỗi khối văn bản thuần túy được mã hóa,
            //nó được kết hợp với văn bản mã hóa của khối trước đó bằng một phép toán OR độc quyền theo bit.
            //Điều này đảm bảo rằng ngay cả khi văn bản thuần túy chứa nhiều khối giống nhau,
            //chúng sẽ mã hóa mỗi khối thành một khối văn bản mật mã khác nhau.
            //Vectơ khởi tạo được kết hợp với khối văn bản thuần túy đầu tiên bằng phép toán OR độc quyền theo bit
            //trước khi khối được mã hóa. Nếu một bit của khối văn bản mật mã bị thay đổi, khối văn bản thuần tương ứng
            //cũng sẽ bị thay đổi. 
            encryptor.Mode = CipherMode.CBC;

            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Cài đặt khóa và instance vector

            // IV là một số tùy ý có thể được sử dụng cùng với khóa bí mật để mã hóa dữ liệu.
            // Là đầu vào cho 1 mật mã để thêm sự ngẫu nhiên tránh các attacker suy ra mối quan hệ giữa
            // các đoạn tin nhắn đc mã hóa
            // Nếu bạn không có IV, thì hai tệp bắt đầu bằng văn bản giống hệt nhau sẽ tạo ra các khối đầu
            // tiên giống hệt nhau
            // attacker sẽ biết tệp bản rõ bắt đầu bằng gì và bản mã tương ứng của nó là gì
            // =>có thể  xác định khóa và sau đó giải mã toàn bộ tệp.
            encryptor.Key = key;
            encryptor.IV = iv;

            // Khởi tạo một đối tượng MemoryStream  để chứa các byte được mã hóa
            MemoryStream memoryStream = new MemoryStream();

            // Khởi tạo trình mã hóa  từ đối tượng Aes  (encryptor)
            // Tạo đối tượng mã hóa bất đối xứng        (aesEncryptor)
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Khởi tạo một đối tượng (CryptoStream)  để xử lý dữ liệu và ghi nó vào luồng             
            // Dữ liệu đc encrypt sẽ lưu vào (memoryStream)
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Chuyển chuỗi plaintext (plainText) thành một mảng byte (plainBytes)
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Mã hóa plaintext 
            // ciphertext đc (cryptoStream) ghi vào (memoryStream)
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Hoàn tất quá trình mã hóa
            //cập nhật nguồn dữ liệu cơ bản với trạng thái hiện tại của bộ đệm, sau đó xóa bộ đệm.
            cryptoStream.FlushFinalBlock();

            // Chuyển đổi dữ liệu được mã hóa từ (memoryStream) thành mảng byte
            byte[] cipherBytes = memoryStream.ToArray();

            // Đóng MemoryStream và CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Chuyển đổi mảng byte được mã hóa thành string    
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Trả về dữ liệu được mã hóa dưới dạng chuỗi
            return cipherText;
        }

        public string DecryptString2(string cipherText, byte[] key, byte[] iv)
        {
            // Khởi tạo một đối tượng Aes mới để thực hiện  giải mã 
            // Tạo một đối tượng cryptographic (decryptor) được sử dụng để thực hiện thuật toán đối xứng
            Aes decryptor = Aes.Create();

            decryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Cài đặt khóa và instance vector
            decryptor.Key = key;
            decryptor.IV = iv;

            // Khởi tạo một đối tượng MemoryStream  để chứa các byte được giải mã
            MemoryStream memoryStream = new MemoryStream();

            // Khởi tạo trình mã hóa  từ đối tượng Aes  (decryptor)
            // Tạo đối tượng mã hóa bất đối xứng        (aesDecryptor)
            ICryptoTransform aesDecryptor = decryptor.CreateDecryptor();

            // Khởi tạo một đối tượng (CryptoStream)  để xử lý dữ liệu và ghi nó vào luồng             
            // Dữ liệu đc encrypt sẽ lưu vào (memoryStream)      
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // string này sẽ chứa văn bản được giải mã (plainText)
            string plainText = String.Empty;

            try
            {
                //  Chuyển chuỗi ciphertext thành mảng byte (cipherBytes)
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Giải mã string ciphertext đc truyền vào
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Hoàn thành giải mã
                cryptoStream.FlushFinalBlock();

                // Chuyển đổi dữ liệu đc giải mã đc lưu trong (memoryStream) sang mảng byte (plainBytes)
                byte[] plainBytes = memoryStream.ToArray();

                // Chuyển đổi mảng byte đó sang string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Đóng MemoryStream và CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Trả về bản rõ ban đầu
            return plainText;
        }
    }
}
