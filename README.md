

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
