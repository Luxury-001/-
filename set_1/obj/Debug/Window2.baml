   M S B A M L   `   `   `  ����E  ATumat_pr17, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:set_1set_1  5   	       set_1.Window2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:set_1     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   �� -   5        $��con_btn��5
      $��Connect��6    $
��Left=�62   $��	29,25,0,0q�6M   $	��Top=�6`   $	��102��6x   $��54��6�   6�   �� 5   
   -   5        $��add_btn��5      $��Add data��6    $
��Left=�63   $��
151,25,0,0q�6N   $	��Top=�6b   $	��102��6z   $��54��6�   6�   �� 5   
   -   5        $��del_btn��5      $��Delete data��6    $
��Left=�66   $��
275,25,0,0q�6Q   $	��Top=�6e   $	��102��6}   $��54��6�   6�   �� 5   
   -   5        $��upd_btn��5      $��Update��6    $
��Left=�61   $��
393,25,0,0q�6L   $	��Top=�6`   $	��102��6x   $��54��6�   6�   �� 5   
   -   5        $��acc_btn��5      $��
Accounting��6    $
��Left=�65   $��
519,25,0,0q�6P   $	��Top=�6d   $	��102��6|   $��54��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��MainDG��5         AutoGenerateColumns .  $
��Left=�6=   $	��316��6X   $��	0,103,0,0q�6e   $	��Top=�6x   $	��792��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ airplane id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *airplane_id+6\     5      $ airplane name��6%    6<   �� *airplane_name+6`     5      $ data of issue��6%    6<   �� *data_of_issue+6`     5      $ capacity��6%    67   �� *
capacity+6V     5      $ last tech service��6%    6@   �� *last_tech_service+6h     5      $ flight hours��6%    6;   �� *flight_hours+6^   5      5      5      