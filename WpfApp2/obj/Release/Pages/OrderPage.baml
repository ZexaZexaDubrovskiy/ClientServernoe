   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages      WpfApp2.Pages.OrderPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages       N� Title$  	OrderPage��.���  � RowDefinitions �� $��50 ��� $��50 ��� $��* � � ColumnDefinitions �� $��* ��� $��3 ��� -    ��Name$ OrderColumnChange��$	��400 �$	��400��.+��� $��Order��$��0��$��0��$��2��$��26(�$��	ExtraBold"��� $��1��$��0��$��3�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ OrderAdd��$��Добавить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ 	OrderCopy��$��Копировать��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ 	OrderEdit��$��Изменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ OrderDellete��$��Удалить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� $��|��$��24(�$
��Bold"�
�������$��15,0,0,0q��� -    ��Name$ OrderFilterComboBox��$	��150��$��30��$��15,0,0,0q��� -    ��Name$ OrderTextBox��$��5,0,5,0q�$	��170��$��30��]� $��2��$��0��$��2��.+�&   System.Windows.Controls.DataGrid  -     Name$ 	OrderGrid��	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$
 Date�  $ Salesperson_ID��$	 10*  �� $ Salesperson_ID�  $ Customer_ID��$	 10*  �� $ Customers.FistName�  $ Boat_ID��$	 10*  �� $ 
Boat.Model�  $ DeliveryAddress��$	 10*  �� $ DeliveryAddress�  $
 City��$	 10*  �� $
 City�4  .System.Windows.Controls.DataGridTemplateColumn  $ Управление��   CellTemplate �� .R��� $ 
Horizontal=�.+��� $��Изм.��$��30��$��5,0,0,0q�$��8(��� $��	Удал.��$��30��$��5,0,5,0q�$��8(��� $��1��$��2��$��3��$��Stretch=��� $��2��$��2��$ Vertical=�.+��� -	    ��Name$ 
OrderLabel��$��Добавить Order��$��16(�$
��Bold"�$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $
��Date��$��5,0,0,0q�$	��100���� -
   $ OrderTextDate��$	��150��$��30��$��5,0,0,0q�����  �� ElementName$ 	OrderGrid��$ SelectedItem.Date��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Salesperson_ID��$��5,0,0,0q�$	��100���� -   $ OrderTextSalesperson_ID��$	��150��$��30��$��5,0,0,0q� �� DisplayMemberPath$ 	FirstName�� �� Text �� $ 	OrderGrid��$) #SelectedItem.Sales_Person.FirstName��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Customer_ID��$��5,0,0,0q�$	��100���� -   $ OrderTextCustomer_ID��$	��150��$��30��$��5,0,0,0q�$ FistName�� �� $ 	OrderGrid��$% SelectedItem.Customers.FistName��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Boat_ID��$��5,0,0,0q�$	��100���� -   $ OrderTextBoat_ID��$	��150��$��30��$��5,0,0,0q�$ Model�� �� $ 	OrderGrid��$ SelectedItem.Boat.Model��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��DeliveryAddress��$��5,0,0,0q�$	��100���� -   $ OrderTextDeliveryAddress��$	��150��$��30��$��5,0,0,0q����� $ 	OrderGrid��$" SelectedItem.DeliveryAddress��� $ 
Horizontal=�$��0,10,0,0q�.+��� $
��City��$��5,0,0,0q�$	��100���� -   $ OrderTextCity��$	��150��$��30��$��5,0,0,0q����� $ 	OrderGrid��$ SelectedItem.City��� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� -   $ OrderAddCommit��$��Добавить Order��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ OrderAddRollback��$��Отменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q�