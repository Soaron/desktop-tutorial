## Вторая версия

Вариант платы с операционником AD8066 полностью повторяет схему [Stanson][id_Stanson].  
Настройка осциллографа также полностью идентична рекомендациям автора.  
Необходимо определить максимальное входное напряжение для Вашего экземпляра АЦП,  
которое может различаться в зависимости от партии АЦП. Рзличие очень __не__большое  
но оно есть.  

Единственное отличие от схемы автора, это делитель управляемый при помощи новой  
прошивки процессора, который был скопирован с проекта [NeilScope3][id_NeilScope]  
Делитель нуждается в небольшой корректировке амплитудно частотной характеристики  
(АЧХ) при помощи двух конденсаторов в зависимости от чувствительности.  

* [Схема][Scheme] в формате sPlan7.0
В схеме использован двухстабильный дистанционный переключатель:  
__G6KU-2G-Y__  
Вместо него можно использовать:  
__IM41GR__  

* [Разводка][Lay] платы в формате SprintLayout 6.0
* [Файл прошивки 1.03.hex][FirmWare]
Прошивал при помощи PicKit2  
* [Архив с программой][Soft] интерфейса осциллографа
* [Ссылка на драйвера][Driver] libusb-win32 (Sourceforge.net)

Готовое устройство  
![picT][PicT]
![picB][PicB]



[id_Stanson]:http://www.stanson.ch/index.php?page=proj&proj=USB-oscope
[id_NeilScope]:https://hobby-research.at.ua/publ/razrabotki/izmerenija/neil_scope_3/4-1-0-42
[Scheme]:Screens/AD8066-SOT23-5.spl7
[picT]:Screens/Top.JPG
[picB]:Screens/Back.JPG
[Lay]:Screens/AD8066-SOT23-5.lay
[FirmWare]:Screens/usb-oscope_v1.03.hex
[Soft]:Screens/Soft.rar
[Driver]:https://sourceforge.net/projects/libusb-win32/
