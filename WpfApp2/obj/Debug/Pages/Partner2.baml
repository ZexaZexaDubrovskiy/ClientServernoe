   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages  5          WpfApp2.Pages.Partner2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp2.Pages     5        N� Title$  Partner2��5	      .��5      � -   5         �Name$ PartnerGrid2��5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��200��6)   �� 5      $��3 �6   �� 5      $	��300 �6   $	��200��6+   .+�5   
   �� $��Partner��6   $��0��6"   $��0��6/   $��2��6?   $��26(�6S   $��	ExtraBold"�6a   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PartnerGrid��5      $��2��6(   $��0��65      AutoGenerateColumns .     CanUserAddRows .  
�������   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 10* 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   ��  �� Path$
 Name�6Q     5      $ Address��6%   $		 10* 6W   
 66   �� $ Address�6W     5      $
 City��6%   $		 10* 6Q   
 63   �� $
 City�6Q   5      �� 5   
   -   5         ��Name$ PartnerGridSplitter��5      $��1��64   $��2��6D   $��3��6Q   $��Stretch=�6[     5!   
   -   5        $ PartnerDataGrid��5!      $��2��6|   $��2��6�    .   .  
���������6,   ��  �� ElementName$ PartnerGrid��$ SelectedItem.Accessory� 5"        5#      $ AccName��6%   $		 10* 6W   
 66   �� $ AccName�6W     5$      $ DescriptionOfAccessory��6%   $		 10* 6u   
 6E   �� $ DescriptionOfAccessory�6u     5%      $ Price��6%   $		 10* 6S   
 64   �� $ Price�6S     5&      $	 VAT��6%   $		 10* 6O   
 62   �� $	 VAT�6O     5'      $ 	Inventory��6%   $		 10* 6[   
 68   �� $ 	Inventory�6[     5(      $ 
OrderBatch��6%   $		 10* 6]   
 69   �� $ 
OrderBatch�6]   5+      5-      5.      