   M S B A M L   `   `   `  ����J  FMVVMKioskSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMKioskSystemMVVMKioskSystem  5      %    MVVMKioskSystem.LoginWindowView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMKioskSystem     5        � 	Resources  5	       �� 
TargetType   CredLblStyle �� Property �� Value  CredTxtStyle��%x  &	        &	 �     �� 5
   
   " ��6   .�5      ��  � ��$	 100��6&   5      �� 5       � ��$ 17(�6)   5      �� 5       � ��$ SemiBold"�6+   5      5      �� 5   
   " ��6   .�5      ��  � ��$	 250��6&   5      �� 5       � ��$ 17(�6)   5      �� 5       � ��$ SemiBold"�6+   5      5      5       .��5!      � .+�5"   
   �� $	��410��6   $	��400��5#      
�������$��1q�5%       �� CornerRadius$ 5��5&      
������� J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      5,      �� 5.   
   $	��400��6   $	��200��5/      .+�50      �� $��10q�6    �� Orientation$ 
Horizontal=�6%   .+�51      �� $��	UserName:��6   #��[  6,   52      �� 53      #��[ 64   ��6   �� *
UserName+6\   54      �� 55      $��10q�6   $ 
Horizontal=�6%   .+�56      �� $��	Password:��6   #��[  6,   57      �� 58      #��[ 65   ��6   �� *
Password+6]   59      �� 5:      $��50��6   $	��100��5;      $
��0,40q�5<      
����İ�$��Login��5>      
�������$��17(�5@      $
��Bold"�5A      $��0q�5B      ��5C      �� *LoginCommand+  5D      ��%^   '��       �� 5E      " ��6   .�5F      ��  �@��CornerRadius$ 3��69   5G      5H      5I      5J      5K      5L      