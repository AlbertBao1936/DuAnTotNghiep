   M S B A M L   `   `   `  ����N  JDuAn_QuanLiKhachSan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DuAn_QuanLiKhachSanDuAn_QuanLiKhachSan  5   	   $    DuAn_QuanLiKhachSan.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      -local!clr-namespace:DuAn_QuanLiKhachSan  5   	     � Title$  
MainWindow��5   	   $	��720��6   $
��1100��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   $��Poppins)�64   .��5      ��  �� CornerRadius$ 10��6      PrimaryBackgroundColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��280 �6#   �� 5      $��* �6#   .+�5      �� $ 	10 0 0 10��6    �� Padding$ 10q�5        SecundaryBackgroundColor#���  5      ._�5      � -   5        	 �Name$	 gridMenu��5      
 � RowDefinitions
 5      �� 5      $��80 �6(   �� 5      $��* �6(   �� 5      $��80 �6(   .+�5      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   .+�5       �� $��/imgs/LOGO (2).png��6    $
��Fill=�6<   $��86��6K   $��86��6W   $��Center=�6b   �� 5!      $��HOTEL DE LUNA��6      PrimaryYellowColor#���  68   $
��Bold"�6j   $��20(�6|   $��Center=�6�   $��Center=�6�   $��5 0 0 0q�6�   $��Algerian)�6�   5"      �� 5$      $��1��6!   .+�5%      	� -   5         	�Name$ rdHome��5%   &   $��Trang chủ��66     MenuRadioButtonStyle#���  6J     home
 � Tag# �  6y   $��0 30 0 0q�6�   6�   	� 5&      -   5        $ rdRoom��5&   &   $��Quản lí phòng��66   #���  6N     room# �  6}   $��0 1 0 1q�6�   6�   	� 5'      -   5        $ rdKindOfRoom��5'   &   $��Quản lí loại phòng��6<   #���  6Y     
kindOfroom# �  6�   $��0 1 0 1q�6�   6�   	� 5(      -   5        $ 
rdBookroom��5(   &   $��Đặt phòng��6:   #���  6N     bookroom# �  6}   6�   	� 5)      -   5        $ rdBills��5)   &   $��
Hóa đơn��67   #���  6I     bill# �  6x   $��0 1 0 1q�6�   6�   	� 5*      -   5        $ rdClient��5*   &   $��Quản lí khách hàng��68   #���  6U    	 clients# � 	 6�   6�   	� 5+      -   5        $ 
rdServices��5+   &   $��Quản lí dịch vụ��6:   #���  6T    
 services# � 
 6�   6�   	� 5,      -	   5        $ rdStaff��5,   &   $��Quản lí nhân viên��67   #���  6S     	employees# �  6�   6�   	� 5-      -
   5        $ rdChart��5-   &   $��Thống kê��67   #���  6J    	 chart# �  6y   6�   �� 5/      $��20 20q�6$     TertiaryBackgroundColor#���  63   	� 52      -   5        $ 
rdSettings��52   &   $��Cài đặt��6:   #���  6L     settings# �  6{   55      F� 57      $��3��6     information#���  6(     TertiaryTextColor#���  6M   $
��Left=�6x   $��Center=�6�   $��20 0 0 0q�6�   �� 58      $��3��6   $ 18��6*   $	��110��6<   $��35��6H   #���  6T   $��Right=�6�   $��0 0 20 0q�6�   ._�59      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5:      F�   sun#���  6#   $��16��6@   $��16��6L    �� Stretch$ UniformToFill=�6W   #���  6o   $��Center=�6�   d� 5;      -   5         d�Name$ Themes��5;   +    d� 	IsChecked$ FalseY�5<      $��Right=�5>        ToggleButtonStyle#���  5?      $��	10 0 10 0q�5@      F� 5A        moon#���  6#   $��16��6A   $��16��6M   $
 Fill=�6X     PrimaryWhiteColor#���  6g   $��Center=�6�   5B      5J      5L      5M      � 5P      $��1��6   
 5Q      �� 5R      $	��100 �6$   �� 5S      .+�5V      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $ 
Horizontal=�6�   $��RightToLeft=�6�   .+�5W      �� -   5         ��Name$ btnClose��5W        IconButtonsStyle#��[ 6/    	 close#���  6Y   $ IsCloseButton��6�   �� 5X      -   5        $ 
btnRestore��5X      $	��5 0q�61   ��5Y      �� 5Z       �� 
TargetType" ��6$    �� BasedOn# [ 6A   .�5[   "   ��  �� Property � ��  maximize �� Value# �  6<    �� Triggers 5\   "   �� 5]   &    �� Binding 62   ��  �� ElementName$
 home�� �� Path$ WindowState� �� Value 	Maximized6i   .a�5^   *   ��  � ��  restore# �  6D   5_   '   5a      5c      �� 5d      -   5        $ btnMinimize��5d      #���  62     minimize#���  6]   6�   5e      �� 5f      $ 
Horizontal=�6   $��Right=�66   $��	0 35 30 0q�6R   .+�5g      �� $ 50��6   $��50��6/   $��50��6:   $��1q�6F   ���	#FF91F9F9._�5h      A� ��5i      �� 5j   "    �� ImageSource$4 ./imgs/Huỳnh Ngọc Luận_TD00468_SD1701.jpg��6-   5l      5m      �� 5o      $��10 0 0 0q�6!   $��Center=�63   .+�5p      �� $��Huỳnh Ngọc Luận��6$   $��18(�6;     PrimaryTextColor#���  6I   �� 5q      $��
Quản lí��6$   $��15(�63   #���  6A   $
��Bold"�6q   5r      5s      �� 5x      $��1��6   $ 0 0 5 0��6&   
������ ._�5y       � -   5          �Name$ frameContent��5y        � NavigationUIVisibility$ Hidden=�62   $��40 20q�6R   5{      5~      5      5�      5�      