   M S B A M L   `   `   `  ����G  CParallax.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS9clr-namespace:Parallax.WPF.Controls;assembly=Parallax.WPFParallax.WPF.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089    BooleanToVisibilityConverter  ParallaxContentView7    1Parallax.WPF.Controls.MouseAwareParallaxContainer2   ,Parallax.WPF.Controls.Base.ParallaxContainer    Layers0   *Parallax.WPF.Controls.ParallaxContentLayer.   (Parallax.WPF.Controls.Base.ParallaxLayer   MouseTargetBehaviour   ContentSource J� Opacity � ToolTip   MouseAwareness  ParallaxImageView.   (Parallax.WPF.Controls.ParallaxImageLayer   ImageSource  ParallaxCompositionView   VerticalWeight  ParallaxCompositionView2   HorizontalWeight  ParallaxParentOverlayView	 � ColumnDefinitions
 �� TextAlignment   HookOnParent   ParentElement%  System.Windows.Markup.Reference ��Name �� Path �� Source �� 	Converter ��Name d� 	IsChecked   ParallaxNightCompositionView �Name J� Effect-  'System.Windows.Media.Effects.BlurEffect   
KernelType   RenderingBias   Radius3  -System.Windows.Media.Effects.DropShadowEffect   Opacity   
BlurRadius �� 
CaretBrush G� 
CaretBrush�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      FParallax9clr-namespace:Parallax.WPF.Controls;assembly=Parallax.WPF  5      %�  &	        &	      &	 �    &	 y    &	 z    &	 	    7   &	     �� 5      6#   � 5      .+�5	   
      
�������  5        $ Leave=�61    5      �� 5      
���� ��$	��100��64   $	��100��6@   $��0,0,200,200q�6M   $	 0.4Q�6b   $N HI move both Horizontaly and Verticaly and opposite of the mouse movment!��6p   5        5      $ Follow=�62    5      �� 5      
����� �$	��100��60   $	��100��6<   $	 0.4Q�6I   $��200,0,0,200q�6X   $I CI move both Horizontaly and Verticaly and follow the mouse movment!��6m   5        5      $ Follow=�61   $ Vertical=�6O    5      �� 5      
���   �$	��100��61   $	��100��6=   $	 0.4Q�6J   $��0,200,200,0q�6X   $9 3I only move Verticaly and follow the mouse movment!��6m   5        5      $ Leave=�63   $ 
Horizontal=�6P    5      �� 5      
��� ���$	��100��63   $	��100��6?   $	 0.4Q�6L   $��200,200,0,0q�6Z   $@ :I only move Horizontaly and opposite of the mouse movment!��6o   5      5       5!      � 5#      .+�5$   
      
�������  5&        $6 0/Parallax.WPF.Samples;component/Static/Riven.jpg��6.   5(      5)      � 5+      .+�5,   
      
�������  5.        $? 9/Parallax.WPF.Samples;component/Static/Composition/p0.png��6.   $	 200Q�6v   $��	0,0,0,200q�6�     5/      $? 9/Parallax.WPF.Samples;component/Static/Composition/p1.png��6.   $	 160Q�6v   $��	0,0,0,200q�6�     50      $? 9/Parallax.WPF.Samples;component/Static/Composition/p2.png��6.   $	 140Q�6v   $��	0,0,0,150q�6�     51      $? 9/Parallax.WPF.Samples;component/Static/Composition/p3.png��6.   $	 120Q�6v   $��	0,0,0,250q�6�     52      $? 9/Parallax.WPF.Samples;component/Static/Composition/p4.png��6.   $	 100Q�6v   $��	0,0,0,200q�6�     53      $? 9/Parallax.WPF.Samples;component/Static/Composition/p6.png��6.   $ 80Q�6v   $��0q�6�   55      56      � 58      .+�59   
      
�������  5;        $6 0/Parallax.WPF.Samples;component/Static/Riven.jpg��6.   $	 4.5Q�6m   $	 4.5Q�6�     5<      $ Follow=�60   $
 1.95Q�6N   .��5=      �� $)��#I AM A BEAUTIFULLLL FLYINGG TEXT!!!��6!   $	 0.6Q�6M   
���   �
�������$��Comic Sans MS)�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   5>      5@      5A      � 5C      	 5D   
   �� 5E      $��1* �6   �� 5F      $��1* �6   .+�5I   
      
�������  5K         5L      �� 5M      
���  ��$	��150��6/   $	��150��6;   5O      5Q      �� 5R   
   $��24(�6   $
��Wrap=�6"   $
 Center=�66   $	��Top=�6M   HFYou can't move me because there is an overlay infront of the control!!6�      5T   
    . $��1��6i   
������� 6C     *	Overlay+  5V         5W      �� 5X      
��� � �$	��150��61   $	��150��6=   5Z      5\      �� 5]   
   $��24(�6   $��1��6"   $
��Wrap=�62   $
 Center=�6F   $	��Top=�6]   LJYou can move me because the parent attribute is set to the overlay object!6�   �� 5_   
   -   5        $ Overlay��5_      ���	#7F000000$��2��66   y�6J   �� $ 	IsChecked�   *OverlayHiderCheckbox+8   6�   �� 5`   
   -   5        $ OverlayHiderCheckbox��5`      $��2��61   $
 TrueY�6E   $��Center=�6V   $��Center=�6s   .��6�   Show Overlay6�   5b      � 5g      .+�5h   
   � -   5        $ LoginScreenGrid��5h      .+�5i         
������� .  6Y     *LoginScreenGrid+ 5j        5k      $ Gaussian=�6   $ Quality=�63   $ 1Q�6K     5n        $H B/Parallax.WPF.Samples;component/Static/NightComposition/Nebula.png��6.   $ 4Q�6   $ 4Q�6�     5o      $J D/Parallax.WPF.Samples;component/Static/NightComposition/StarsBig.png��6.   $	 0.8Q�6�   $ 3Q�6�   $ 3Q�6�     5p      $L F/Parallax.WPF.Samples;component/Static/NightComposition/StarsSmall.png��6.   $ Follow=�6�   $	 0.8Q�6�   $ 2Q�6�   $ 2Q�6�   5r      �� 5t      ���	#663232326   � 5v      $��Center=�6   $��Center=�60   $	��300��6K   $	��250��6W   ���	#FF323232 5w        5x      $	 0.4Q�6'   $ 20Q�65   .+�5z      �� ���	#FFA5A5A5$
��Left=�63   $	��Top=�6N   $��20,0,0,0q�6f   $��48(�6x   $��Segoe UI Light)�6�   $��Login��6�   �� 5{      $
��20,0q�6   $��Center=�6+   .+�5|      �� .+�5}      �� ���	#FFA5A5A5$��Segoe UI Semilight)�6;   $��14(�6[   $��	Username:��6i   �� 5~      ���	#FF414141$��22(�6P   ���	#FFA5A5A5 �	#FF5A5A5A��6"   Z� 6u   5      �� 5�      .+�5�      �� ���	#FFA5A5A5$��Segoe UI Semilight)�6;   $��14(�6[   $��	Password:��6i   G� 5�      ���	#FF414141$��22(�6T   ���	#FFA5A5A5 �	#FF5A5A5A��6&   Z� 6y   5�      5�      �� 5�      $��Right=�6   ���	#FFA5A5A5���	#FF3C3C3C$��66��6z   $��30��6�   $��	0,0,20,20q�6�   $��Bottom=�6�   ��65   Z� .��6�   Login6�   5�      5�      5�      5�      