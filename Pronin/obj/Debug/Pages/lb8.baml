   M S B A M L   `   `   `  ����A  =Pronin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Pronin.PagesPronin.Pages  5   	       Pronin.Pages.lb8   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Pronin.Pages     5   	     � Title$	  lb8��5   	   $	��450��6   $	��800��6"   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UchDG��5      $��Stretch=�6"      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$&  Сумма на человека��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Sum_na_cheloveka+5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      �� -   5        	 ��Name$
	 back��5      $��
Назад��6#   $��5q�63   $	��100��6>   $��15(�6J   6X   �� 5      -   5        
 ��Name$
 search��5      $	��100��6&   $��5q�62   �� 5      -   5        $	 	searchBTN��5      $��
Поиск��6(   $��5q�68   $	��100��6C   $��15(�6O   6]   5      5      5      