   M S B A M L   `   `   `  ����@  <Exam2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Exam2Exam2  5   	       Exam2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Exam2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65    � 
ResizeMode$ NoResize=�6M    � DataContext 5	         Exam2.MainWindowViewModel  5
   
    � 	Resources 5       �� DataType   Exam2.AboutView   Exam2.HomeView   Exam2.GalleryView��%�  (��       5      *x:Type local:AboutViewModel+)(�� O     5      *x:Type local:HomeViewModel+)(�� �     5      *x:Type local:GalleryViewModel+)�� 5   
   $! x:Type local:AboutViewModel��6   .R�5        5      �� 5   
   $  x:Type local:HomeViewModel��6   .R�5        5      �� 5   
   $# x:Type local:GalleryViewModel��6   .R�5        5      5      .��5      �� .+�5   
   �� -   5         ��Name$ 
PageNavbar��5      ��6+   �� *Pages+��5      �� 5      .R�5      �� $��40��6!    �� Orientation$ 
Horizontal=�5   !   $	��Top=�5   !   5      5       ��5"      �� 5#      .R�5$      �� $��17(�6   $
��Bold"�5%      ���#7E7F9A$��1q�5'      ��5)      �� *
PageName+��5*      ��  �� ElementName$ 
PageNavbar��	 �� Path$!	 DataContext.NavigateCommand�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   5+      5-      �� 5.   
   $
��1000��6   
�������.+�50      �� ��6   �� *
ActiveView+$
 PropertyChanged=�52      53      54      55      