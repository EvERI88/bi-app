   M S B A M L   `   `   `  ����A  =Kursa4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Kursa4Kursa4  5          Kursa4.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Kursa4     5        N� Title$  Page1��5	      .��5      � 
����� �.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
lbTodoList��5   y   ���#98facc   AutoGenerateColumns .  $��442,418,442,106q�6E   $��Sitka Display)�6^   $��Stretch=�6�      
IsReadOnly .  J� RenderTransformOrigin$ 0.5,0.5&�6�      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� .+�5   "   �� -   5        $,��&Добавить в избранное��5   T   
 � Tag 6)   �� *id+6T   �� 5   "   $	��150��6(   $	��150��66   ��6B   �� *Photo+5       5!      5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6&   	   Header$	 Название��60   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6B   �� *Name+  5&      $ * 6&   $		 №��60   
 6;   �� *
NumberBike+  5'      $ * 6%   $	 Цена��6/   
 6=   �� *Price+  5(      $ * 6%   $	 Размер��6/   
 6?   �� *Size+  5)      $ * 6%   $	 Материал��6/   
 6A   �� *
Material+  5*      $ * 6%   $	 Тип��6/   
 6<   �� *Type+  5+      $ * 6%   $	 Описание��6/   
 6A   �� *Description+5-      �� 51   
   -   5        ���#98facc
���   �$��2q�51   O   $	��200��6c   $��30(�6o   $��Sitka Display)�6}   $��Избранное��6�   $��442,336,1278,667q�6�   �� 52   
   -   5        ���#98facc
���   �$��2q�52   P   $��30(�6d   $��Sitka Display)�6r   $.��(Вход в администратора��6�   $��1170,336,446,667q�6�   �� 53   
   $��646,-15,646,667q�6   $��ogo.png��6)   $
��Fill=�6:    � 54   
   -   5          �Name$ frame��54        � NavigationUIVisibility$ Hidden=�6   $
��Left=�6?   $
��1080��6Z   $	��Top=�6h   $
��1920��6�   56      57      