   M S B A M L   `   `   `  ����K  Gmy_PNET_PR3_1_Z3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:my_PNET_PR3_1_Z3my_PNET_PR3_1_Z3  5   	   !    my_PNET_PR3_1_Z3.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:my_PNET_PR3_1_Z3     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� -   5        $
��List��5      $��3��5      ��5      ��  �� Path$ Movies���5      �� 5      .R�5      �� ��5      `� 5       �� StringFormat$ {0} {1} {2} {3} {4}��6+   .1�5   "   �� $ Title�6*   �� 5   "   $ Director�6*   �� 5   "   $ Producer�6*   �� 5    "   $ DataCT�6*   �� 5!   "   $ ReleaseDate�6*   5"      5$      5%      5'      �� 5(   
   -   5        $��1��5)      $��Import��5*      5+      �� 5-   
   -   5        $��1��5.      $��2��5/      $��Export��50      51      �� 53   
   -   5        $��2��54      $	��Add��55      56      �� 58   
   -   5        $��2��59      $��1��5:      $
��Edit��5;      5<      �� 5>   
   -   5        $��3��5?      $��2��5@      $��Delete��5A      5B      5D      5E      