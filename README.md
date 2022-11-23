**README**

Задание:

Написать программу, кторая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

* Вводим количство строк исходного массива - n
* Создаём пустой массив array(*количество эл-в равно введенному количеству строк*)
* Заводим переменную *count* для подсчета элементов, длина которых меньше либо равна 3 символам
* В цикле (i от 0 до n) вводим строки, заполняя исходный массив

    *каждая строка заносится в массив array[i], если её длина меньше либо равна 3 символам count увеличивается на 1*
* Если count равен нулю, выводим на экран, что таких элементов нет и завершаем программу
* Если count больше нуля:
    * Создаём новый массив array2 c количеством элементов равных count(количество строк, удовлетворяющих условию)
    * Задаём переменную index равную 0(для перехода по элементам массива array2)
    * C помощью цикла проходим по всем элементам массива array1 и если длина элемента меньше либо равна 3, то заносим его в массив array2 и увеличиваем index на 1
    * Выводим элементы массива array2
    * Завершаем программу


