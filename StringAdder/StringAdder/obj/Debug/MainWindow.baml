   M S B A M L   `   `   `  ����F  BStringAdder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:StringAdderStringAdder  5   	       StringAdder.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:StringAdder     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65    � DataContext 5	      %   StringAdder.MainWindowViewModel  5
   
   5      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $	��600��5      $	��400��5      ���#eeeeee.+�5      �� $ 
Horizontal=�6   $��35��5      $
��0,20q�5      $��Center=�5      .+�5      �� $��35��5      $	��150��5      $
��40,0q�5      ��5      �� *SelectedItem.Content+.��5   (   5      �� 5      $��20��6   $��70��5      $��+��5      $
��Bold"�5      ��5       �� *AddButtonCommand+5"      5#      �� 5*      -   5        $��ItemObj��5+      ��5*      �� *Items+��5,      �� 5-      .R�5.      �� $ 
Horizontal=�6%   $��35��5/      $
��0,20q�50      $��Center=�51      .+�52      �� $��35��53   &   $	��150��54   &   $
��40,0q�55   &   ��52   &   ��  �� Path$ Content� �� UpdateSourceTrigger$ PropertyChanged=�.��55   4   57      �� 58      $��20��6%   $��70��59   %   $��-��5:   %   $
��Bold"�5;   %   ��5<   %   �� *DeleteButtonCommand+5>      5?      5@      5B      �� 5D      $��17(�6   $
��0,20q�5E      ��5F      �� *DisplayString+5H      5I      5J      5K      