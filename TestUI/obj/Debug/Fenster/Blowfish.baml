   M S B A M L   `   `   `  ����A  =TestUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestUI.FensterTestUI.Fenster  5   	       TestUI.Fenster.BlowfishUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestUI.Fenster     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
BlowfishUI��5	   	   $	��350��6   $	��525��6)   ���#000000 � WindowStyle$
 None=�6J   .��5
      � .+�5   
   �� -   5        $��cvText��5      $	��290��6   $	��505��6,   $��	10,10,0,0q�68   $	��Top=�6K   $
��Left=�6c   .+�5      �� -   5        $��
lblMessage��5      $��Message:��6&   ���#cfcfcf$��5,5,0,0q�6O   $	��Top=�6`   $
��Left=�6x   �� 5      -   5        $��	tbMessage��5      $
��Left=�6'   $��23��6B   $��90,5,0,0q�6N    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��400��6�   �� 5      -   5        $��lblEncrypted��5      $��
Encrypted:��6)   ���#cfcfcf$��5,35,0,0q�6T   $	��Top=�6f   $
��Left=�6~   �� 5      -   5        $��tbEncrypted��5      {�.  $
��Left=�6;   $	��160��6V   $��	90,35,0,0q�6c   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��400��6�   �� 5      -   5        $��lblDecrypted��5      $��
Decrypted:��6(   ���#cfcfcf$��	5,200,0,0q�6R   $	��Top=�6f   $
��Left=�6~   �� 5      -   5        $��tbDecrypted��5      {�.  $
��Left=�6;   $��23��6V   $��
90,200,0,0q�6b   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��400��6�   5      �� 5   
   -   5        $��	cvButtons��5      $��30��6"   $	��505��6.   $��
10,300,0,0q�6:   $	��Top=�6N   $
��Left=�6f   .+�5      �� -	   5        $��
btnEncrypt��5      $��Encrypt��6'      ButtonStyle#���   69    �� Left$ 90��6x   
 �� Top$ 2��6�   �� 5      -
   5        $��
btnDecrypt��5      $��Decrypt��6'   #���   69   $	 175��6x   $ 2��6�   �� 5      -   5        $��btnClose��5      $��Close��6'   #���   68   $	 445��6u   $ 2��6�   5      5      5      