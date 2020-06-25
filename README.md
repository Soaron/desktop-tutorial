
# Простой USB осциллограф
Очень понравился [_"Простой USB осциллограф" от Stanson_][id1], и особенно понравились 
скриншоты осциллограмм которые под линуксом.

Решено было повторить его конструкцию. 
После повторения выяснилось, что хорошо настроить АЧХ входного аттенюатора
очень сложно. Сложность настройки сводила на нет всю привлекательную 
простоту конструкции. Но машинка работала и убивать её не хотелось. 
После некоторых изысканий была найдена прекрасно разработанная схема 
входного аттенюатора осциллографа [_NeilScope3_][id2]. 

Схема аттенюатора была скопирована полностью, безо всяких изменений. 
Также была доработана прошивка процессора PIC 18F2550 позволяющая управлять 
входным делителем осциллографа, и полностью переписана программа мордочки
осциллографа под Windows. 

Осциллограф "Видит" частоты до 2 МГц (в случае использования 
высокоскоростных операционников AD8065 и AD8129) и правильно определяет 
частоту и уровень сигнала. Также скорректирована программа визуального 
отображения АЧХ. И настройки цветов экрана и осциллограммы.

Новые и более совершенные варианты печатных плат, только приветствуются, 
также привествуется более совершенное программное обеспечение, как для винды 
так и для PIC 18F2550, которое например, будет исключать стробоскопический 
эффект при различных частотах развёртки осциллографа.

Выбрать один из проектов можно [здесь][id3].

Скачать прошивку для PIC 18F2550 [здесь][id4].

Программа для готового устройства [здесь][id5].

Исходники прошивки и мордочки осциллографа [здесь][id6].

Проект открытый, а потому "Твори выдумывай пробуй!"


[id1]:http://www.stanson.ch/index.php?page=proj&proj=USB-oscope
[id2]:https://hobby-research.at.ua/publ/razrabotki/izmerenija/neil_scope_3/4-1-0-42
[id3]:Done/HardWare/
[id4]:(Done/Firmware/usb-oscope v1.03.hex)
[id5]:Done/Soft/
[id5]:Sources/
