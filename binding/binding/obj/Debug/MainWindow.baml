   M S B A M L   `   `   `  ����B  >binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:bindingbinding  5   	       binding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:binding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)    � 	Resources 5	         binding.Item 	  items  
MyTemplate � RowDefinitions � ColumnDefinitions �� Path��%�  &	        &	        5
   
   6   �� 5   
   .R�5      �� $��border��6   ._�5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      .+�5      �� $��0��6    $��0��6-   $��
Food Name:��6=   �� 5      $��0��6    $��1��6-   ��6=   �� $
 name��� 5      $��1��6    $��0��6-   $��
Food Type:��6=   �� 5      $��1��6    $��1��6-   ��6=   �� $
 type��� 5      $��2��6    $��0��6-   $��Food Description:��6=   �� 5      $��2��6    $��1��6-   ��6=   �� $ description��� 5      $��3��6    $��2��6-   5!      5"      5#      5'      .��5)      �� .+�5+   
   �� $��10,0,0,0q�6   Type of food selection6@   �� 5,   
   -   5         ��Name$ 
mylistBox1��5,       �� SelectedIndex$ 0��5-      $��10,0,0,0q�6$   .@�5/      �� $	��Wet��6   �� 50      $��Mixed��6   �� 51      $	��Dry��6   53      �� 54   
   $��10,10,0,-10q�6   �� 6*   $#�Menu : Click to see the price��6.   6V   �� 55   
   -   5        $ 
mylistBox2��55   -   $	��400��6   $��96,10q�6   $��Stretch=�56      #��[ 58      ��57      �� 59      5;      5?      