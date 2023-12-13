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
using System.IO;

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

                    Console.WriteLine(bytes);

                    // 这个是图片的
                    // 将字节数组转换为图片
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        // 在UI线程上创建和更新图片显示
                        Dispatcher.Invoke(() =>
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.StreamSource = ms;
                            image.EndInit();

                            imageControl.Source = image; // 假设你有一个名为imageControl的Image控件
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                // 处理异常
            }
            finally { udpClient.Close(); }
        }

    }
}
