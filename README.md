# weatherForecastApplication
weather forecast application with Asp.Net MVC c#

Turkish / [English](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/README(english).md)

#### NOT: Proje içerisindeki veriler Türkiye Cumhuriyeti Meteoroloji Genel Müdürlüğü kurumundan elde edilmiş gerçek veriler olduğundan yasal nedenlerden dolayı veri tabanı dosyası paylaşılmamıştır. Veri tabanı modeli bu yazının devamında ekran görüntüsü olarak gösterilmektedir.

### ÖZET

Hava tahmini meteorolojinin kalbinde yer alır, bu işle yoğrulan birçok genç insan, milyonlarca insanın yaşamı etkileyen hava olaylarını doğru tahmin etmeye ve açıklamaya çalışırlar. Hava tahminleri birçok insanı ve birçok ülkeyi etkiler.Bu sebeple projemizde hava durumu tahmini konusunu veri tabanı ve algoritmalar ile internet sunucusu üzerinden gerçekleştirilmektedir. Veri tabanı ile geçmiş verileri kullanarak birtakım algoritmalarla hava durumu tahmini projede gerçekleştirilmiştir.

Anahtar Kelimeler: hava durumu, tahmin, veri tabanı, algoritma, web, sunucu.

### GİRİŞ

Hava Tahmini; Belirli bir ülke, bölge veya merkezde, bir zaman dilimi içinde görülebilecek meteorolojik olayların gözlem ve analizlere dayanılarak sübjektif veya objektif yöntemler kullanılarak önceden öngörülme çalışmaları hava tahmini olarak adlandırılır.
Hava Tahmini Üç Aşamalıdır:

-	Gözlemler
-	Analiz
-	Tahmin

Bu projede analiz ve tahmin aşamaları ile sonuçlar alınmıştır. Gözlem verilerini ise Meteoroloji Genel Müdürlüğünün hazırladıkları sistemlerden hazır olarak alınmıştır. Çünkü gözlem adımı fiziksel materyaller ile yapılmakta olduğundan proje için hazır olarak almak daha mantıklı olacaktır. Meteoroloji Genel Müdürlüğünden aldığımız verilerde 01.01.2018 ile 01.01.2019 tarihleri arasındaki Kütahya ilinin 5 ilçesinde bulunan istasyonlardan günlük olarak ortalama hava durumu değerleri alınmıştır. Bu ilçeler sırasıyla Kütahya (Merkez), Emet, Simav, Gediz ve Altıntaş’tır. Bu istasyonlardan günlük olarak ortalama sıcaklık, ortalama aktüel basınç ve ortalama nem değerleri alınmıştır.Web sitesinde göz yormayan mavi tonları ile beyaz kullanılmıştır. 

Site geçişleri için sayfaların sağ üst köşesinde sırasıyla Ana sayfa, Hakkımızda ve İletişim butonları bulunmaktadır. Ana sayfada mevcut günden itibaren bir hafta sonrasına kadar olan günlerin sıcaklık, basınç ve nem değerlerinin tahminlerinin bulunduğu alan yer almaktadır. Hakkımızda kısmında proje ekip üyelerinin isim, soy isim, fotoğraf ve projedeki görevleri bulunmaktadır. İletişim sayfasında ise Kütahya Dumlupınar Üniversitesinin adresi, e-mail bilgisi ve iletişim formu bulunmaktadır.

### İÇERİK
#### WEB SİTESİ TASARIMI 

Bu projede HTML, CSS, Javascript, Bootstrap, ASP .Net MVC C#, LinQ, Github, SQL server ve SQL Server Management Studio teknolojileri kullanılmıştır. Hazır bulunan Bootstrap kütüphanesinde bu proje için gereksiz görülen kısımları çıkartılarak sade ve anlaşılır bir tasarım oluşturulmuştur. Tasarım üzerinde görsel kısımlar oluşturulduktan sonra kullanıcının hava durumu değerlerini anlayabilmesi için hava durumu simgeleri tablo içerisinde gösterilmiştir. Asp .NET MVC’nin önerdiği üzere html kodunun head tag’leri arasında yapılacak işlemleri layout sayfasına aktararak hem kodun düzeninin hem de sabit kısımların kullanım kolaylığını ön plana çıkartılmıştır. Aynı zamanda layout sayfasına telefon için gerekli sayfa yönlendirmelerini de eklenilerek web sitesinin telefon ekranlarını da desteklemesi sağlanmıştır.

#### Ana Sayfa:

![Screenshot Home Page](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Homepage.png)

Kütahya şehri için bir haftalık hava durumu değerleri için günlük alanlar bulunmaktadır. Bu değerler sırasıyla ortalama sıcaklık, ortalama aktüel basınç ve ortalama nem değerleri kullanıcılara sunulmaktadır. Günlük alanlar içerisinde değerler gösterilmektedir.  Bu değerler ile internet üzerinden yapılan araştırmalarla birlikte benzer işlerin algoritma yapıları analiz edilerek ve bunun üzerinden regresyon denklemleri kullanılarak yeni bir tahmin algoritması oluşturulmuştur. Bu sayede ileriye yönelik hava durumu tahmin değerleri oluşturulmuştur. Oluşturulan veriler ile de o günün değerleri gösterilmektedir.

#### Hakkımızda:

![Screenshot About Page](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/AboutPage.png)

Hakkımızda kısmında projede yer alan üyelerin isim ve soy isimleri, projede yer aldığı görevleri ve resimleri görülmektedir. 

#### İletişim:

![Screenshot Contact Page](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/ContactPage.png)

Sonuncu sayfa olan iletişim sayfasında sol tarafta bir adet konum kısmı bulunmaktadır. Buradan Kütahya Dumlupınar Üniversitesinin konumuna erişilmektedir. Kütahya Dumlupınar Üniversitesinin tam adresi, telefon numarası ve eposta adresi gibi iletişim bilgileri de bulunmaktadır. Sağ tarafta ise kullanıcıların bizimle iletişime geçebilmeleri için bir adet form bulunmakta. Bu form sayesinde isim, e-mail, şirket, web site ve mesaj ile kullanıcılar şikayetlerini, önerilerini, sorularını veya buldukları açıklar gibi dilediklerini yazarak bize iletebilmekteler.


### GEÇMİŞ YILLARIN HAVA DURUMU VERİLERİNİN ALINMASI

Bu projede hava durumu verilerinin analizi yapılabilmesi için 1 bölgeye ait 1 yıllık verinin bulunması gerektiği saptanmıştır. Bu çıkarımdan sonra internet üzerinden Türkiye illerinin günlük hava durumlarının kayda geçirildiği veri tabanlarının araştırmaları yapılmıştır. Bu projedeki web sitesi için, yapılan araştırmalar doğrultusunda Türkiye Cumhuriyeti Tarım ve Orman Bakanlığı Meteoroloji Genel Müdürlüğü tarafından sağlanan veriler uygundur.

Meteoroloji Genel Müdürlüğü bu verileri kullanıcılara maddi bir karşılık ile vermektedir. Üniversite araştırmaları için bu veriler ücretsiz verilmektedir. Bu durumda gerekli yönetmeliği uygulayarak Kütahya Dumlupınar Üniversitesi Bilgisayar Mühendisliği bölüm başkanı tarafından onaylı bir dilekçe ile Meteoroloji Genel Müdürlüğüne proje için gerekli verileri ve tarihleri içeren veri tabanı istenmiştir. Bu veri tabanında 01.01.2018 ile 01.01.2019 tarihleri arasındaki Kütahya ilinin 5 ilçesinde bulunan istasyonlardan günlük olarak ortalama hava durumu değerleri yer almaktadır. Bu ilçeler sırasıyla Kütahya (Merkez), Emet, Simav, Gediz ve Altıntaş’tır. Bu istasyonlardan günlük olarak ortalama sıcaklık, ortalama aktüel basınç ve ortalama nem değerleri alınmıştır.

### VERİ TABANI İÇİN TABLOLARIN OLUŞTURULMASI VE VERİLERİN EKLENİLMESİ

Meteoroloji Genel Müdürlüğü’nden alınan veriler birbirinden bağımsız ve Excel tabanlı olduğu için internet tabanlı bir Tool yardımı ile SQL tabanlı ve .mdf uzantılı hale dönüştürülmüştür. Üzerinde MsSQL programı ile düzenlemeler yapılmıştır. Veri tabanı kurulmuştur.

![Screenshot DataBase1](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database0.png)

![Screenshot DataBase2](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database.png)

![Screenshot DataBase3](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database2.png)

### HAVA DURUMU TAHMİN ALGORİTMASI

Literatür taraması yapılmıştır. Benzer projeler incelenmiştir. Çözüm metotları ve algoritmaları sınanmıştır. Başarılı olan algoritma projeye uyarlanmıştır. MsSQL üzerinden gelen veriler üzerinde algoritma test edilmiştir ve yeni oluşan veriler web sitesinde ki alana aktarılmıştır.

### SONUÇLAR

Hava durumu tahmini kompleks ve kapsamlı bir çalışma gerektirmektedir. Bu projede geçmiş verilerle ve çeşitli algoritmalarla yeni tahminler elde edilmiştir. Web sayfası tasarımı için Bootstrap kullanılarak oluşturulmuştur ve ihtiyaç duyulan kodlar yazılarak tasarım tamamlanmıştır.Veri tabanı tasarımı yapılırken Meteoroloji Genel Müdürlüğünün hazırladıkları sistemlerden hazır olarak alınmıştır. Bunun için Meteoroloji Genel Müdürlüğüne Kütahya Dumlupınar Üniversitesi Bilgisayar Mühendisliği bölüm başkanı tarafından onaylı bir dilekçe gönderilmiştir. Gelen veriler için uygun veri tabanı ve tablolar oluşturulmuştur. Veriler oluşturulan alanlara eklenmiştir. Asp.net MVC yapısına uygun olarak HomeController sınıfı oluşturulmuştur. Bu sınıf içerisinde veri tabanı bağlantısı yapılmıştır. Sağlanmış bağlantı ile hava durumu verileri olan tarih, sıcaklık, basınç ve nem gerekli sorgular ile çekilmiştir.

Çeşitli algoritmalar arasında regresyon analizi kullanılmıştır. Regresyon, iki (ya da daha çok) değişken arasındaki doğrusal ilişkinin fonksiyonel şeklini, biri bağımlı diğeri bağımsız değişken olarak bir doğru denklemi olarak göstermektedir ve değişkenlerden birinin değeri bilindiğinde diğeri hakkında kestirim yapılmasını sağlamaktadır. Bu sayede geçmiş hava durumu verileri ile (sıcaklık, basınç ve nem) gelecekti hava durumu değerleri tahmin edilmektedir.
