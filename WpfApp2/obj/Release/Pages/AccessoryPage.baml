   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages  !    WpfApp2.Pages.AccessoryPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages     -     N� Title$  AccessoryPage��.���  � RowDefinitions �� $��50 ��� $��50 ��� $��* � � ColumnDefinitions �� $��* ��� $��3 ��� -    ��Name$ AccessoryColumnChange��$	��400 �$	��400��.+��� $��Аксекссуары��$��0��$��0��$��2��$��26(�$��	ExtraBold"��� $��1��$��0��$��3�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ AccessoryAdd��$��Добавить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ AccessoryCopy��$��Копировать��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ AccessoryEdit��$��Изменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ AccessoryDellete��$��Удалить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� $��|��$��24(�$
��Bold"�
�������$��15,0,0,0q��� -    ��Name$ AccessoryFilterComboBox��$	��150��$��30��$��15,0,0,0q��� -    ��Name$! AccessoryToBoaFilterTextBox��$��5,0,5,0q�$	��170��$��30��]� $��2��$��0��$��2��.+�&   System.Windows.Controls.DataGrid  -	     Name$ AccessoryGrid��	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ AccName��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ AccName�  $ DescriptionOfAccessory��$	 10*  �� $ DescriptionOfAccessory�  $ Price��$	 10*  �� $ Price�  $	 VAT��$	 10*  �� $	 VAT�  $ 	Inventory��$	 10*  �� $ 	Inventory�  $ 
OrderBatch��$	 10*  �� $ 
OrderBatch�  $ 
Partner_ID��$	 10*  �� $ Partner.Name�4  .System.Windows.Controls.DataGridTemplateColumn  $ Управление��   CellTemplate �� .R��� $ 
Horizontal=�.+��� -
   $��Изм.��$��30��$��5,0,0,0q�$��8(��� -   $��	Удал.��$��30��$��5,0,5,0q�$��8(��� $��1��$��2��$��3��$��Stretch=��� $��2��$��2��$ Vertical=�
�������.+��� -    ��Name$ AccessoryLabel��$ ��Добавить Accessory��$��16(�$
��Bold"�$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��AccName��$��5,0,0,0q�$	��100���� -   $ AccessoryTextAccName��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��DescriptionOfAccessory��$��5,0,0,0q�$	��100���� -   $) #AccessoryTextDescriptionOfAccessory��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Price��$��5,0,0,0q�$	��100���� -   $ AccessoryTextPrice��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $	��VAT��$��5,0,0,0q�$	��100���� -   $ AccessoryTextVAT��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��	Inventory��$��5,0,0,0q�$	��100���� -   $ AccessoryTextInventory��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��
OrderLevel��$��5,0,0,0q�$	��100���� -   $ AccessoryTextOrderLevel��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��
OrderBatch��$��5,0,0,0q�$	��100���� -   $ AccessoryTextOrderBatch��$	��150��$��30��$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��
Partner_ID��$��5,0,0,0q�$	��100���� -   $ AccessoryTextPartner_ID��$	��150��$��30��$��5,0,0,0q� �� DisplayMemberPath$
 Name���� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� -   $ AccessoryAddCommit��$!��Добавить книгу��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ AccessoryAddRollback��$��Отменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q�