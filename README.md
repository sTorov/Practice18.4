# Practice18.4

## Task

Используя паттерн команда ***(Command)*** и библиотеку ***YoutubeExplode***, напишите консольную программу, которая будет:

 1. Принимать на вход ссылку на  Youtube-видео. 
 2. Выводить в консоль информацию: название видео и описание.
 3. Скачивать видео.

У вас должно быть две команды: 

 - на получение информации о видео 
 - на скачивание видео
 ___
 ***Описание проекта***

 В данном проекте была разработана программа, которая позволяет скачивать видео с YouTube. Также данная программа выводит название и описание видео на консоль.
___

 >По поводу строчки кода
 >
 >`Console.OutputEncoding = Encoding.UTF8;` 
 > 
 >Я понимаю что эту строчку кода писать не обязательно и то, что кодировка UTF8, в большенстве случаев, используется по умолчанию. Эта строка нужна мне в программе для корректного и красивого вывода в консоль. Я часто меняю язык системы. Из-за этого вывод в консоль может очень сильно "преобразиться". Данная строка кода позволяет решить эту проблему.
 
 >На счёт тега `<br/>` в описании членов класса
 >
 >При выполнении одного из заданий курса, меня заинтересовал вопрос переноса строк при появлении всплывающих подсказок в VisualStudio. Немного покапавшись на просторах интернета, я наткнулся на этот тэг и решил попробовать.