   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.Personeller   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:WpfPersonel  5   	   -   5          � Title$  Personeller��5	   	   $	��600��5
   
   $��1396.5��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   
�������.��5      � $��	0,0,0,-42q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      $
��Left=�6&   $	��450��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $
��1112��6y      MinRowHeight$ 30Q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 90 6�      AutoGenerateColumns .  ��6�   �� 6�   �� 5   
   $
��Left=�6   $	��599��60   $��
1122,0,0,0q�6=   $	��Top=�6Q   $	��273��6i   
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      �� $	��ID:��6   $��5q�6'   64   �� 5      -   5        	 ��Name$	 txtPersonelID��5      $
��10,0q�61   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Personel İD��6?   
���   �$	��200��6   
���   � �� 
CaretBrush
 ����� �� SelectionBrush
 �����{�.  6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $	��Ad:��6   $��5q�6'   64   �� 5      -   5        $	 txtPersonelAd��5      $
��10,0q�61   $
 Personel Ad��6?   
���   �$	��200��6   
���   �
 �����
 �����{�. 6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Soyad:��6   $��5q�6*   67   �� 5      -   5        $	 txtPersonelSoyad��5      $
��10,0q�64   $
 Personel Soyad��6B   
���   �$	��200��6�   
���   �
 �����
 �����{�. 6�   5      �� 5       $ 
Horizontal=�6   $��10q�62   .+�5!      �� $��Telefon:��6   $��5q�6,   69   �� 5"      -   5        $	 txtPersonelTelefon��5"      $
��10,0q�66   $
 Personel Telefon��6D   
���   �$	��200��6�   
���   �
 �����
 �����{�. 6�   5#      �� 5$      $ 
Horizontal=�6   $��10q�62   .+�5%      �� $��TC:   ��6   $��5q�6*   67   �� 5&      -   5        $	 txtTC��5&      $
��10,0q�6)   $
 Personel TC��67   
���   �$	��200��6w   
���   �
 �����
 �����{�. 6�   5'      �� 5(      $ 
Horizontal=�6   $��10q�62   .+�5)      �� $��Mail:��6   $��5q�6)   66   �� 5*      -   5        $	 txtMail��5*      $
��10,0q�6+   $
 Personel Mail��69   
���   �$	��200��6{   
���   �
 �����
 �����{�. 6�   5+      �� 5,      $ 
Horizontal=�6   $��10q�62   .+�5-      �� $��Şehir:��6   $��5q�6*   67   �� 5.      -	   5        $��cmbSehir��5.      $	��200��6,    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Şehir Seç��6\   
���   �{�.  �� DisplayMemberPath$ sehir��6�    �� SelectedValuePath$ id��6�   ��6�   �� 6�   5/      �� 50      $ 
Horizontal=�6   $��10q�62   .+�51      �� $��İlçe:��6   $��5,5,20,0q�6)   6=   �� 52      -
   5        $��cmbIlce��52      $	��200��6+    .  . $ İlçe Seç��6[   
���   �{�. $ sehir��6�   $ id��6�   ��6   �� 53      54      �� 55      $ 
Horizontal=�6   $��10q�62   .+�56      �� $��Görev:��6   $��5q�6*   67   �� 57      -   5        $��cmbGorev��57       .  . $ Görev Seç��6P   $	��200��6b   
���   �{�. $ sehir��6�   $ id��6�   ��6�   �� 58      59      �� 5:      $ 
Horizontal=�6   $��10q�62   .+�5;      �� $��Kullanıcı Ad:   ��6   $��5q�64   6A   �� 5<      -   5        $	 txtKullaniciAdi��5<      $
��10,0q�63   $
 Kullanıcı Ad��6A   
���   �$	��150��6�   
���   �
 �����
 �����{�. 6�   5=      �� 5>      $ 
Horizontal=�6   $��10q�62   .+�5?      �� $��Kullanıcı Şifre:��6   $��5q�64   6A   �� 5@      -   5        $	 txtKullaniciSifre��5@      $
��10,0q�65   $
 Kullanıcı Şifre��6C   
���   �$	��150��6�   
���   �
 �����
 �����{�. 6�   5A      �� 5B      $ 
Horizontal=�6   $��10q�62   .+�5C      �� $��Adres:��6   $��5q�6*   67   �� 5D      -   5         ��Name$ rchAdres��5D      $	��200��61   $��75��6=   $
��10,0q�6I   $
 Adres��6W   
���   �
���   �
 �����
 �����{�. 6�   5E      5G      �� 5J   
   $
��Left=�6   $	��122��60   $��
10,477,0,0q�6=   $	��Top=�6Q   $	��256��6i   .+�5K      �� $ 
Horizontal=�6   $��10q�62   .+�5L      �� $"��Toplam Çalışan Sayısı: ��6   $��5q�6;   $
��Bold"�6F   $��15(�6X   $��Arial)�6f   6{   �� 5M      -   5         ��Name$ lblCalisanSayi��5M      $��00��64   $��5q�6>   $
��Bold"�6I   $��15(�6[   $��Arial)�6i    J� RenderTransformOrigin$ 0.176,0.706&�6|   6�   5O      �� 5P      $ 
Horizontal=�6   $��10q�62   .+�5Q      �� $&��      İşten Ayrılan Sayısı: ��6   $��5q�6?   $
��Bold"�6J   $��15(�6\   $��Arial)�6j   6   �� 5R      -   5        $ lblistencikan��5R      $��00��63   $��5q�6=   $
��Bold"�6H   $��15(�6Z   $��Arial)�6h   $ 0.176,0.706&�6{   6�   5T      5V      �� 5W   
   -   5        $��İşten Çıkanlar��5W      $
��Left=�6*   $��288,477,0,0q�6E   $	��Top=�6Z   $	��145��6r   $ -0.267,-0.188&�6~   $��51��6�   6�   �� 5X   
   -   5         ��Name$ btnAra��5X      $	��Ara��6!   $
��Left=�6/   $��719,492,0,0q�6J   $	��Top=�6_   $��55��6w   $��36��6�   �� 5Y   
   -   5        $��	Görevler��5Y      $
��Left=�6$   $��288,537,0,0q�6?   $	��Top=�6T   $	��145��6l   $ -0.267,-0.188&�6x   $��51��6�   6�   �� 5Z   
   -   5        $ btnGuncelle��5Z      $��	Güncelle��6&   $
��Left=�69   $��991,477,0,0q�6T   $	��Top=�6i   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5[   
   -   5        $ 
btnTemizle��5[      $��Temizle��6%   $
��Left=�67   $��991,537,0,0q�6R   $	��Top=�6g   $	��107��6   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5\   
   -   5        $ 	btnKaydet��5\      $��Kaydet��6$   $
��Left=�65   $��866,477,0,0q�6P   $	��Top=�6e   $	��107��6}   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5]   
   -   5        $ btnIstenCıkar��5]      $��İşten Çıkar��6(   $
��Left=�6>   $��866,537,0,0q�6Y   $	��Top=�6n   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5^   
   -   5        $	 txtAra��5^      $
��Left=�6"   $��36��6=   $��457,492,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	
 Ara��6�   
���   �$��18(�6�   $	��247��6�   
���   �
 �����
 �����{�. 6+  �� 5_   
   -   5        $ 
btnGeriGel��5_      $��Geri Gel��6%   $
��Left=�68   $��649,552,0,0q�6S   $	��Top=�6h   $	��125��6�   $��36��6�   $ 0.491,0.556&�6�   6�   5a      5b      