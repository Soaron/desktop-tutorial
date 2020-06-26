## Самый первый вариант проекта

Этот вариант представлял собой плату с операционными усилителями, 
АЦП и процессором, соединённнную с реальным делителем с полосой 
пропускания 150МГц от старинного осциллографа. 

Конструкция работала неплохо, но была достаточно громоздкой и тоже нуждалась 
в небольшой корректировке входной ёмкости.

Собиралась по схеме [автора][id_Stanson]
![picSc][Scheme]

Разводка плат под PIC 18F2550 в [DIP][DIP_Lay] и [SMD][SMD_Lay]
в формате lay (SprintLayout 6.0)

Готовое устройство (DIP и SMD варианты)
![picT][PicT]
![picB][PicB]

Здесь был применен реальный делитель от стариннного осциллографа.
![picD][PicD]

Софт от Kharakternyk.
![picSoft][PicSoft]

На тот момент новый софт еще только задумывался.
Новый софт с новой версией прошивки работать будет и на этих схемах, 
но не весь функционал. Работать будут только:
Развертка, Оффсет и Синхронизация.


[id_Stanson]:http://www.stanson.ch/index.php?page=proj&proj=USB-oscope
[Scheme]:Screens/USB-oscope.png
[picT]:Screens/DIP-SMD-Top.png
[picB]:Screens/DIP-SMD-Back.png
[picD]:Screens/S5450008.JPG
[picSoft]:Screens/S5310003.JPG
[DIP_Lay]:Screens/DIP/Oscilloskope-18F2550-DIP.lay
[SMD_Lay]:Screens/SMD/Oscilloskope-18F2550-50K.lay
