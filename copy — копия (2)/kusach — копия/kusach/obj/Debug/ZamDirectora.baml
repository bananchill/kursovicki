   M S B A M L   `   `   `  ����A  =kusach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kusachkusach  5   	       kusach.ZamDirectora   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:kusach     5   	     � Title$  FormZamDirectora��5   	   $��310.066��6"   $��960.132��63   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF1F1F1��6    � Offset$ 0Q�6-   � 5      $ 	#FF67B6DA��6   $ 1Q�6-   5      .��5      � $
��Left=�6   $	��937��6&   $��	0,0,0,192q�62   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataZakupka��5      $
��Left=�6(   $��10,59,0,-103q�6C   $	��400��6Y      MinColumnWidth$ 40Q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 64   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *	idzakaz+5      �� 5   
   $G��AЗакупки и Составление спецификации��6   $
��Left=�6=   $��
105,33,0,0q�6X   $	��Top=�6l   $	��234��6�     5   
   -   5        $ 
DataProizv��5      $
��Left=�6'   $��488,59,0,-103q�6B   $	��400��6Y   $ 40Q�6�    5        5      $ 
Номер��6%   $	 50 64   
 6?   �� *	idzakaz+5      �� 5   
   $/��)Закупка - Производство��6   $
��Left=�61   $��
612,33,0,0q�6L   $	��Top=�6`   $	��234��6x   �� 5   
   -   5        $��На главную��5      $
��Left=�6&   $��29��6A   $��782,204,0,-147q�6M   $	��Top=�6e   $	��106��6}   6�   �� 5   
   -   5        $#��Учет материалов��5      $
��Left=�6+   $��29��6F   $��612,204,0,-146q�6R   $	��Top=�6j   $	��106��6�   6�   5      5      