   M S B A M L   `   `   `  ����A  =Pronin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Pronin.PagesPronin.Pages  5   	       Pronin.Pages.sumuch   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Pronin.Pages     5   	     � Title$  sumuch��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ uchDATAGRID��5      $��Stretch=�6(      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер_записи��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *nomer_zapisi+  5      $# Табельный_номер��6%    6>   �� *tabelniy_nomer+  5      $ 
Месяц��6%    64   �� *mouth+  5      $ 
Оклад��6%    64   �� *oklad+  5      $ Доблата��6%    66   �� *	doplata+  5      $&  Сумма на человека��6%    6@   �� *Sum_na_cheloveka+  5      $ Сумма доплаты��6%    6<   �� *
Sum_doplat+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        	 ��Name$	 vichisl��5      $��Вычисление��6&   $	��120��6;   $��40��6G   $��5q�6S   $��20(�6^   6l   �� 5      -   5        
 ��Name$
 SEREGA��5      $	��120��6&   $��40��62   $��5q�6>   6I   �� 5      -   5        $
 start_SEREGA��5      $	��120��6,   $��40��68   $��5q�6D   6O   �� 5      -   5        $
 
end_SEREGA��5      $	��120��6*   $��40��66   $��5q�6B   6M   �� 5      -   5        $	 SeregaSearch��5      $��Диапозон��6+   $	��120��6>   $��40��6J   $��5q�6V   $��20(�6a   6o   5       5"      5#      