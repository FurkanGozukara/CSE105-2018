   M S B A M L   `   `   `  ����D  @Lecture_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lecture_8	Lecture_8  5   	       Lecture_8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lecture_8     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��lstList1��5
      $
��Left=�6"   $	��323��6=   $��	36,29,0,0q�6J   $	��Top=�6]   $	��158��6u   �� 5   
   -   5        $��
btnAddList��5      $��Listeye Ekle��6#   $
��Left=�6:   $��
409,29,0,0q�6U   $	��Top=�6i   $	��121��6�   6�   �� 5   
   -   5        $��txtAdd��5      $
��Left=�6    $��23��6;   $��
210,29,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $��add element��6o   $	��Top=�6�   $	��182��6�   �� 5   
   -   5        $��btnDeleteSelected��5      $��delete selected element��6*   $
��Left=�6L   $��
409,72,0,0q�6g   $	��Top=�6{   $	��187��6�   6�   �� 5   
   -   5        $��txtElementDelete��5      $
��Left=�6*   $��23��6E   $��210,121,0,0q�6Q   $
 Wrap=�6f   $��element to delete��6z   $	��Top=�6�   $	��182��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.208Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5        $��deleteWrittenElement��5      $��delete written element��6-   $
��Left=�6N   $��409,123,0,0q�6i   $	��Top=�6~   $	��187��6�   6�   �� 5   
   -   5        $��btnWritetoFile��5      $"��write listbox to a text file��6'   $
��Left=�6N   $��470,169,0,0q�6i   $	��Top=�6~   $	��187��6�   6�   �� 5   
   $��text file name:��6   $
��Left=�6*   $��210,166,0,0q�6E   $	��Top=�6Z   �� 5   
   -   5        $��txtFileName��5      $
��Left=�6%   $��23��6@   $��299,169,0,0q�6L   $
 Wrap=�6a   $��	file name��6u   $	��Top=�6�   $	��147��6�   5      5      