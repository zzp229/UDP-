   M S B A M L   `   `   `  ����D  @用户端, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:用户端	用户端  5   	       用户端.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:用户端     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5      =   7用户端.StringIsNullOrWhiteSpaceToVisibilityConverter 1  -StringIsNullOrWhiteSpaceToVisibilityConverter��%   &	          5   
   6>   5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��50* �6   �� 5      $	��20* �6   �� 5      $	��10* �6   .+�5   
   �� $��0��6   $��消息传递助手��6!   $��Center=�6/   $��Center=�6J   6i   �� 5   
   -   5         ��Name$ messageTextBox��5      $��1��6*   
�������67   �� 5   
   $��1��6    �� Padding$ 5,0,0,0q�6!    J� IsHitTestVisible$ False��63   
�������$��Italic$�5      $��请输入要发送内容��5       y�5!      ��  �� ElementName$ messageTextBox�� �� Path$
 Text�	 �� 	Converter#	 [  �� 5%   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   .+�5&      �� $��用户地址：��6   $��30(�6%   $��Center=�63   $��10, 20q�6N   6`   �� 5'      $	��455��6   $��40��6#   61   �� 5(      -   5        $��
SendButton��5(      $��30(�5)      $��发送��6#   $��Center=�60   $��10, 20q�6K   6]   �� 5*      $��30(�6   $��广播��6$   $��Center=�61   $��10, 20q�6L   6^   5+      �� 5.   
   $��3��6   $
 
Horizontal=�6"   .+�5/      �� -   5         ��Name$ 	SendImage��5/      $��20(�6@   $��发送图片��6N   $��Center=�6]   $��10, 2q�6x   6�   �� 50      $��20(�6   $��发送文件��6$   $��Center=�63   $
��1, 2q�6N   6^   51      53      54      