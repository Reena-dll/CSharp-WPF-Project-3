   M S B A M L   `   `   `  ����F  BWpfPersonel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfPersonelWpfPersonel  5   	       WpfPersonel.Gorevler   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:WpfPersonel  5   	   -   5          � Title$  Gorevler��5	   	   $	��540��5
   	   $	��700��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   ���#FF004C.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MyGrid��5      $	��262��6#   $��
95,83,95,0q�60   $	��Top=�6D   6\   �� 5   
   $	��178��6   $��165,362,134,0q�6#   $	��Top=�6:   .+�5      �� $��10q�6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��	ID:      ��6   
�������$��5q�6@   6M   �� 5      -   5         ��Name$ 
txtGorevID��5      $
��10,0q�6.   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Görev ID��6<   
�������$	��250��6y   
������� �� 
CaretBrush
 �   �	 �� SelectionBrush
	 �   �{�.  6�   5      �� 5      $��10q�6   $ 
Horizontal=�6%   .+�5      �� $��Görev:��6   
�������$��5q�6=   6J   �� 5      -   5        $ 
txtGorevAd��5      $
��10,0q�6.   $ Görev Adı��6<   
�������$	��250��6z   
�������
 �   �
	 �   �6�   5      �� 5      $��
0,10,10,10q�6   $ 
Horizontal=�6-   .+�5      �� -   5        
 ��Name$
 btnGuncelle��5      $��10q�6.   $��	Güncelle��6:   $
��Left=�6M   $	��Top=�6i   $	��107��6�   $��36��6�    J� RenderTransformOrigin$ 	0.491,0.5&�6�   6�   �� 5      -   5        $
 
btnTemizle��5      $��10q�6/   $��Temizle��6;   $
��Left=�6M   $	��Top=�6i   $	��107��6�   $��36��6�   $ 	0.491,0.5&�6�   6�   �� 5       -   5        $
 	btnKaydet��5       $��10q�6-   $��Kaydet��6:   $
��Left=�6K   $	��Top=�6f   $	��107��6~   $��36��6�   $ 	0.491,0.5&�6�   6�   5"      5&      �� 5'   
   -   5        $
 btnExit��5(   "   $
��Left=�5'      $��634,10,0,474q�6-    &  "MaterialDesignFloatingActionButton#��[  6C    � ToolTip$ Close��5(      $ 0.464,0.482&�6I   ��5'      Z� .��5)      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   
�������$��30��6F   $��30��6Q   5*      5,      5-      