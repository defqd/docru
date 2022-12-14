## Задание 1
Напишите функцию, которая в качестве аргумента принимает натуральное число n и возвращает сумму цифр этого числа. Если это значение имеет более одной цифры, продолжайте уменьшать его таким образом, пока не будет получено одноразрядное число. Это применимо только к натуральным числам. 

  Пример: 	
  - my_function(16)  ->  1 + 6 = 7
  -	my_function(942) ->  9 + 4 + 2 = 15  -> 1 + 5 = 6
## Результат 
- Выполнение первого задания расположено в директории **docru\DocruTasks\DocruTasks\SumOfDigits.cs**
- Тесты для первого задания находятся в дериктори **docru\DocruTasks\DocruTasks.Tests\SumOfDigitsTests.cs**
##
## Задание 2
Напишите функцию, которая принимает количество американской валюты центы (cents) и возвращает словарь / хэш, который показывает наименьшее количество монет, используемых для создания этой суммы. Рассматриваются только номиналы монет: Pennies (1¢), Nickels (5¢), Dimes (10¢) and Quarters (25¢). Поэтому возвращаемый словарь должен содержать ровно 4 пары ключ / значение.

  Примечания:
  - Если в функцию передается либо 0, либо отрицательное число, то она должна возвращать словарь со всеми значениями, равными 0.
  - Если в функцию передается значение float, то его значение должно быть округлено вниз, и результирующий словарь никогда не должен содержать дробей монеты. 
 
   Пример: 
   - my_function(56)  -> {'Nickels': 1, 'Pennies': 1, 'Dimes': 0, 'Quarters': 2}
   - my_function(-435) -> {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0}
   - my_function(4.935) -> {'Nickels': 0, 'Pennies': 4, 'Dimes': 0, 'Quarters': 0}
## Результат 
- Выполнение второго задания расположено в директории **docru\DocruTasks\DocruTasks\Currencies.cs**
- Тесты для второго задания находятся в дериктори **docru\DocruTasks\DocruTasks.Tests\CurrenciesTests.cs**
##
## Задание 3
Напишите функцию, которая может принимать любое неотрицательное целое число в качестве аргумента и возвращать его вместе с цифрами в порядке убывания. Переставьте цифры так, чтобы на выходе создать максимально возможное число.

  Пример: 	
    - my_function(42145) -> 54421
## Результат
- Выполнение третьего задания расположено в директории **docru\DocruTasks\DocruTasks\SortOfNumbers.cs**
- Тесты для третьего задания находятся в дериктори **docru\DocruTasks\DocruTasks.Tests\SortOfNumbersTests.cs**
##
## Задание 4
Дана пирамида чисел:

                  1
               3     5
            7     9    11
         13    15    17    19
      21    23    25    27    29
     ...
Напишите функцию, которая вычисляет сумму строки этого треугольника из переданного в функцию индекса строки (начиная с индекса 1).

  Пример: 	
  - my_function (2) -> 3 + 5 -> 8
## Результат
- Выполнение четвертого задания расположено в директории **docru\DocruTasks\DocruTasks\SumOfTriangleRow.cs**
- Тесты для четвертого задания находятся в дериктори **docru\DocruTasks\DocruTasks.Tests\SumOfTriangleRowTests.cs**
##
## Задание 5
Напишите функцию, которая не принимает аргументов и всегда возвращает 5. Звучит просто, не правда ли? Просто имейте в виду, что вы не можете использовать ни один из следующих символов: 
0 1 2 3 4 5 6 7 8 9 * + - /
## Результат
- Выполнение пятого задания расположено в директории **docru\DocruTasks\DocruTasks\ReturnFive.cs**
- Тесты для пятого задания находятся в дериктори **docru\DocruTasks\DocruTasks.Tests\ReturnFiveTests.cs**
##
