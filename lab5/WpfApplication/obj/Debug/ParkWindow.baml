   M S B A M L   `   `   `  ����  WpfApplication    WpfApplication.ParkWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
ParkWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��508* �6   �� 5	      $��9* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgGods��5         AutoGenerateColumns .  $��
0,128,75,0q�6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 95 6%      Header$ 
AncientAge��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
ancientAge+  5      $ 95 6%   $
 Name��61    6?   �� *name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Delete��6)      CellTemplate 5      �� 5      .R�5      ��  ��Name$ 
button_del��6%   -   5        $��Delete��5   9   $��75��6J   6U   5      5        5      $
 Edit��6)    5      �� 5      .R�5      �� $ button_edit��6%   -   5        $
��Edit��5   :   $��75��6I   6T   5      5      5      �� 5   
   -   5        $ 
button_add��5      $	��Add��6%   $
��Left=�63   $��0,13,0,0q�6N   $	��Top=�6`   $��75��6x   6�   �� 5    
   -   5        	 ��Name$	 textH��5       $
��Left=�6!   $��23��6<   $��	90,62,0,0q�6H   
 �� TextWrapping$

 Wrap=�6[   $	��Top=�6o   $	��106��6�   �� 5!   
   -   5        $	 textK��5!      $
��Left=�6!   $��23��6<   $��
251,62,0,0q�6H   $

 Wrap=�6\   $	��Top=�6p   $	��106��6�   �� 5"   
   -   5        $ button_save��5"      $
��Save��6&   $
��Left=�65   $��
386,16,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5#   
   -	   5        $ button_save_edit��5#      $
��Save��6+   $
��Left=�6:   $��
386,15,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5$   
   -
   5         ��Name$ labelH��5$      $��
AncientAge��6    $
��Left=�65   $��	90,12,0,0q�6P   $	��Top=�6c    J� RenderTransformOrigin$ -0.383,0.109&�6{   �� 5%   
   -   5        $ labelK��5%      $
��Name��6    $
��Left=�6/   $��
251,10,0,0q�6J   $	��Top=�6^   5&      5'      