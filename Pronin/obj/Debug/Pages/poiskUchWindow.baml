   M S B A M L   `   `   `  ����A  =Pronin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Pronin.PagesPronin.Pages  5   	   !    Pronin.Pages.poiskUchWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Pronin.Pages     5   	     � Title$  poiskUchWindow��5   	   $	��500��6    $
��1000��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��560 �6   �� 5      $	��226 �6   �� 5      $	��215 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UchDG��5      $��Stretch=�6"   $��
10,0,10,10q�6G      AutoGenerateColumns .     
IsReadOnly . $��1��6�   $��0��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер_записи��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *nomer_zapisi+  5      $# Табельный_номер��6%    6>   �� *tabelniy_nomer+  5      $ 
Месяц��6%    64   �� *mouth+  5      $ 
Оклад��6%    64   �� *oklad+  5      $ Доплата��6%    66   �� *	doplata+5      �� 5   
   -   5        	 ��Name$	 	Searchtab��5      $	��150��6%   $��0,30,0,0q�61   $��30��6C   $��1��6O   $��1��6_   $	��Top=�6l   $��Center=�6�   6�   �� 5   
   -   5        
 ��Name$	
 tab��5      $#��Табельный номер��6   $��1��67   $��1��6G   $	��Top=�6T   $	��130��6l   $��30��6x   �� 5   
   -   5        $
 mouth��5      $��
Месяц��6   $��2��6/   $��1��6?   $	��Top=�6L   $	��130��6d   $��30��6p   �� 5    
   -   5         ��Name$ 
backButton��5       $��
15,0,15,15q�6%   $��30��69   $��2��6E   $��1��6U   $��Bottom=�6b   $��
Назад��6}   $��20(�6�   6�   �� 5!   
   -   5        $	 
Searchmoth��5!      $	��150��6&   $��0,30,0,0q�62   $��30��6D   $��2��6P   $��1��6`   $	��Top=�6m   $��Center=�6�   6�   �� 5"   
   -   5        $	 searchprosent��5"      $	��150��6)   $��	0,100,0,0q�65   $��30��6H   $��2��6T   $��1��6d   $	��Top=�6q   $��Center=�6�   6�   �� 5#   
   -   5        $
 prosent��5#      $#��Процент доплаты��6!   $��2��6;   $��1��6K   $	��Top=�6X   $	��130��6p   $��30��6|   $��0,70,0,0q�6�   5%      5&      