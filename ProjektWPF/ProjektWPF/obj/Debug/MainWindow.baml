   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjektWPF
ProjektWPF  5   	       ProjektWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjektWPF     5   	     � Title$  Projekt��5   	   $	��450��6   $	��800��6&   $	��920��62   $	��450��6A   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $
��Left=�6   $��	87,79,0,0q�6/   $
��Wrap=�6B   $	��Top=�6�    J� RenderTransformOrigin$ 0.204,1.157&�6�   $	��359��6�   ��6V   �� *Hra.AktualniMistnost.Popis+6�   �� 5   
   $
��Left=�6   $��	87,48,0,0q�6/   $
��Wrap=�6B   $	��Top=�6�   $ 0.204,1.157&�6�   $	��359��6�   ��6V   �� *Hra.AktualniMistnost.Jmeno+6�   �� 5   
   $��
Místnost:��6   $
��Left=�6$   $��	10,43,0,0q�6?   $	��Top=�6R   �� 5   
   $��Popis:��6   $
��Left=�6!   $��	10,74,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $��Button��5      $
��Left=�6"   $��
739,67,0,0q�6=   $	��Top=�6Q   6i   �� 5   
   $��Okolní Lokace��6   $
��Left=�6(   $��
20,122,0,0q�6C   $	��Top=�6W   $	��230��6o   �� 5   
   $��Předměty v místnosti��6   $
��Left=�6/   $��266,122,0,0q�6J   $	��Top=�6_   $	��230��6w   �� 5   
   $��NPC v místnosti��6   $
��Left=�6*   $��512,122,0,0q�6E   $	��Top=�6Z   $	��230��6r   �� 5   
   -   5        $��OkolniMistnosti��5      $��30,153,670,90q�6R   ��6*   �� *OkolniMistnost+ �� View 5      �� 5       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Nazev��66   .P�5      �� $��Jmeno��6L    �� DisplayMemberBinding 6%   �� *Jmeno+6L   5       5#      5'      5)      