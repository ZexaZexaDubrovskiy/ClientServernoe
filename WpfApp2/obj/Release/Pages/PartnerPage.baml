   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages      WpfApp2.Pages.PartnerPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages       N� Title$  PartnerPage��.���  � RowDefinitions �� $��50 ��� $��50 ��� $��* � � ColumnDefinitions �� $��* ��� $��3 ��� -    ��Name$ PartnerColumnChange��$	��400 �$	��400��.+��� $��Partner��$��0��$��0��$��2��$��26(�$��	ExtraBold"��� $��1��$��0��$��3�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ 
PartnerAdd��$��Добавить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ PartnerCopy��$��Копировать��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ PartnerEdit��$��Изменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ PartnerDellete��$��Удалить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� $��|��$��24(�$
��Bold"�
�������$��15,0,0,0q��� -    ��Name$ PartnerFilterComboBox��$	��150��$��30��$��15,0,0,0q��� -    ��Name$ PartnerTextBox��$��5,0,5,0q�$	��170��$��30��]� $��2��$��0��$��2��.+�&   System.Windows.Controls.DataGrid  -     Name$ PartnerGrid��	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$
 Name�  $ Address��$	 10*  �� $ Address�  $
 City��$	 10*  �� $
 City�4  .System.Windows.Controls.DataGridTemplateColumn  $ Управление��   CellTemplate �� .R��� $ 
Horizontal=�.+��� -	   $��Изм.��$��30��$��5,0,0,0q�$��8(��� -
   $��	Удал.��$��30��$��5,0,5,0q�$��8(��� $��1��$��2��$��3��$��Stretch=��� $��2��$��2��$ Vertical=�.+��� -    ��Name$ PartnerLabel��$��Добавить Partner��$��16(�$
��Bold"�$��5,0,0,0q��� $ 
Horizontal=�$��0,10,0,0q�.+��� $
��Name��$��5,0,0,0q�$	��100���� -   $ PartnerTextName��$	��150��$��30��$��5,0,0,0q�����  �� ElementName$ PartnerGrid��$ SelectedItem.Name��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Address��$��5,0,0,0q�$	��100���� -   $ PartnerTextAddress��$	��150��$��30��$��5,0,0,0q����� $ PartnerGrid��$ SelectedItem.Address��� $ 
Horizontal=�$��0,10,0,0q�.+��� $
��City��$��5,0,0,0q�$	��100���� -   $ PartnerTextCity��$	��150��$��30��$��5,0,0,0q����� $ PartnerGrid��$ SelectedItem.City��� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� -   $ PartnerAddCommit��$��Добавить Partner��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q��� -   $ PartnerAddRollback��$��Отменить��$��30��$	��100��$��5,5,5,5q�$��5,5,0,5q�