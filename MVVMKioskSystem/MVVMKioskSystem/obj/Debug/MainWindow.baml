   M S B A M L   `   `   `  ����J  FMVVMKioskSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MVVMKioskSystemMVVMKioskSystem  5   	        MVVMKioskSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MVVMKioskSystem     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�65    � 
ResizeMode$ NoResize=�6M    � DataContext 5	      )   #MVVMKioskSystem.MainWindowViewModel  5
   
   5       � 	Resources 5       �� DataType)   #MVVMKioskSystem.UserWindowViewModel$   MVVMKioskSystem.UserWindowView*   $MVVMKioskSystem.LoginWindowViewModel%   MVVMKioskSystem.LoginWindowView*   $MVVMKioskSystem.AgentWindowViewModel%   MVVMKioskSystem.AgentWindowView*   $MVVMKioskSystem.AdminWindowViewModel%	   MVVMKioskSystem.AdminWindowView*
   $MVVMKioskSystem.TokenSearchViewModel$   MVVMKioskSystem.TokenViewModel)   #MVVMKioskSystem.BulkSearchViewModel#   MVVMKioskSystem.BulkViewModel��%�  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   " 
 6   .R�5        5      �� 5   
   "  6   .R�5        5      5       .��5!      � .+�5"   
   �� ��6   �� *
ActiveView+6<   5#      5$      