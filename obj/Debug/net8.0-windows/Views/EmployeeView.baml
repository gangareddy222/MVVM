   M S B A M L   `   `   `  ����?  ;Mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mvvm.Views
Mvvm.Views  5          Mvvm.Views.EmployeeView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Mvvm.Views     5      .��5	      �   � ColumnDefinitions  5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Employee Management��6   $��1��6/   $��1��6<   $��Center=�6L   $��20(�6i   $��
Lucida Fax)�6w   $��Center=�6�   �� 5   
   $��Enter Id��6   $��2��6$   $��0��61   $��5,8,5,8q�6A   �� 5    
   $��
Enter Name��6   $��3��6&   $��0��63   $��5,8,5,8q�6C   �� 5!   
   $��	Enter Age��6   $��4��6%   $��0��62   $��5,8,5,8q�6B   �� 5#   
   -   5        $��txtId��5#      $��2��6   $��1��6,   $��5,8,5,8q�6<   ��6M   ��  �� Path$ CurrentEmployee.Id� �� Mode$ TwoWay=��� 5$   
   -   5        $��txtName��5$      $��3��6!   $��1��6.   $��5,8,5,8q�6>   ��6O   �� $ CurrentEmployee.Name�$ TwoWay=��� 5%   
   -   5        $��txtAge��5%      $��4��6    $��1��6-   $��5,8,5,8q�6=   ��6N   �� $ CurrentEmployee.Age�$ TwoWay=��� 5'   
    �� Orientation$ 
Horizontal=�6   $��5��60   $��1��6=   $��5,8,5,8q�6M   .+�5(      �� -   5        $��addbtn��5(      $	��ADD��6#   $��5,8,5,8q�61   ��6B   �� $ SaveCommand��� 5)      -   5        $��	searchbtn��5)      $��SEARCH��6&   $��5,8,5,8q�67   ��6H   �� $ SearchCommand��� 5*      -   5        $��	updatebtn��5*      $��UPDATE��6&   $��5,8,5,8q�67   ��6H   �� $ UpdateCommand��� 5+      -   5        $��	deletebtn��5+      $��DELETE��6&   $��5,8,5,8q�67   5.      �� 5/   
   -   5        $��txtBlockMessage��5/      $��6��6+   $��1��68   $��5,8,5,8 q�6H   ��6Z   �� $ Message�&   System.Windows.Controls.DataGrid  51   
   -	   5        $��dgEmployees��51         AutoGenerateColumns$ False��6&   $��7��6B   $��1��6O   $��5,8,5,8q�6`   $��3,3,3,3q�6q   ��6�   �� $ EmployeesList�$ TwoWay=�   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6:   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6G   �� $ ID�  54      $ Employee Name��6%   $
 auto 6<   	 6I   �� $
 Name�  55      $ Employee Age��6%   $
 auto 6;   	 6H   �� $	 Age�57      5>      5?      