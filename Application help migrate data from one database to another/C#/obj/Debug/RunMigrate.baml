   M S B A M L   `   `   `  ����L  HWpfHelperCopyData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfHelperCopyDataWpfHelperCopyData  5   	   !    WpfHelperCopyData.RunInsert   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:WpfHelperCopyData     5   	   -   5          �Name$  
RunInsert1��5   7    � Title$= 7Run Delete/Insert SQL code - connection  string [B]... ��5   	   $��141.176��6I   $��608.235��6Z    � ToolTip$% Windows Allow You Run SQL CODE.��6j    � Icon$ AP.ico��6�   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5	      �  � Color$ 	#FFC7C7C7��6    � Offset$ 0.005Q�61   � 5
      $ White��6   $ 1Q�6-   5      .+�5   
   �� -   5         ��Name$ btnRun��5      $��RUN SQL��6!   $��	0,17,44,0q�63   $	��Top=�6F   	 �� IsCancel	 . {�.  $��25��6�   $��Right=�6�   $	��130��6�   �� 5   
   -   5        
 ��Name$
 chkBoxUnblock��5      $��UnBlock RUN SQL button...��6*   $��Right=�6N   $��
0,20,200,0q�6j   $	��Top=�6~   $ Unblock��6�   6�   � 5   
   -   5         �Name$ 	prgResult��5      $��0,0,1,0q�6)   $��13��6:   $��Bottom=�6F   �� 5   
   -   5        $ btnSave��5      $#��Save "Migrate SQL"  If Needed��6"   $
��Left=�6T   $��	20,17,0,0q�6o   $	��Top=�6�   $	��185��6�   $��25��6�   $* $You do not need to save SQL code ...��6�    �� 	IsDefault . 6�   5      5      