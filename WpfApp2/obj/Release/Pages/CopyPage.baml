   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages  !clr-namespace:WpfApp2WpfApp2      WpfApp2.Pages.CopyPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages     /local_convertclr-namespace:WpfApp2       N� Title$  CopyPage�� � 	Resources   WpfApp2.ConverterValue   convertervalue��%   &	          .���  � RowDefinitions �� $��50 ��� $��50 ��� $��* � � ColumnDefinitions �� $��* �$	��200���� $��3 ��� $	��300 �$	��200��.+��� $)��#Менеджеры/доставка��$��0��$��0��$��2��$��26(�$��	ExtraBold"��� $��1��$��0��$��3�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ FilterComboBox��$	��150��$��30���� -    ��Name$ FilterTextBox��$��5,0,5,0q�$	��170��$��30��&   System.Windows.Controls.DataGrid  -     Name$ SalesPersonGrid��$��2��$��0��   AutoGenerateColumns .  	   CanUserAddRows	 .  
�������
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 	FirstName�  $ Фамилия��$ 5*  �� $ 
FamilyName��� -    ��Name$ GridSplitter��$��1��$��2��$��3��$��Stretch=�  -   $ CopyDataGrid��$��2��$��2�� .  	 .  
�����������  �� ElementName$ SalesPersonGrid��$ SelectedItem.Order�
   $ Дата�� �� $
 Date� �� 	Converter# [    $ Клиенты�� �� $ Customers.FamilyName�  $ 
Лодка�� �� $ 
Boat.Model�  $ 
Адрес�� �� $ DeliveryAddress�  $ 
Город�� �� $
 City�