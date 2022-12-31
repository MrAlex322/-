**Итоговая проверочная работа.**
Написать программу, которая их имеющегося массива строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа. Первоначально массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение.

**Шаг 1**
Построение Блок-схемы"
Создаем массив WriteArray. Пользователь указывает сколько элементов он хочет задать и тем самым заполняет массив.

**Шаг 2**
После этого создаем массив MassArray, который будет наполняться сроками, с длинной <=3. Создаем цикл, проверяющий начальный массив по условию "длина символов <= 3". 
Если элемент подходит под данное условие, то он добавляется в новый массив, используя при этом дополнительный счетчик, чтобы элементы в новом массиве заполнялись последовательно (без пропусков).

**Шаг 3**
Строим блок-схему по полученному решению.
**Шаг 4**
Пишем программу по полученной блок-схеме.