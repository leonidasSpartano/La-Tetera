   M S B A M L   `   `   `  ����F  BThe_Teapots, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:The_TeapotsThe_Teapots  5   	   R NSharpGL.WPF, Version=3.1.1.0, Culture=neutral, PublicKeyToken=27fc851303210b27>.clr-namespace:SharpGL.WPF;assembly=SharpGL.WPFSharpGL.WPF 5   	       The_Teapots.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:The_Teapots     5   	   BsharpGL.clr-namespace:SharpGL.WPF;assembly=SharpGL.WPF     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��10q�6%   .+�5      �� -   5         ��Name$ chkGlobalAmbient��5      $!��Modelo Luz Ambiental Global��61    d� 	IsChecked$
 TrueY�6W   �� 5      -   5        $ chkLightPosition��5      $��Posicion de Luz��61   $
 TrueY�6K   �� 5      -   5        $ 
chkAmbient��5      $��Luz Ambiental��6+   $
 TrueY�6C   �� 5      -   5        $ 
chkDiffuse��5      $��
Luz Difusa��6+   $
 TrueY�6@   �� 5      -   5        $ chkSpecular��5      $��Luz Especular��6,   $
 TrueY�6D   5        SharpGL.WPF.OpenGLControl  5   
   -   5          Name$ openGLControl��5          DrawFPS$
 True��5         	FrameRate$	 120Q�5          RenderContextType$	 FBO=�5!         OpenGLVersion$ 	OpenGL2_1=�5"      $��10,10,30,10q�5#      $��1��6-   5%      5&      