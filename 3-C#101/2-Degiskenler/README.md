# Ders 2 - Değişkenler

Bu derste değişken türleri, bellekte kapladıkları alanları ve tür dönüşümlerini işledir.

-------

<br>

## 1. Değişken Türleri
1. *Object* :

Tüm değişkenlerin türetildiği değişken türüdür. *Int16* , *byte* , *bool* , *string* gibi verilerin hepsini içerisinde tutabilir.

2. *Bool* : 

Yalnızca **True**, **False** değerini tutabilen en basit değişken türüdür.

3. *Byte*, *Short*, *Int16*, *int*, *Int32*, *Int64*, *Long*

Kendi sınırları içerisinde tam sayı değerleri saklayabilen değişlen türleridir.
```
Değişken Türü                 Min. Değer                   Max.Değer
______________________________________________________________________
Byte                                  -128 |                       127
Short, Int16                       -32 768 |                    32 767
int, Int32                  -2 147 483 648 |             2 147 483 647
long, Int64     -9 223 372 036 854 775 808 | 9 223 372 036 854 775 807
```
4. *Sbyte*, *UShort*, *UInt16*, *uint*, *UInt32*, *UInt64*, *Ulong*

Bir önceki değişken türleri ile aynı olup, negatif değerli alamamktadır.
```
Değişken Türü                 Min. Değer                   Max.Değer
______________________________________________________________________
Byte                            0       |                          255
Short, Int16                    0       |                       65 535
int, Int32                      0       |                4 294 967 295
long, Int64                     0       |   18 446 744 073 709 551 615
```

5. *float*, *double*, *decimal*

Kendi sınırları içerisinde reel sayıları saklayabilen değişken türleridir.
```
Değişken Türü                 Min. Değer                   Max.Değer
______________________________________________________________________
Float                         ±1.5*10^(-45)     |         ±3.4*10^(38) 
Double                       ±5.0*10^(-324)     |        ±1.7*10^(308) 
Decimal                       ±1.5*10^(-28)     |         ±7.9*10^(28) 
```

6. *Char*

Bellekte tek bir karakterlik yer saklamak için kullanılan değişken türüdür. (*Örnk. 'a', '2', '!' vb.*)

7. *String*

Birden çok karakterden meydana gelen metinsel ifadeleri bellekte tutmak için kullanılan değişken türüdür. (*Örnk. 'Deneme', 'Github', 'Metin2' vb.*)

<br>

-------

<br>

## 2. Değişken Türlerinin Bellekte Kapladıkları Alan

<br>

Herbir değişken türü bellekte belirli alan kaplar. Geliştirlecek yazılımın performansını kötü yönde etkilememesi için gereğinden fazla alan kaplayan değişkenleri kullanmamlıyız.

<br>

Örneğin 20 000 değerini bellekte saklamak için *UInt16-Int16-UShort-Short, UInt32-Int32-Uint-int, UInt64-Int64-Ulong-long* 3 adet değişken grubundan birisi kullanılabilir. Aşağıdaki tablodan yola çıkarak bellekte en az yer kaplayarak 20 000 değerini saklamak istersek ***UInt16-Int16-UShort-Short*** grubundan bir değişken türü seçmeliyiz.
```
Değişken Türü                           Bellekte Kapladığı Alan
_______________________________________________________________
Object  .......................................... Limit Yok
Bool    .......................................... 1 Bit
Byte-SByte  ...................................... 1 Byte
Short-UShort-Int16-UInt16   ...................... 2 Byte
int-Uint-Int32-Int32    .......................... 4 Byte
long-Ulong-Int64-UInt64 .......................... 8 Byte
Char    .......................................... 1 Byte
String  .......................................... Limit Yok
```

<br>

-------

<br>