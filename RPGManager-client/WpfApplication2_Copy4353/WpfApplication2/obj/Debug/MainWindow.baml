   M S B A M L   `   `   `  ����  WpfApplication2     WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  
MainWindow��5   	   $	��648��6   $	��887��6)    � 
ResizeMode$ CanResizeWithGrip=�65    � 	Resources 5         	OnLoaded1��%   &	        �� 5      6   5       � Triggers 5	      :� 5
       :� RoutedEvent$ FrameworkElement.Loaded��6   .��5      � .+�5   
   o� $
��Left=�6   $��21��6*   $	��Top=�66   $	��879��6N   .@�5      m� -   5         m�Name$ OpcjaGM1��5      $��Polacz��6    $��21��60   $��84��6<   6G   5      �� 5      -   5         ��Name$ KartaPostaci��5      $
��Left=�6"   $	��297��6=   $��0,22,0,0q�6J    �� TextWrapping$
 Wrap=�6\   $��Karta postaci:��6p   $	��Top=�6�   $	��607��6�   ���	#FFDEDEDE
���   � �� 
IsReadOnly . 6�   �� 5      -   5        	 ��Name$	 Notatki��5      $
��Left=�6!   $	��297��6<   $��
612,22,0,0q�6I   $	��Top=�6]   $	��257��6u   ���	#FFFFFDC9
���   �$��Italic$�6�   
 �� 
AcceptsTab
 .  � ContextMenu 5      �� 5       J� 	AllowDrop . 6   . �5      /� .T�5      J� .*�6   �� $�RichTextBox��6   6+   5      5      �� 5      -   5         ��Name$ UczestnicyCzatu��5      $
��Left=�6&   $	��294��6A   $��
-1,324,0,0q�6N   $	��Top=�6b   $	��207��6z   ���	#FFC9C4C4
���   �6�   �� 5      -   5        $
 Czat��5      $
��Left=�6   $	��246��65   $��211,324,0,0q�6B   $
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��396��6�   ���	#FFDEDEDE . 6�   �� 5      -   5         ��Name$ PanelRysowanie��5      $
��Left=�6&   $	��255��6A   $��612,353,0,0q�6N   $	��Top=�6c   $	��257��6{   6�   �� 5      -   5        $ PanelPisanie��5      $
��Left=�6"   $��33��6=   $��211,575,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��396��6�   $��Napisz coś...��6�   6�   5      5      