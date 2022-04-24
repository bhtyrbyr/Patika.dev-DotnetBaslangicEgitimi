# Ders 1 - İlk Console App
* Bu derste dotnet SDK kurulumunu, terminal üzerinden bir ***dotnet console app*** oluşturmayı öğrendik. 
<br>
## Aşama 1 - Dotnet SDK Kurulumu
<br>
Windows işletim sistemleri için ;

[Dotnet-link](https://dotnet.microsoft.com/download) 

üzerinden kurulum dosyasını indirip kurabilirsiniz.

Dotnet SDK kurulu olup olmadığını, kurulu ise hangi sürümü yüklendiğini kontrol etmek için;

```
dotnet --version
```
komutunu kullanıyoruz. Eğer yüklü ise terminalde yüklü olan SDK sürmünü görmemiz gerekiyor. Örnek bir terminal çıktısı;
```
Microsoft Windows [Version 10.0.19044.1645]
(c) Microsoft Corporation. All rights reserved.

C:\Users\bhtyrbyr>dotnet --version
5.0.407

C:\Users\bhtyrbyr>
```
--------------------------
<br>

## Aşama 2 -Terminal Üzerinden İlk Dotnet Projesinin Kurulumu
<br>
İlk aşama olan ***Dotnet SDK Kurulumu*** aşamasını tamamladıktan sonra terminal üzerinden projeyi oluşturmak istediğimiz dizine geliyoruz.

İstenilen dizine geldiğimizde terminal üzerinden ***dotnet consoleapp*** oluşturup açmak için;
```
dotnet new console
```
komutunu kullandık. Bu komut sonrası oluşturduğumuz dizinde;

- obj/
- Klasor_Adi.csproj
- Program.cs

dosyaları oluştu. Bundan sonrasında çalıştırmak istediğimiz kodları Program.cs içerisine yazmalıyız. Örnek Program.cs dosyası;
```
using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```
şeklindedir.

------------------------------------------------
<br>

## Aşama 3 - Oluşturulan Projeye Debug Eklenmesi

<br>

Kodlarımızı yazdıktan sonra derlenerek çalıştırılması gerekir. Bunun için VS Code'un **Run and Debug** menüsünden "*create a launch.json file.*" seçeneği seçilerek açılan menüden **.Net Core**, **.Net 5** veya **.Net5+ and .Net Core** seçilmelidir.

<br>

Bu seçim yapıldıktan sonra proje klasörünüze "*.vscode*" dosyası eklenecek ve içerisinde;

- launch.json
- tasks.json

dosyaları eklenecektir.

<br>

Bu aşamadan sonrasında **Run and Debug** menüsünden projenizi çalıştırabilirsiniz.

---------------
<br>

## Aşama 4 - "*launch.json*" İçerisinden Console Seçimi

<br>

Console projelerimiz için birden fazla console seçeneğimiz bulunuyor. Bunlardan bazıları şunlardır:

- internalConsole
- integratedTerminal
- externalTerminal

<br>

### 1. internalConsole

<br>

Bu konsol seçeneği varsayılan olarak gelmektedir. Değer okuması yapamadan sadece çıktı almak için kullanılır. VS Code içerisinden çalışır.

<br>

### 2. integratedTerminal

<br>

Bu konsol seçeneği ile console üzerinden input alabilir, alınan inputlar üzerinden işlem yapıp çıktı alabilirsiniz. VS Code içerisinden çalışır.

<br>

### 3. ExternalTerminal

<br>

Bu konsol seçenği "*integratedTerminal*" ile aynı işlemi yapmaktadır. Aralarındaki fark externalTerminal harici bir pencerede açılır.
