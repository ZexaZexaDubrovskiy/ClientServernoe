   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages  5      !clr-namespace:WpfApp2WpfApp2  5          WpfApp2.Pages.CopyPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp2.Pages     5      /local_convertclr-namespace:WpfApp2     5      -   5          N� Title$  CopyPage��5
       � 	Resources 5        WpfApp2.ConverterValue   convertervalue��%!   &	          5   
   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��200��6)   �� 5      $��3 �6   �� 5      $	��300 �6   $	��200��6+   .+�5   
   �� $)��#Менеджеры/доставка��6   $��0��6-   $��0��6:   $��2��6J   $��26(�6^   $��	ExtraBold"�6l   �� 5   
   $��1��6   $��0��6"   $��3��62    �� Orientation$ 
Horizontal=�6F   .+�5      �� -   5         ��Name$ FilterComboBox��5      $	��150��6/   $��30��6;   �� 5      -   5         ��Name$ FilterTextBox��5      $��5,0,5,0q�6-   $	��170��6>   $��30��6J   6V   5!      &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ SalesPersonGrid��5#      $��2��6,   $��0��69      AutoGenerateColumns .  	   CanUserAddRows	 .  
�������
   Columns
 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   ��  �� Path$ 	FirstName�6U     5&      $ Фамилия��6%   $ 5* 6Z    66   �� $ 
FamilyName�6Z   5(      �� 5)   
   -   5         ��Name$ GridSplitter��5)      $��1��6-   $��2��6=   $��3��6J   $��Stretch=�6T     5+   
   -   5        $ CopyDataGrid��5+      $��2��6v   $��2��6�    .  	 .  
���������6)   ��  �� ElementName$ SalesPersonGrid��$ SelectedItem.Order�
 5,        5-      $ Дата��6%    63   �� $
 Date� �� 	Converter# [    5.      $ Клиенты��6%    66   �� $ Customers.FamilyName�  5/      $ 
Лодка��6%    64   �� $ 
Boat.Model�  50      $ 
Адрес��6%    64   �� $ DeliveryAddress�  51      $ 
Город��6%    64   �� $
 City�53      54      55      