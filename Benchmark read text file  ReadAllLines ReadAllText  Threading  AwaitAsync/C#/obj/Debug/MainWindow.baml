   M S B A M L   `   `   `  ����L  HBenchmarkReadFile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BenchmarkReadFileBenchmarkReadFile  5   	   "    BenchmarkReadFile.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:BenchmarkReadFile     5   	     � Title$  Benchmark Read File��5   	   $	��350��6%   $	��525��62   .��5      � .+�5   
   �� -   5         ��Name$ btnReadFileThread��5      $��Read File Thread��6,   $
��Left=�6G   $��	16,10,0,0q�6b   $	��Top=�6u   $	��120��6�    � ToolTip$ Read ALL strings ...��6�   6�   �� 5   
   -   5        $ btnReadLineByLine��5      $��Read All Text ��6,   $
��Left=�6E   $��
340,10,0,0q�6`   $	��Top=�6t   $	��121��6�   $6 0Read ALL strings in one  String ... limit 2G ...��6�   6�   �� 5	   
   -   5         ��Name$ lblReadFileThread��5	      $��Time - Read File��6+   $
��Left=�6F   $��	16,37,0,0q�6a   $	��Top=�6t   $	��153��6�   �� 5
   
   -   5        $ lblReadAllText��5
      $��Limit  2 GB ...��6(   $
��Left=�6B   $��
340,37,0,0q�6]   $	��Top=�6q   $	��164��6�   �� 5   
   -   5        $ btnReadFileAsync��5      $��Read File Async��6+   $
��Left=�6E   $��
173,10,0,0q�6`   $	��Top=�6t   $	��120��6�   $ Read ALL strings ...��6�   6�   �� 5   
   -   5        $ lblReadFileAsync��5      $��Time - Read File��6*   $
��Left=�6E   $��
174,37,0,0q�6`   $	��Top=�6t   $	��153��6�   !   BenchmarkReadFile.userClock  5   
   -   5          Name$ usrClk��5      $
��Left=�6*   $	��122��6E   $��174,152,0,0q�6R   $	��Top=�6g   $	��119��6   �� 5   
   -   5        $ 	lblThread��5      $��Thread��6#   $
��Left=�64   $��	16,98,0,0q�6O   $	��Top=�6b   $	��120��6z   �� 5   
   -	   5        $ lblAsync��5      $��Await/Async��6"   $
��Left=�68   $��
174,98,0,0q�6S   $	��Top=�6g   $	��119��6   �� 5   
   -
   5        $ 
lblTextAll��5      $��ReadTextAll��6$   $
��Left=�6:   $��
340,98,0,0q�6U   $	��Top=�6i   $	��121��6�   5      5      