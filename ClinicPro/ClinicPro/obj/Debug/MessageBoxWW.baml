   M S B A M L   `   `   `  ����D  @ClinicPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ClinicPro	ClinicPro  5   	       ClinicPro.MessageBoxWW   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ClinicPro     5   	   -   5          � Title$  MessageBoxWW��5   	   $	��200��6   $	��300��6+    � WindowStyle$
 None=�5	   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5
   "    � WindowStartupLocation$ CenterOwner=�5   	   .��5      � .+�5   
   � -   5         �Name$
 Body��5      .+�5      �� ���#BFCAEF �� CornerRadius$ 25��6*   5      � 5   
   -   5        $ Header��5      $��40��5      $	��Top=�6   .+�5      �� ���#D9D9D9$��3q�5      $ 20, 20, 0, 0��5      ���	#FFD9D9D95      �� 5      $*��$Выход из приложения��6   $��Center=�5      $��Center=�5      $��16(�5      $��	Comfortaa)�5      5      � 5   
   -   5        $ 
BodyCenter��5      $��Center=�6#   .+�5       �� $:��4Вы уверены, что хотите выйти?��6   $��Center=�5!      $��Center=�5"      $��16(�5#      $��	Comfortaa)�5$      5%      � 5'   
   -   5        $	 Bar��5'      $��50��6   $��Bottom=�6(   .+�5)      ]� .+�5*      � -   5        $ YesButtonBar��5*      $	��100��6-   $
��Left=�69   .+�5+      �� ���#45E155$ 0, 25, 0, 25��5,      �� 5-      $��	Comfortaa)�6    $��24(�5.       $
��Да��6.   $��Center=�5/       $��Center=�50       �� 51      -   5        $��50��51      
������ 
������  � Cursor$
 Hand��55      ��56      �� 57       �� 
TargetType" ��6.   .R�58   "   �� 
������ $��0q�6B   ._�59   &   �� $��Center=�67   $��Center=�6T   5:   #   5;      5=      5?      � 5@      -   5        $ NoButtonBar��5@      $	��100��5A      $��50��6#   $��Right=�5B      |�.  .+�5D      �� ���#E14545$ 25, 0, 25, 0��5E      �� 5F      $��	Comfortaa)�6    $��24(�5G       $��Нет��6.   $��Center=�5H       $��Center=�5I       �� 5J      -	   5        $��50��5J      
������ 
������ $
 Hand��5N      ��5O      �� 5P      " ��6.   .R�5Q   "   �� 
������ $��0q�6B   ._�5R   &   �� $��Center=�67   $��Center=�6T   5S   #   5T      5V      5X      5Y      5\      5]      5^      