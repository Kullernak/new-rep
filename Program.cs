using System;
// Задаем массив строк вручную
string[] words = { "hello", "world", "this", "is", "a", "test" };

// Создаем новый список строк, куда будем добавлять строки длиной <= 3 символов
List<string> shortWords = new List<string>();

// Проходимся по каждой строке в исходном массиве
foreach (string word in words)
{
    // Проверяем длину строки
    if (word.Length <= 3)
    {
        // Если длина строки меньше или равна 3, добавляем ее в список
        shortWords.Add(word);
    }
}

// Преобразуем список обратно в массив
string[] result = shortWords.ToArray();

// Выводим результат на экран
foreach (string word in result)
{
    Console.WriteLine(word);
}
