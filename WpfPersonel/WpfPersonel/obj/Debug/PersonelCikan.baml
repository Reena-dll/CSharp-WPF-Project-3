   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.PersonelCikan   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:WpfPersonel  5   	   -   5          � Title$  PersonelCikan��5	   	   $	��540��5
   
   $	��700��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   ���#FF004C.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MyGrid��5      $	��262��6#   $��
95,83,95,0q�60   $	��Top=�6D   6\   �� 5   
   $	��178��6   $��166,352,133,0q�6#   $	��Top=�6:   .+�5      �� $��5q�6    �� Orientation$ 
Horizontal=�6$   .+�5      �� $��Personel ID:       ��6   
�������$��5q�6J   6W   �� 5      -   5         ��Name$ txtPersonelID��5      $
��10,0q�61   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Personel ID��6?   
�������$	��250��6   
������� �� 
CaretBrush
 �   �	 �� SelectionBrush
	 �   �{�.  6�   5      �� 5      $��5q�6   $ 
Horizontal=�6$   .+�5      �� $��Personel Ad:      ��6   
�������$��5q�6I   6V   �� 5      -   5        $ txtPersonelAd��5      $
��10,0q�61   $ Personel Ad��6?   
�������$	��250��6   
�������
 �   �
	 �   �{�.  6�   5      �� 5      $��5q�6   $ 
Horizontal=�6$   .+�5      �� $��Personel Soyad:��6   
�������$��5q�6F   6S   �� 5      -   5        $ txtPersonelSoyad��5      $
��10,0q�64   $ Personel Soyad��6B   
�������$	��250��6�   
�������
 �   �
	 �   �{�.  6�   5       �� 5!      $��100,10,0,10q�6   $ 
Horizontal=�6.   $	��106��6G   .+�5"      �� -   5        
 ��Name$
 	btnKaydet��5"      $��10q�6-   $��İşe Geri Al��6:   $
��Left=�6P   $	��Top=�6k   $	��107��6�   $��36��6�    J� RenderTransformOrigin$ 	0.491,0.5&�6�   6�   �� 5#      -   5        $
 
btnTemizle��5#      $��
10,10,10,0q�6.   $��Temizle��6C   $
��Left=�6U   $	��Top=�6p   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   5$      5(      �� 5)   
   -   5        $
 btnExit��5*   "   $
��Left=�5)      $��634,10,0,474q�6-    &  "MaterialDesignFloatingActionButton#��[  6C    � ToolTip$ Close��5*      $ 0.464,0.482&�6I   ��5)      Z� .��5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   
�������$��30��6F   $��30��6Q   5,      5.      5/      