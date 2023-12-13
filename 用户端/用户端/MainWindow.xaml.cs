using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

namespace 用户端
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

            udpClient = new UdpClient(listenPort);
            
        }

        // 发送按钮的点击事件处理
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string message = messageTextBox.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(message); // 使用UTF-8编码
                udpClient.Send(bytes, bytes.Length, "127.0.0.1", 11001);
                // 更新UI或记录状态
            }
            catch (Exception ex)
            {
                // 处理异常
            }
        }


    }
}
