   M S B A M L   `   `   `  ����J  FMVVMKioskSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMKioskSystemMVVMKioskSystem  5      %    MVVMKioskSystem.AgentWindowView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MVVMKioskSystem     5        � 	Resources  5	       �� 
TargetType   CredLblStyle �� Property �� Value  CredTxtStyle��%x  &	        &	 �     �� 5
   
   " ��6   .�5      ��  � ��$	 100��6&   5      �� 5       � ��$ 17(�6)   5      �� 5       � ��$ SemiBold"�6+   5      5      �� 5   
   " ��6   .�5      ��  � ��$	 250��6&   5      �� 5       � ��$ 17(�6)   5      �� 5       � ��$ SemiBold"�6+   5      5      5       .��5!      � .+�5"   
   �� $	��110��6   $	��260��5#      
�������$��1q�5%       �� CornerRadius$ 5��5&      ���#eeeeee J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      5,      �� 5.   
    �� Orientation$ 
Horizontal=�6   $	��250��5/      $	��100��50      .+�51      �� $	��100��6   $	��250��52      $��0q�53      ��54      �� *AgentViewModels+ �� SelectedItem 55      �� *SelectedAgentViewModel+��56      �� 57      .R�58      �� ��6    �� *
PageName+6?   59      5;      5<      �� 5>   
   $ 
Horizontal=�6   $	��800��5?      $	��100��5@      $��Right=�5A      .+�5B      � .+�5C      �� $��60��6   $	��150��5D      
�������$��1q�5F      $ 40��5G      ���#eeeeee 5J        5K      5M      �� 5N      $��60��6   $	��150��5O      ���#7E7F9A$��	Move To >��5Q      $
��Bold"�5R      
�������$��20(�5T      ��5U      �� *MoveToCommand+  5W      ��%_   '��       �� 5X      " ��6    .�5Y      ��  �@��CornerRadius$ 35��6=   5Z      5[      5\      5^      5`      5b      5c      