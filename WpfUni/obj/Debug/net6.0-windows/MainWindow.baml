   M S B A M L   `   `   `  ????A  =WpfUni, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfUniWpfUni  5   	       WpfUni.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfUni     5   	     ? Icon$=  7https://cdn-icons-png.flaticon.com/512/8790/8790372.png??5   	    ? Title$ 
MainWindow??5	   	   $	??450??6   $	??800??6)   .??5
      ? .+?5   
   ?? $
??Left=?6   $??Universitäten aus:??6+   $??	10,10,0,0q?6H   $	??Top=?6[   $??22(?6s   $	??390??6?   $??2??6?   ?? 5   
   -   5         ??Name$ consoleLabel??5      $??Console:??6&   $
??Left=?69   $??
400,10,0,0q?6T   $	??Top=?6h   $??22(?6?   $	??390??6?   ?? 5   
   -   5         ??Name$ dataListView??5      $??
0,54,400,0q?6)   $??2??6j    ?? View 5      ?? 5      .P?5      ?? -   5        Country??$
??Land??5   _    ?? DisplayMemberBinding 66   ?? *	country+6_   ?? 5      -   5        
Alpha2Code??$??Kürzel??5   i    69   ?? *alpha_two_code+6i   ?? 5      -   5        Name??$
??Name??5   Y    63   ?? *name+6Y   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataDataGrid??5      $??
400,54,0,0q?6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        country??,  &System.Windows.Controls.DataGridColumn   Header$ Country??5   6   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6H   ?? *	country+5      ?? 5   
   -   5        
 ??Name$
 countryComboBox??5      $
??Left=?6,   $??
188,19,0,0q?6G   $	??Top=?6[   $	??207??6s   $??2??6   .@?5      ?? $??Austria??6   ?? 5      $??United+States??6   ?? 5       $??United+Kingdom??6   5!      5#      5$      