   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.Musteriler   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:WpfPersonel  5   	   -   5          � Title$  
Musteriler��5	   	   $	��600��5
   	   $��1396.5��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   
�������.��5      � $��	0,0,0,-42q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      $
��Left=�6&   $	��567��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $
��1112��6y      MinRowHeight$ 30Q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 120 6�      AutoGenerateColumns . ��6�   �� 6�   �� 5   
   $
��Left=�6   $	��599��60   $��
1122,0,0,0q�6=   $	��Top=�6Q   $	��273��6i   
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      �� $	��ID:��6   $��5q�6'   64   �� 5      -   5        	 ��Name$	 txtMusteriID��5      $
��10,0q�60   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Müşteri İD��6>   
���   �$	��200��6}   
���   � �� 
CaretBrush
 ����� �� SelectionBrush
 �����{�.  6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $	��Ad:��6   $��5q�6'   64   �� 5      -   5        $	 txtMusteriAd��5      $
��10,0q�60   $
 Müşteri Ad��6>   
���   �$	��200��6}   
���   �
 �����
 �����{�. 6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Soyad:��6   $��5q�6*   67   �� 5       -   5        $	 txtMusteriSoyad��5       $
��10,0q�63   $
 Müşteri Soyad��6A   
���   �$	��200��6�   
���   �
 �����
 �����{�. 6�   5!      �� 5"      $ 
Horizontal=�6   $��10q�62   .+�5#      �� $��Telefon:��6   $��5q�6,   69   �� 5$      -   5        $	 
txtTelefon��5$      $
��10,0q�6.   $
 Müşteri Telefon��6<   
���   �$	��200��6�   
���   �
 �����
 �����{�. 6�   5%      �� 5'      $ 
Horizontal=�6   $��10q�62   .+�5(      �� $��Mail:��6   $��5q�6)   66   �� 5)      -   5        $	 txtMail��5)      $
��10,0q�6+   $
 Müşteri Mail��69   
���   �$	��200��6z   
���   �
 �����
 �����{�. 6�   5*      �� 5+      $ 
Horizontal=�6   $��10q�62   .+�5,      �� $��Şehir:��6   $��5q�6*   67   �� 5-      -   5        $��cmbSehir��5-      $	��200��6,    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Şehir Seç��6\   
���   �{�.  �� DisplayMemberPath$ sehir��6�    �� SelectedValuePath$ id��6�   ��6�   �� 6�   5.      �� 5/      $ 
Horizontal=�6   $��10q�62   .+�50      �� $��İlçe:��6   $��5,5,20,0q�6)   6=   �� 51      -	   5        $��cmbIlce��51      $	��200��6+    .  . $ İlçe Seç��6[   
���   �{�. $ sehir��6�   $ id��6�   ��6   �� 52      53      �� 55      $ 
Horizontal=�6   $��10q�62   .+�56      �� $��Adres:��6   $��5q�6*   67   �� 57      -
   5         ��Name$ rchAdres��57      $	��200��61   $��75��6=   $
��10,0q�6I   $
 Adres��6W   
���   �
���   �
 �����
 �����{�. 6�   58      5:      �� 5;   
   -   5         ��Name$ btnGuncelle��5;      $��	Güncelle��6&   $
��Left=�69   $��1268,437,0,0q�6T   $	��Top=�6j   $	��107��6�   $��36��6�    J� RenderTransformOrigin$ 	0.491,0.5&�6�   6�   �� 5<   
   -   5        $ 
btnTemizle��5<      $��Temizle��6%   $
��Left=�67   $��1268,497,0,0q�6R   $	��Top=�6h   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5=   
   -   5        $ 	btnKaydet��5=      $��Kaydet��6$   $
��Left=�65   $��1143,437,0,0q�6P   $	��Top=�6f   $	��107��6~   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5>   
   -   5        $ btnMüsteriSil��5>      $��Müşteri Sil��6(   $
��Left=�6>   $��1143,497,0,0q�6Y   $	��Top=�6o   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5?   
   -   5        $ 
btnGeriGel��5?      $��Geri Gel��6%   $
��Left=�68   $��1198,551,0,0q�6S   $	��Top=�6i   $	��125��6�   $��36��6�   $ 1.051,0.743&�6�   6�   5A      5B      