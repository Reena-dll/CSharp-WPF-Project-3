   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.Menu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:WpfPersonel  5   	   -   5          � Title$  Giriş Formu��5	   	   $	��540��5
   	   $	��700��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   
������ .��5      �  � ColumnDefinitions 5   
   �� 5      $
��381* �6   �� 5      $��0* �6   �� 5      $
��319* �6   ��5   
   �� 5      .��5      �  � Color$ Transparent��6   5      .+�5   
   ��  �� CornerRadius$ 40,40,40,40��6   ���#FF004C$��3��6A   5      �� 5    
    �� Orientation$ 
Horizontal=�6   $��3��6.   .+�5!      �� $	��350��6   .+�5"      �� -   5         ��Name$ lblAktifKullanici��5"      $�� ��63   
���   �
��� � �$��15(�6e   $��Center=�6s   $��Century Gothic)�5#      $
��Bold"�60   $��0q�6B   $��5,5,5,5q�6V   5$      �� 5%      $��İmage/9cV8Ji.png��6   $	��350��62   $	��350��6>   $��
0,10,30,30q�6L   $	��Top=�6`   $
��Fill=�6x   6�   �� 5&      $��ouz.spy@gmail.com��6   
���   �
�������$��20(�6[   $��Center=�6i   $��Century Gothic)�5'      $
��Bold"�60   $��0q�6B   $��10,20,10,10q�6V   5(      �� 5)      -   5        $ ___No_Name_��5)      $��Oğuzhan Sadıkoğlu��6-   
���   �
�������$��20(�6p   $��Center=�6~   $��Century Gothic)�5*      $
��Bold"�60   $��0q�6B   5+      5,      �� 5-      $	��350��6   .+�5/      �� $��
0,10,10,10q�6   $��Right=�61   $	��330��6M   .+�51      �� -   5        	 ��Name$	 btnExit��52   "   $��10q�51       &  "MaterialDesignFloatingActionButton#��[  6)   
 � ToolTip$
 Close��52      $��Right=�6I   ��51   e   Z� .��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	CloseBold=�62   
�������$��30��6V   $��30��6a   54      �� 55      -   5        $ label3��55      $�� ��6,   
���   �
��� � �$��15(�6^   $��Century Gothic)�56      $
��Bold"�60   $��0q�6B   $
��Left=�6V   57      59      �� 5:      $
��Left=�6   5<      �� 5=      $	��0,0q�6   .+�5>      �� $��
Seçim Yap��6    $��10q�61   
������� �� TextAlignment$ Center=�6P   $��30(�6g   $��Century Gothic)�6u   $
��Bold"�6�   �� 5?      $ 
Horizontal=�6!   $��0q�6:   .+�5@      �� -   5        $	 btnPersoneller��5B   V   $	��110��5@   !   $	��110��6-   $��
45,30,0,30q�6:     MaterialDesignRaisedButton#��[ 6N   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5A      $��2q�6H   
�������
���   �
�������$
 Personeller��5B   @   $��Personeller��6�   �� 5C      -   5        $	 btnGiderler��5E   S   $	��110��5C   !   $	��110��6-   $��30q�6:   #��[ 6F   $ 10��5D      $��2q�6H   
�������
���   �
�������$
 Giderler��5E   @   $��Giderler��6�   5F      �� 5G      $ Vertical=�6!   $��0q�68   .+�5H      �� -   5        $	 btnMusteriler��5J   U   $	��110��5H   !   $	��110��6-   $��30q�6:   #��[ 6F   $ 10��5I      $��2q�6H   
�������
���   �
�������$
 Müşteriler��5J   @   $��Müşteriler��6�   5K      5M      5O      5Q      5R      5T      