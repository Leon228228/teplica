   M S B A M L   `   `   `  ����D  @TeplicaIS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TeplicaIS	TeplicaIS  5   	       TeplicaIS.Admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TeplicaIS     5   	     � Title$  Admin��5   	   $	��450��6   $	��800��6$   .��5	      � .+�5
   
   �� $��36(�6   $��Center=�6    $��52��6=   $��0,20,0,0q�6I    �� TextWrapping$
 Wrap=�6[   $��Админ панель��6o   $	��Top=�6�   $	��242��6�   �� 5   
   -   5         ��Name$ lv_users��5      $
��Left=�6%   $	��250��6@   $��
48,115,0,0q�6M   $	��Top=�6a   $	��500��6y    �� View 5      �� 5      P�5      �� 5       �� Width$	 100��6)   $��id��65    �� DisplayMemberBinding 6A   �� *id+�� 5      $	 100��6)   $��Роль��65    6C   �� *	role_id+�� 5      $	 100��6)   $��Фамилия��65    6F   �� *	surname+�� 5      $	 100��6)   $��Удалить��65   5      5      �� 5   
   -   5         ��Name$ cb_roles��5      $
��Left=�6%   $��
48,386,0,0q�6@   $	��Top=�6T   $	��160��6l   �� 5   
   -   5         ��Name$ tb_FIO��5      $��Right=�6"   $��0,386,252,0q�6>   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��300��6�   �� 5   
   -   5         ��Name$ btn_add��5      $��Добавить��6"   $
��Left=�65   $��593,379,0,0q�6P   $	��Top=�6e   $��22��6}   $��80��6�   5      5      