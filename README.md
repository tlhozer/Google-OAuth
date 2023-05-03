Google OAuth Nedir?

Google OAuth, kullanıcıların Google hesaplarına başka bir uygulama veya hizmet tarafından yetkilendirilmiş erişim sağlamak için kullanılan bir kimlik doğrulama ve yetkilendirme protokolüdür. OAuth, kullanıcıların parola veya kullanıcı adı gibi hassas kimlik bilgilerini paylaşmak zorunda kalmadan, başka bir uygulamanın kullanıcı adına kaynaklara (örneğin e-postalar, takvim etkinlikleri veya fotoğraflar) erişebilmesine olanak tanır.

Adım 1: 😎Google Cloud Console'da Proje Oluşturma

-Google Cloud Console'a gidin: https://console.cloud.google.com/

-Yeni bir proje oluşturun veya varolan bir projeyi seçin.

-Sol üst köşede bulunan "Proje Oluştur" düğmesini tıklayın.

-Proje adını ve diğer gerekli ayrıntıları girin.

-Oluştur" düğmesini tıklayarak projeyi oluşturun.

Adım 2: 😎OAuth Kimlik Doğrulama Hizmeti Ayarları

-Projenin "Kimlik Doğrulama" bölümüne gidin.

-Kimlik Doğrulama Bilgileri Oluştur" düğmesini tıklayın.

-OAuth Kimlik Doğrulama Hizmeti"ni seçin.

-Uygulama türü"nü seçin, örneğin "Web uygulaması" veya "Mobil uygulama".

-Uygulamanın adını ve yetkilendirilmiş URI'yi (geri çağrı URI'si) girin.

-Oluştur" düğmesini tıklayarak kimlik doğrulama bilgilerini oluşturun.

-Oluşturulan kimlik doğrulama bilgilerini not edin. Bu, API erişimi için gereken istemci kimliği (Client ID) ve istemci sırrı (Client Secret) bilgilerini içerir.

Ardından projede GoogleApiCek.cs dosyasına gidin ve oradaki aşağıdaki bilgileri client id ve secret key'e göre kendi anahtar şifreleri ile değiştirin.
Yönlendirmeyide (RedirectUri) kendi localhost dizin sayfanızın bağlantısını kopyalayın

            public static readonly string[] Scopes = { "email", "profile" };
            public static readonly string ClientId = "350077940693-9oh3k57ak13tku86ccu23512on75t104.apps.googleusercontent.com";
            public static readonly string ClientSecret = "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";
            public static readonly string RedirectUri = "https://localhost:44353/WebForm1.aspx";

"readonly" anahtar sözcüğü, sabit bir değişken tanımladığımız ve bu veriyi programın herhangi bir şekilde içeriğini değiştiremeyeceğimiz anlamına gelir.

Ardından tüm ayarları kontrol ettikten sonra uygulamayı başlatabilir ve deneyebilirsiniz.
Ayrıca, google konsol geliştirici sayfasının yönlendirme url bölümünü buradaki bölümle aynı yapın

