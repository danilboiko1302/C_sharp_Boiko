   M S B A M L   `   `   `  ����  
BoikoLab01    BoikoLab01.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��500��6)   .��5      � {�6   �� *IsControlEnabled+ �� UpdateSourceTrigger$ PropertyChanged=� � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��30 �6   6*   �� 5      $��80 �6   6*   .+�5   
   �� $��18(�6   $��Normal$�6   $%��Please, choose your birhtdate: ��61   6]   (  "System.Windows.Controls.DatePicker  5   
      FirstDayOfWeek$ Monday=�6   $��1��6P   $��0��6]   $��2��6m      SelectedDate 6-   �� *	BirthDate+6�   �� 5   
   $��2��6   $��0��6!   $��18(�61   $��Normal$�6?   ��6R   �� *ChineseSign+6q   �� 5   
   $��2��6   $��1��6!   $��18(�61   $��Normal$�6?   ��6R   �� *Sign+6j   �� 5   
   $��3��6   $��0��6!   $��18(�61   $��Normal$�6?   $��Center=�6R   $��2��6p   ��6�   �� *Age+6�   5       5!      