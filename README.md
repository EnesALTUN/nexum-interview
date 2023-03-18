# Nexum Interview
Robotik bir gezgin, Mars gezegeninin yüzeyine NASA tarafından konumlandırılmıştır. Dikdörtgen şeklinde olan bu yüzey, robotik gezginin üzerindeki kamera yardımıyla görüntülenmekte ve bu görüntüleri robotik gezgin dünyaya yollamaktadır.

Robotik gezginin pozisyonu ve konumu, x-y koordinatları ve pusulada yer alan yön harfleri ile belirtilmektedir (N,W,S,E). Mars yüzeyindeki bu yüzey, x ve y koordinatlarına göre bölünmüştür. Robotik gezgin için 0,0,N pozisyonu, diktörtgen yüzeyin sol alt köşesinde ve yönünün kuzeye dönük olduğunu göstermektedir.

NASA robotik gezgini kontrol etmek için bir takım harf katarları göndermektedir. Gönderilebilen harfler ise ‘L’, ‘R’ ve ‘M’ dir. ‘L’ ve ‘R’ komutu, robotik gezgini ve kamerasını hiç hareket ettirmeden olduğu yerde 90 derece sola ya da sağa döndürmektedir. ‘M’ ise robotik gezgini bulunduğu yönde bir adım ilerletmektedir.

Robotik gezgin, (x,y) koordinatından (x,y+1) koordinatına konumlandığında kuzey (N) yönünde 1 adım gittiği kabul edilmektedir.

## Input:

Ekrandaki ilk input, Mars’taki yüzeyin sağ üst köşesinin koordinatı olacaktır. Sol alt köşe koordinatı (0,0) olarak kabul edilecektir.

Ekrandan alınan ikinci input, robotik gezginin ilk bulunduğu konum olacaktır. Bir boşluk ile ayrılacaktır.

Ekrandan alınan son input ise NASA’dan gönderilen harf katarı olacaktır. Bu katarın içinde sadece L,R ve M harfleri olabilir.

Yüzeyde iki adet robotik gezgin bulunmaktadır. Bir robot hareketini bitirmeden diğer robot hareketine başlayamaz.

NASA’dan gönderilen harf katarları sonucu robotik gezginin son konumu, diktörtgen yüzeyin bulunduğu x veya y koordinatından en az birini aşarsa, aşan koordinat dikdörtgenin maksimum konumunda kalacaktır. (ÖRN: diktörtgenin koordinatları 0,0 ve 5,5 ise ve yeni konum 7,4 çıktı ise robotik gezginin son konumu 5,4 olacaktır.)

## Output:
Her iki robotun da son konumu ve yönü gösterilmelidir.

## Test Input:

5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM

## Beklenen Output:

1 3 N

5 1 E
