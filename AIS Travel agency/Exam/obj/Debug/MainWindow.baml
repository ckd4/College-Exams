   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ExamExam  5   	       Exam.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Exam     5   	     � 
ResizeMode$  NoResize=�5   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5	   <    � Title$ 
MainWindow��5
   	   $	��720��6   $
��1280��6)   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 28Q�6   .��5      � .+�5   
   �� 
������� �� CornerRadius$ 12��6$   r� 5   
   -   5        $��mediaElement��5   ,   $��10 10 10 10q�6    r� LoadedBehavior$ Manual=�6@    r� Stretch$
 Fill=�6X   	 r� Source$	 Resources/video.mp4?�6g   $��3��6�   $��3��6�   
 � Triggers
 5      :� 5       :� RoutedEvent$ MediaElement.Loaded��6   [�5      �� 5      .��5      �� .��5   "   p�  p� Source$ Resources/video.mp4?�60    �� 
TargetName$ mediaElement��6M    g� RepeatBehavior$ Forever��6r   5      5      5      5       � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   6C   �� 5   
   $	��Top=�6   $��Right=�6-      IsHitTestVisibleInChrome . $��30��6v    �� CanHorizontallyScroll .   �� CanVerticallyScroll .   �� Orientation$ 
Horizontal=�6�   .+�5      �� -   5        
�������   NoMouseOverButtonTemplate#���   5   (     TitleBarButtonStyle#���  6_   $	��–��6�   6�   �� 5       -   5        
�������#���   5    )   #���  6`   $��×��6�   6�   5!      5"      5#      