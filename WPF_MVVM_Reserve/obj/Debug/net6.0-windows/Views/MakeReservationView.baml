   M S B A M L   `   `   `  ����K  GWPF_MVVM_Reserve, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_MVVM_Reserve.ViewsWPF_MVVM_Reserve.Views  5      0    *WPF_MVVM_Reserve.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WPF_MVVM_Reserve.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5       
  Header#��[  5      $��Make Reservation��5      � 5   
   $��1��6   $��0,25,0,0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5!      �� $��0��5"      $��5,0,0,0q�5#      $��Username��5$      �� 5%      $��1��5&      $��0,5,0,0q�5'      ��5(      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5)      � 5+   
   $��2��6   $��0,25,0,0q�6    5,      �� 5-      $
��auto �6    �� 5.      $
��auto �6     � ColumnDefinitions 51      �� 52      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 53      $
��auto �6#   $ SecondColumn��60   .+�56      �� $��0��57      $��0��58      $��	Floor No.��59      �� 5:      $��1��5;      $��0��5<      $��0,5,0,0q�5=      ��5>      �� *FloorNumber+$ PropertyChanged=��� 5@      $��0��5A      $��1��5B      $��5,0,0,0q�5C      $��Room No.��5D      �� 5E      $��1��5F      $��1��5G      $��5,5,0,0q�5H      ��5I      �� *
RoomNumber+$ PropertyChanged=�5J      � 5L   
   $��3��6   $��0,10,0,0q�6    5M      �� 5N      $
��auto �6    �� 5O      $
��auto �6     5R      �� 5S      $
��auto �6#   $ FirstColumn��60   �� 5T      $
��auto �6#   $ SecondColumn��60   .+�5W      �� $��0��5X      $��0��5Y      $��
Start Date��5Z      (  "System.Windows.Controls.DatePicker  5[      $��1��5\      $��0��5]      $��0,5,0,0q�5^         SelectedDate 5_      �� *	StartDate+$ PropertyChanged=��� 5a      $��0��5b      $��1��5c      $��5,0,0,0q�5d      $��End Date��5e        5f      $��1��5g      $��1��5h      $��5,5,0,0q�5i       5j      �� *	EndDate+$ PropertyChanged=�5k      �� 5m   
   $��4��5n      $��0,25,0,0q�5o       �� Orientation$ 
Horizontal=�5p      .+�5q      �� $��Submit��67   ��6   �� *SubmitCommand+67   �� 5r      $��5,0,0,0q�5s      $��Cancel��5u      ��5t      �� *CancelCommand+5u      5v      5w      5x      