using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace bai4
{
    public partial class Server : Form
    {

        public Server()
        {
            InitializeComponent();
            // tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            CheckForIllegalCrossThreadCalls = false;
            AddMessage("Server running on 127.0.0.1 : 8080");
            Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        IPEndPoint IP;
        Socket server;

        //khai báo 1 list các client
        List<Socket> clientList;
        //kết nối đến server
        void Connect()
        {
            //khởi tạo 1 list nhiều client
            clientList = new List<Socket>();
            //khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //lấy IPEndPoint làm interfaces và đợi kết nối từ client
            server.Bind(IP);
            //tạo 1 luồng lăng nghe từ client
            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        //Cho lắng nghe tầm 100 thằng client (đặt Socket ở trạng thái lắng nghe)
                        // 100  : Độ dài tối đa của hàng đợi kết nối đang chờ xử lý
                        server.Listen(100);
                        Socket client = server.Accept();//nếu lắng nghe thành công thì server chấp nhận kết nối
                        AddMessage("New client connected from : " + client.RemoteEndPoint);//Hiện thông báo có client kết nối vào
                        clientList.Add(client);//thêm các client được server accept vào list

                        //tạo luồng nhận thông tin từ client
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                /*khi kết nối đến n client mà có 1 client disconnect thì server sẽ chạy vòng lặp while liên tục để
                 chương trình ko bị crash*/
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        //đóng kết nối đến server
        void Close()
        {
            server.Close();
        }

        //gửi dữ liệu
        void Send(Socket client)
        {
            //nếu textbox khác rỗng thì mới gửi tin
            if ((client != null) && (txbMessage.Text != string.Empty))
            {
                client.Send(Serialize(txbMessage.Text));
            }
        }

        //nhận dữ liệu
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    //khởi tạo mảng byte để nhận dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deserialize(data);

                    //khi 1 client gửi thì cả server và các client khác cùng nhận đc
                    foreach (Socket item in clientList)
                    {
                        if (item != null)
                        {
                            item.Send(Serialize(message));
                        }
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                //bị gì thì cho thằng client này đi luôn
                clientList.Remove(client);
                client.Close();
            }
        }

        //add mesage vào khung chat
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
        }

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deserialize(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
        }
        //gửi tin cho nhiều client
      

        private void button1_Click(object sender, EventArgs e)
        {
            //Gửi đến mấy thằng client
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            AddMessage(txbMessage.Text);
            txbMessage.Clear();
        }
    }
}
