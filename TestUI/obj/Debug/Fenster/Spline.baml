   M S B A M L   `   `   `  ����A  =TestUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TestUI.FensterTestUI.Fenster  5   	   1clr-namespace:TestUI.ControlsTestUI.Controls  5   	       TestUI.Fenster.Spline   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:TestUI.Fenster     5   	   2Controlsclr-namespace:TestUI.Controls     5   	   -   5          � Title$  Spline��5	   	    � WindowStyle$
 None=�5
   	      BackgroundBrush#���   5   	   $	��500��5   	   $
��1500��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
      TestUI.Controls.Plotter  -   5          Name$ CtrlPlotterSpline��5      $	��450��68   $
��1266��6E   $��	20,20,0,0q�6R   $
��Left=�6e   $	��Top=�6�   �� 5   
   -   5        $��btnClearValues��5      $��Clear��6(   $��1304,450,0,0q�68     ButtonStyle#���  6N    J� RenderTransformOrigin$ -2.227,1.719&�6�   �� 5   
   -   5        $��btnClose��5      $��Close��6"   $��1430,450,0,0q�62   #���  6H   6n   �� 5   
   -   5        $��	btnRedraw��5      $
��Draw��6#   $��1430,190,0,0q�62   #���  6H   6n   "   TestUI.Controls.NewDataPoint  5   
   -   5          Name$ CtrlDataPoints��5       $��1304,20,9.6,393.6q�68   �� 5   
   -   5        $��lvDataPoints��5   <     	FontBrush#���  6   $
��Left=�6P   $	��245��6k   $��1304,184,0,0q�6x   $	��Top=�6�     LayerTwoBrush#���  6�   $	��100��6�   5      �� 5   
   -   5        $��CVRadioButtons��5      $��1304,120,0,0q�6'   $	��Top=�6=   $
��Left=�6U   .+�5      	� -	   5        $��	rbNatural��5      #���  6,   $��Natural Spline��6U   $
��Left=�6n   $��0,0,0,0q�6�   $	��Top=�6�   6�   	� 5      -
   5        $��
rbClamped1��5      #���  6,   $��Clamped Spline (1,1)��6U   $
��Left=�6t   $��0,20,0,0q�6�   $	��Top=�6�   6�   	� 5      -   5        $��
rbClamped2��5      #���  6,   $��Clamped Spline (2,2)��6U   $
��Left=�6t   $��0,40,0,0q�6�   $	��Top=�6�   6�   5      5!      5"      