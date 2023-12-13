using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 服务端
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UdpClient udpClient;
        private const int listenPort = 11000;

        public MainWindow()
        {
            InitializeComponent();
            udpClient = new UdpClient(11001); // 监听端口11001
            Task.Run(() => ListenForMessages());
        }


        private void ListenForMessages()
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 11001);
                while (true)
                {
                    byte[] bytes = udpClient.Receive(ref remoteEP);
                    string receivedData = Encoding.UTF8.GetString(bytes); // 使用UTF-8解码

                    // 使用UI线程
                    Dispatcher.Invoke(() =>
                    {
                        // 更新UI显示接收到的消息
                        messagesTextBox.Text += receivedData + Environment.NewLine;
                    });
                }
            }
            catch (Exception ex)
            {
                // 处理异常
            }
        }

    }
}
