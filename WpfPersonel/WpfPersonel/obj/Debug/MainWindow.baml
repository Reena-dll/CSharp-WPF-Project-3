   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:WpfPersonel  5   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	   -   5          �Name$  FrmGiris��5   K    � Title$ Giriş Formu��5
   	   $	��540��5   	   $	��700��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   
������ .��5      � -   5         � ColumnDefinitions 5   
   �� 5      $
��381* �6   �� 5      $��0* �6   �� 5      $
��319* �6   ��5   
   �� 5      .��5      �  � Color$ Transparent��6   5      .+�5    
   �� -   5         �� CornerRadius$ 40,40,40,40��5       ���#FF004C$��3��6A   5"      �� 5#   
    �� Orientation$ 
Horizontal=�6   $��3��6.   .+�5$      �� $	��350��6   .+�5%      �� $��İmage/9cV8Ji.png��6   $	��350��62   $	��350��6>   $��
0,45,30,30q�6K   $	��Top=�6_   $
��Fill=�6w   6�   �� 5&      $��ouz.spy@gmail.com��6   
���   �
�������$��20(�6[   $��Center=�6i   $��Century Gothic)�5'      $
��Bold"�60   $��0q�6B   $��10,20,10,10q�6V   5(      �� 5)      -   5        	 ��Name$	 ___No_Name_��5)      $��Oğuzhan Sadıkoğlu��6-   
���   �
�������$��20(�6p   $��Center=�6~   $��Century Gothic)�5*      $
��Bold"�60   $��0q�6B   5+      5,      �� 5-      $	��350��6   .+�5.      �� $��10q�6   $��Right=�6)   .+�5/      �� -   5        
 ��Name$
 btnExit��50   "   $��10q�5/       &  "MaterialDesignFloatingActionButton#��[  6)    � ToolTip$ Close��50      ��5/   e   Z� .��52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   
�������$��30��6R   $��30��6]   53      54      �� 55      $
��10,0q�6   .+�56      �� $��
Giriş Yap��6    $��20q�61   
������� �� TextAlignment$ Center=�6P   $��30(�6g   $��Century Gothic)�6u   $
��Bold"�6�   6�   �� 57      $ 
Horizontal=�6!   $��10q�6:   .+�58        $
 User=�62   $��30��6>   $��30��6I   
�������6U   �� 59      -   5         ��Name$ txtUsername��59   "   $
��10,0q�67   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Kullanıcı Adını Giriniz��6E   
�������$	��250��6�   
������� �� 
CaretBrush
 �   � �� SelectionBrush
 �   �6�   5:      �� 5;      $ 
Horizontal=�6!   $��10q�6:   .+�5<        $
 Lock=�62   $��30��6>   $��30��6I   
�������6U   G� 5=      -   5         G�Name$ txtPassword��5=   &   $
��10,0q�6;   $ 	*********��6I   
�������$	��250��6�   
������� G� 
CaretBrush
 �   � G� SelectionBrush
 �   �6�   5>      �� 5?      $��10q�6!   $
��Left=�6-   .+�5@      �� -   5         ��Name$ chcBeniHatirla��5B   �   $	��100��5@   #   $��30��6/   $��Beni Hatırla��6;      MaterialDesignAccentCheckBox#��[ 6R   -  'MaterialDesignThemes.Wpf.CheckBoxAssist   CheckBoxSize$ 20Q�5A   #   $��2q�6S   ���#D94448
�������
�������$��14(�5B   J   $��Century Gothic)�6X   $ Check��6v   5C   &   5D      �� 5E      $��5q�6!   $
��Left=�6,   .+�5F      �� -	   5         ��Name$ txtBilgiSifirla��5F   $   $��Bilgilerimi Sıfırla��6=   $��10q�6X   
�������$ Center=�6w   $��14(�6�   $��Century Gothic)�6�   6�   5G      �� 5H      $��5q�6!   $��Center=�6,   .+�5I      �� -
   5        $
 btnLogin��5K   R   $	��100��5I   !   $��40��6-     MaterialDesignRaisedButton#��[ 69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5J      $��2q�6H   ���#D94448���#D94448
�������$ Login��5K   B   $��
Giriş Yap��6{   5L      5M      5N      5P      5Q      5S      