   M S B A M L   `   `   `  ����  WpfApplication2    RPGManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  RPGManagerServer��5   	   $	��648��6"   $	��887��6/    � 
ResizeMode$ CanResizeWithGrip=�6;    � 	Resources 5         	OnLoaded1��%   &	        �� 5   
   6   5       � Triggers 5	      :� 5
   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .��5      � .+�5   
   �� -   5         ��Name$ Start��5      $��StartSession��6    $
��Left=�67   $��24��6R   $��788,324,0,0q�6^   $	��Top=�6s   $��81��6�   6�   o� 5   
   $
��Left=�6   $��21��6*   $	��Top=�66   $	��879��6N   .@�5      m� -   5         m�Name$ 
BazaDanych��5      $��Baza Danych��6+   $��21��6@   $��84��6L   6W   m� 5      -   5        $ EdycjaPostaci��5      $��Edycja Postaci��6.   $��21��6F   $
��82.5��6R   6_   m� 5      -   5        $ Chatgrupowy��5      $��Czat Grupowy��6,   $��23��6B   $��82��6N   6Y   m� 5      -   5        $ PrivChat��5      $��Czat Prywatny��6)   $��26��6@   $��84��6L    J� RenderTransformOrigin$ 
0.517,0.11&�6l   5      �� 5   
   -   5         ��Name$ ListaGraczy��5      $
��Left=�6(   $	��297��6C   $��	-1,22,0,0q�6P   $	��Top=�6c   $	��207��6{   ���	#FFC9C4C4
���   �6�   �� 5   
   -   5        	 ��Name$	 KartaPostaci��5      $
��Left=�6(   $	��297��6C   $��
209,22,0,0q�6P   
 �� TextWrapping$

 Wrap=�6d   $��Karta postaci:��6x   $	��Top=�6�   $	��398��6�   ���	#FFDEDEDE
���   � �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ Notatki��5      $
��Left=�6'   $	��297��6B   $��
612,22,0,0q�6O   $	��Top=�6c   $	��257��6{   ���	#FFFFFDC9
���   �$��Italic$�6�    �� 
AcceptsTab .  � ContextMenu 5      �� 5       J� 	AllowDrop . 6   . �5      /� .T�5      J� .*�6   .*�5      �� $�RichTextBox��6   5      5      5      �� 5    
   -	   5        $ UczestnicyCzatu��5       $
��Left=�6,   $	��294��6G   $��
-1,324,0,0q�6T   $	��Top=�6h   $	��207��6�   ���	#FFC9C4C4
���   �6�   �� 5!   
   $
��Left=�6   $	��173��6-   $��211,324,0,0q�6:   $

 Wrap=�6O   $��TextBox��6c   $	��Top=�6r   $	��396��6�   ���	#FFDEDEDE . 6�   �� 5"   
   $
��Left=�6   $	��255��6/   $��612,353,0,0q�6<   $	��Top=�6Q   $	��257��6i   �� 5#   
   -
   5        $	 
ChatOutput��5#      $
��Left=�6&   $	��173��6A   $��211,324,0,0q�6N   $

 Wrap=�6c   $��TextBox��6w   $	��Top=�6�   $	��396��6�   ���	#FFDEDEDE . 6�   �� 5$   
   -   5        $	 	ChatInput��5$      $
��Left=�6%   $	��115��6@   $��211,502,0,0q�6M   $

 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��396��6�   ���	#FFDEDEDE . 6�   5&      5'      