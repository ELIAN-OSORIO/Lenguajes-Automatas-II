   M S B A M L   `   `   `  ���� B  >Scanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ScannerScanner  -clr-namespace:Scanner.ViewsScanner.Views      Scanner.Window1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Scanner     2
viewmodelsclr-namespace:Scanner.Views       � Title$  Window1��$	��500��$	��800�� � 	Resources  �� DataType    Scanner.Views.UserControl1 � DataContext��%<   (��       *, +)�� UserControl1��"  .R�   �� .��� .+��  � ColumnDefinitions �� $	��200 ���  � RowDefinitions �� $��50 ��� .+��� $��2�����#515151.+��� $��20��$	��230�� �� TextAlignment$ Center=�$��Center=�$#��Microsoft Intune admin center��
�������$
��Left=�$��18(�$��15q�$��Calibri)��� $��1�����#e3e4e5.+��� -   $��30��
������ $��0 30 0 0q�.���  �� $��50 ��� $	��150 �.+��� $��1��$��Inicio��$
 Left=�$��Center=�$
��Left=�$	��140��$��15(��� $��Image\back.png���� -   $��30��
������ $��0 0 0 0q�.���  �� $��50 ��� $	��150 �.+��� $��1��$��Escaner��$
 Left=�$��Center=�$
��Left=�$	��140��$��15(��� $��Image\ware.png��� $��1��$��1�����#007cab.+��  �� $	��100 ��� �� .+��� $��1��$$��Bienvenido al menu desplegable��$��35(�$��Center=�$��Center=�
��������� $��1��._��  �� �� .+��� $��1��$&�� ¿Desea conocer mas informacion?��$��20(�
�������$��Center=�$��Center=��� $��2��._��  �� �� .+��� -   $��40��$	��150��$��	CONTINUAR��
�������$��20(����#4682b4
��������� -   $��40��$	��150��$��1��$��NO POR AHORA��
�������$��20(����#4682b4
������� � -     �Name$ ventanaInfo��$��3���� ����  � -   $ VentanaPrincipal��