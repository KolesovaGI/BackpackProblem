   M S B A M L   `   `   `  ����J  FBackpackProblem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BackpackProblemBackpackProblem  5   	        BackpackProblem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BackpackProblem     5   	     � Title$%  Проблема рюкзака��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$ 	/icon.png��6.   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	itemsGrid��5         AutoGenerateColumns .  ���#e0daed   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *Name+6P     5      $ Стоимость��6%   $ 84 6R   	 68   �� *Price+6R     5      $ Вес��6%   $ 80 6M   	 62   �� *Weigth+6M   5      �� 5   
   $��1��6   .+�5      �� .+�5      �� -   5        
 ��Name$
 EnterMaxWeight��5      $+��%Введите вес рюкзака:��5      $��10q�5      $��14(�5      �� 5      -   5         ��Name$ EnterMW��5      $��200px��5      $��20��5       $��10, -5, 20, 10q�5!      $
��Left=�5"      $��0q�5#      ���#e0daed5$      �� 5%      -   5         ��Name$ ButtonforMW��5&      $��100px��5'      $��20��5(      $��10, 0, 20, 10q�5)      $
��Left=�5*      $
��ОК��5+      $
��Bold"�5,      
����������#e0daed$��0q�5/      #��[" �50      51      �� 52      -   5        $ 	EnterNext��53      $��100px��54      $��25��55      $��10, 10, 10, 10q�56      $
��Left=�57      $��ВЫЧИСЛИТЬ��58      
�������$
��Bold"�5:      ���#e0daed$��0q�5<      #��[" �5=      5>      5?      �� 5@      $@��:Стоимость собранных предметов::��6   $��14(�5A      �� 5B      -   5         ��Name$ Result��5C      $��Center=�5D      
���   �$��25(�5F      $��10q�5G      $��50��6   �� 5H      $��Предметы:��6   $��14(�5I      �� 5J      -   5        $ ResultItems��5K      $��Center=�5L      
���   �$��25(�5N      $��10q�5O      $��50��6   5P      5Q      5R      