   M S B A M L   `   `   `  ����A  =Kursa4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Kursa4Kursa4  5          Kursa4.ADMIN   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Kursa4     5        N� Title$  ADMIN��5	      .��5      � 
����� �.+�5   
   �� -   5        $��
Выйти��5      $��30(�6!   $��Sitka Display)�6/   $��1228,538,233,447q�6J   6}   �� 5   
   -   5        $5��/Удалить модель из таблицы��5      $��30(�65   $��Sitka Display)�6C   $��1228,439,233,546q�6^   6�   �� 5   
   -   5        $��30(�5      $��Sitka Display)�6   $��1228,242,233,743q�6O   $7��1Загрузить фотку и добавить��6i    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5        $��txtprice��5   f   $��30(�6=   $��Sitka Display)�6K   $��Center=�6v   $	��459��6�   $��764,242,697,744q�6�   .��6�   Price6�   �� 5   
   -   5        $��txtname��5   ;   $��30(�6   $��Sitka Display)�6    $��Center=�6J   $	��459��6g   $��300,242,1161,744q�6s   .��6�   Name6�   �� 5   
   -   5        $��txtsize��5   ;   $��30(�6   $��Sitka Display)�6    $��Center=�6J   $	��459��6g   $��300,339,1161,646q�6s   .��6�   Size6�   �� 5   
   -   5        $��txtmaterial��5   ;   $��30(�6   $��Sitka Display)�6    $��Center=�6N   $	��459��6k   $��300,439,1161,547q�6w   .��6�   
Material6�   �� 5   
   -   5        $��
txtpicture��5   h   $��30(�6?   $��Sitka Display)�6M   $��Center=�6z   $	��459��6�   $��300,538,1161,447q�6�   .��6�   	Picture6�   �� 5   
   -	   5        $��txtnumberbike��5   g   $��30(�6>   $��Sitka Display)�6L   $��Center=�6|   $	��459��6�   $��764,339,697,646q�6�   .��6�   
NumberBike6�   �� 5   
   -
   5        $��txtdescriptrion��5   ;   $��30(�6   $��Sitka Display)�6    $��Center=�6R   $	��459��6o   $��764,539,697,447q�6{   .��6�   Description6�   �� 5   
   -   5        $��txttype��5   ;   $��30(�6   $��Sitka Display)�6    $��Center=�6J   $	��459��6g   $��764,439,697,547q�6s   .��6�   Type6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
lbTodoList��5   x   ���#98facc   AutoGenerateColumns .  $��300,658,244,98q�6E   $��Sitka Display)�6]   $��Stretch=�6�      
IsReadOnly . $ 0.5,0.5&�6�      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� .+�5   "   �� $	��150��6(   $	��150��66   ��6B   �� *Photo+5      5       5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6&      Header$ Название��60   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� *Name+  5%      $ * 6&   $	 №��60   	 6;   �� *
NumberBike+  5&      $ * 6%   $ Цена��6/   	 6=   �� *Price+  5'      $ * 6%   $ Размер��6/   	 6?   �� *Size+  5(      $ * 6%   $ Материал��6/   	 6A   �� *
Material+  5)      $ * 6%   $ Тип��6/   	 6<   �� *Type+  5*      $ * 6%   $ Описание��6/   	 6A   �� *Description+5,       � 5-   
   -   5        
  �Name$
 frame��5-        � NavigationUIVisibility$ Hidden=�6   $
��Left=�6?   $
��1080��6Z   $	��Top=�6h   $
��1920��6�   50      51      