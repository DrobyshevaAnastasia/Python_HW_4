#Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
#Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. Затем пользователь вводит сами элементы множеств.

from random import randint
n = set(randint(1, 20) for i in range(int(input())))
m = set(randint(1, 20) for i in range(int(input())))
itog=set()
for i in n:
    itog.add(i)
for i in m:
    itog.add(i)
itog=sorted(itog)
print(itog)