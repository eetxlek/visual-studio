   M S B A M L   `   `   `  ����R  NActividad UT4-1 Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Actividad_UT4_1_BindingActividad_UT4_1_Binding  5   	   (    "Actividad_UT4_1_Binding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Actividad_UT4_1_Binding     5   	     � Title$  	MemeMaker��5   	   $	��500��6   $	��800��6(    � 	Resources 5	       �� 
TargetType �� Triggers �� Binding �� ElementName �� Path �� Value �� Property	 �� Value��%�   '��       �� 5
   
   " ��6    5   
   �� 5       6   �� $ borde��$ 	IsChecked� True6P   .a�5      ��  � ��$	 2q�64   �� 5       � ��
	 �   �60   5      5      5      .��5      ]� ��. .+�5   
   �� $	��Top=�6   $��5q�6*   
 �� Orientation$
 
Horizontal=�65   .+�5      �� $��76��6   $
��Wrap=�6*   $��Texto Superior��6>   $��20��6T   $��0,0,10,0q�6`   $
��Left=�6r   �� 5      -   5         ��Name$ textSup��5      $��Texto superior��6+   $��20��6A   $	��670��6M   5      �� 5   
   $	��Top=�6   $��5q�6+   $
 
Horizontal=�66   .+�5      �� $��76��6   $
��Wrap=�6*   $��Texto Inferior��6>   $��20��6T   $��0,0,10,0q�6`   $
��Left=�6r   �� 5      -   5        $ textinf��5      $��Texto inferior��6'   $��20��6=   $	��670��6I   5      �� 5   
   $	��Top=�6   $��5q�6+   $
 
Horizontal=�66   .+�5      �� $��76��6   $
��Alto��6&   $��0,0,10,0q�63   6G   �� 5       -   5         ��Name$ 
sliderAlto��5       $	��500��6*    � Minimum$	 100Q�66    � Maximum$
 1000Q�6D    � Value$	 500Q�6S   5!      �� 5#   
   $	��Top=�6   $��5q�6+   $
 
Horizontal=�66   .+�5$      �� $��76��6   $��Ancho��6&   $��0,0,10,0q�64   6H   �� 5%      -   5        $ sliderAncho��5%      $	��500��6+   $	 100Q�67   $
 1000Q�6E   $	 500Q�6T   5&      �� 5(   
   $	��Top=�6   $��5q�6+   $
 
Horizontal=�66   .+�5)      �� $��76��6   $
��Wrap=�6*   $��Imagen��6>   $��20��6L   $��0,0,10,0q�6X   $
��Left=�6j   �� 5*      -   5        $	 url��5*      $�� ��6#   $��20��6+   $	��670��67   5+      �� 5-   
   $	��Top=�6   $��5q�6+   $
 
Horizontal=�66   .+�5.      �� $��Borde��6   $��76��6%   $
��Wrap=�63   $��20��6G   $��0,0,10,0q�6S   $
��Left=�6e   6�   �� 5/      -   5        $��borde��5/       d� 	IsChecked$
 TrueY�6$   68   50      �� 52   
   -   5         ��Name$ 
lineaborde��52      $��	100,0,0,0q�6%   $	��100��69   ��6I   �� $ sliderAncho��$ Value���6   �� $ 
sliderAlto��$ Value�._�53      ]� -   5         ]�Name$
 meme��53      ��. $	��100��6;   $	��100��6J   
���������6r   �� $ sliderAncho��$ Value���6�   �� $ 
sliderAlto��$ Value�.+�54      �� $	��Top=�6   $
��Wrap=�62   $��Center=�6F   $��36(�6c   $��Impact)�6q   
���������6�   �� $ textSup��$
 Text� J� Effect 55      3  -System.Windows.Media.Effects.DropShadowEffect  56         ShadowDepth$ 4Q�6+      Color$ Black��6;      	Direction$	 330Q�6I      
BlurRadius$ 4Q�6Y   58      �� 59      $��Bottom=�6   $
��Wrap=�65   $��Center=�6I   $��36(�6f   $��Impact)�6t   
���������6�   �� $ textinf��$
 Text� 5:        5;      $ 4Q�6+   $ Black��6;   $	 330Q�6I   $ 4Q�6Y   5=      �� 5>      $	��400��6F   $	��200��6R   ��6   �� $	 url��$
 Text�6a   5?      5@      5A      5B      