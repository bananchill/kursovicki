   M S B A M L   `   `   `  ����A  =kusach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kusachkusach  5   	       kusach.Master   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:kusach     5   	     � Title$  
FormMaster��5   	   $��364.129��6   $��1057.554��6-   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF1F1F1��6    � Offset$ 0Q�6-   � 5      $ 	#FF67B6DA��6   $ 1Q�6-   5      .��5      � $��0,0,0,53q�6   $
��Left=�6   $	��847��68   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
DataMaster��5      $
��Left=�6%   $	��208��6@   $��	22,36,0,0q�6M   $	��Top=�6�   $	��462��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	idzakaz+  5      $ Стадия��6%   $ 50 65    6@   �� *name+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5        5   
   -   5        $��
DataProizv��5      $
��Left=�6%   $	��208��6@   $��527,36,-173,0q�6M   $	��Top=�6d   $	��493��6|   �� 5   
   $!��Готовые Заказы��6   $
��Left=�6)   $��	739,5,0,0q�6D   $	��Top=�6W   �� 5   
   -   5        $
��edit��5      $
��Left=�6   $��23��6:   $��
25,249,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $"��Редактирование��5      $
��Left=�6*   $��295,249,0,0q�6E   $	��Top=�6Z   $	��119��6r   $��23��6~   6�   �� 5   
   -   5        $��На главную��5      $
��Left=�6&   $��937,251,-165,0q�6A   $	��Top=�6Y   $��75��6q   6|   �� 5   
   -   5        $��Материалы��5      $
��Left=�6%   $��822,251,-50,0q�6@   $	��Top=�6W   $��75��6o   6z   �� 5   
   -   5        $��
Выбор��5      $
��Left=�6!   $	��Top=�6<   $��91��6T   $��167,252,0,0q�6_   6t   5      5       