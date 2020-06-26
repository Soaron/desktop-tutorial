## Первые версии проекта

Собирались по схеме [автора][id_Stanson]
![picSc][Scheme]

Здесь был применен реальный делитель от стариннного осциллографа.

Разводка плат под PIC 18F2550 в [DIP][DIP_Lay] и [SMD][SMD_Lay]
в формате lay (SprintLayout 6.0)

Готовое устройство (DIP и SMD варианты)
![picT][PicT]
![picB][PicB]

С делителем
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
[DIP_Lay]:DIP/Oscilloskope-18F2550-DIP.lay
[SMD_Lay]:SMD/Oscilloskope-18F2550-50K.lay
