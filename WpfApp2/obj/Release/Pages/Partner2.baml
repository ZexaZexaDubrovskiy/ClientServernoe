   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages      WpfApp2.Pages.Partner2   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages       N� Title$  Partner2��.��� -    �Name$ PartnerGrid2�� � RowDefinitions �� $��50 ��� $��50 ��� $��* � � ColumnDefinitions �� $��* �$	��200���� $��3 ��� $	��300 �$	��200��.+��� $��Partner��$��0��$��0��$��2��$��26(�$��	ExtraBold"�&   System.Windows.Controls.DataGrid  -     Name$ PartnerGrid��$��2��$��0��   AutoGenerateColumns .     CanUserAddRows .  
�������   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 10* 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$
 Name�  $ Address��$		 10* 
 �� $ Address�  $
 City��$		 10* 
 �� $
 City��� -    ��Name$ PartnerGridSplitter��$��1��$��2��$��3��$��Stretch=�  -   $ PartnerDataGrid��$��2��$��2�� .   .  
�����������  �� ElementName$ PartnerGrid��$ SelectedItem.Accessory�   $ AccName��$		 10* 
 �� $ AccName�  $ DescriptionOfAccessory��$		 10* 
 �� $ DescriptionOfAccessory�  $ Price��$		 10* 
 �� $ Price�  $	 VAT��$		 10* 
 �� $	 VAT�  $ 	Inventory��$		 10* 
 �� $ 	Inventory�  $ 
OrderBatch��$		 10* 
 �� $ 
OrderBatch�