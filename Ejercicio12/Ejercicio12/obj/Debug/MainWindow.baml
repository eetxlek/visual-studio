   M S B A M L   `   `   `  ����F  BEjercicio12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ejercicio12Ejercicio12  5   	       Ejercicio12.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ejercicio12     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   $	��500��65   $	��800��6E    � 	Resources 5	       �� 
TargetType �� Property �� Value   bajo  amarillo  	stackhijo 	 firma 
 imagen  info  	labelgrid  boxgrid  dochijo��%�  '��       '�� �     &	  y    &	 �    &	 �    &	      &	 �    &	 �    '�� �    '� �    &	 h    &	 �    '�� �    ']� �    &	     �� 5
   
   " ��6   .�5      ��  � ��
 �   �6,   �� 5       � ��$ 3q�60   �� 5       �@��CornerRadius$ 3��6-   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 40(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6   .�5      ��  �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$ Right=�64   5      �� 5   
   " ��6   .�5      ��  �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$	 120��6'   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5       ��  �@��Orientation$ Vertical=�6,   �� 5!       � ��$ 5q�6'   5"      �� 5#   
   " ��6   .�5$      ��  � ��$ 20(�6)   �� 5%       � ��$
 Left=�64   5&      �� 5'   
   " ��6   .�5(      ��  � ��$ 5q�6'   �� 5)       � ��$ right=�64   5*      �� 5+   
   " ��6   .�5,      ��  � ��$ 5q�6'   �� 5-       � ��$ Center=�62   �� 5.       � ��$ 26��6'   5/      �� 50   
   " ��6   .�51      ��  � ��$ 70��6&   �� 52       � ��$ 5q�6'   53      �� 54   
   " �6   .�55      ��  � ��
 ��ح�6+   �� 56       � ��$ 80��6'   57      �� 58   
   " ��6   .�59      ��  � ��$ 26��6'   �� 5:       � ��$ Center=�62   �� 5;       � ��$ 5q�6'   5<      �� 5=   
   " ��6   .�5>      ��  � ��$ 20��6'   �� 5?       � ��$ Center=�62   �� 5@       � ��$ 5q�6'   5A      �� 5B   
   " ��6   .�5C      ��  � ��$	 200��6&   5D      �� 5E   
   " ]�6   .�5F      ��  � ��$ 5q�6'   5G      �� 5H   
   " ]�6   .�5I      ��  � ��$ 40��6'   5J      5N      .��5O      ]� $	��500��6   .+�5P   
   �� $	��Top=�6   
Formulario66   ]� 5Q   
   #��[ 6   $��Bottom=�65   .+�5R      �� #��[ 6   .��63   Estibaliz Etxaburu6G   �� 5S      #��[  6   .+�5T      �� .��6   	Aceptar6#   �� 5U      .��6   
Cancelar6$   5V      5W      �� 5X   
   #��[ 6   $��Right=�61   $��foto.jpg��6H   �� 5Y   
   $	��500��6   $
��Left=�6%   $��5,6,5,38q�6;   .+�5Z      �� ._�5[      � $	��Top=�6    � RowDefinitions 5\      �� 5]      $	��10* �6(   67   �� 5^      $	��10* �6(   67   �� 5_      $	��10* �6(   67    � ColumnDefinitions 5a      �� 5b      $	��69* �6+   69   �� 5c      $
��425* �6+   6:   �� 5d      $	��39* �6+   69   .+�5g      �� #��[ 6   $��0��6?   $��0��6L   .��6\   Nombre6d   �� 5h      #��[ 6   $��0��6?   $��1��6L   6^   �� 5i      #��[ 6   $��1��6?   $��0��6L   .��6\   Edad6b   �� 5j      #��[ 6   $��1��6?   $��1��6L   6^   �� 5k      #��[ 6   $��2��6?   $��0��6L   .��6\   	Direccion6g   �� 5l      #��[ 6   $��2��6?   $��1��6L   6^   �� 5m      #��[ 6    � ToolTip$ información��6:   $��0��6P   $��2��6^   $��info.png��6n   �� 5n      #��[ 6   $ información��6:   $��1��6P   $��2��6^   $��info.png��6n   �� 5o      #��[ 6   $ información��6:   $��2��6P   $��2��6^   $��info.png��6n   5p      5q      �� 5r      ._�5s      �� #��[ 6   $��Bottom=�6?   .+�5t      �� $��	Aficiones��6   $��5q�62   .��5u      �� #��[ 6&   .+�5v      �� $��2,5,1,1q�6'   .��68   Hacer deporte6G   �� 5w      $��2q�6'   .��62   Viajar6:   �� 5x      $��2q�6'   .��62   
Ver series6>   �� 5y      $��2,1,1,5q�6'   .��68   Leer comics6E   5z      5{      �� 5|      $��Estado civil��6   $
��30,5q�65   .��5}      �� #��[ 6%   .+�5~      	�  d� 	IsChecked$
 TrueY�6*   $��1,5,1,1q�6;   .��6L   	Soltero6U   	� 5      $��1q�6*   .��65   Casado6=   	� 5�      $��1q�6*   .��65   
Divorciado6A   	� 5�      $��1,1,1,5q�6*   .��6;   Viudo6B   5�      5�      5�      5�      5�      5�      5�      