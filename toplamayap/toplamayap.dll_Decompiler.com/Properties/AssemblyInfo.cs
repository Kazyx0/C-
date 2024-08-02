// Bu isim alanları, .NET derlemesinin meta verilerini ve çalışma zamanında kullanılan sınıfları içerir.
using System.Diagnostics; // Performans izleme ve hata ayıklama ile ilgili sınıflar
using System.Reflection; // Derlemeler ve türler hakkında bilgi edinme
using System.Runtime.CompilerServices; // Derleyiciye özgü özellikler ve sınıflar
using System.Runtime.Versioning; // Uygulamanın hedef platformu ve sürüm bilgileri

// Derlemenin meta verilerini tanımlar

// Derlemenin ait olduğu şirket adı
[assembly: AssemblyCompany("toplamayap")]

// Derlemenin yapılandırması, örneğin "Release" veya "Debug"
[assembly: AssemblyConfiguration("Release")]

// Derlemenin dosya sistemindeki sürüm numarası
[assembly: AssemblyFileVersion("1.0.0.0")]

// Kullanıcıya yönelik bilgilendirme sürüm numarası (genellikle beta sürümleri veya RC sürümleri için kullanılır)
[assembly: AssemblyInformationalVersion("1.0.0")]

// Derlemenin ait olduğu ürünün adı
[assembly: AssemblyProduct("toplamayap")]

// Derlemenin başlığı, genellikle kullanıcı arabirimlerinde görünen başlık
[assembly: AssemblyTitle("toplamayap")]

// Derlemenin ana sürüm numarası, genellikle API uyumluluğunu belirtir
[assembly: AssemblyVersion("1.0.0.0")]

// Modül güvenlik kurallarını belirtir, çalışma zamanı güvenlik kurallarıyla uyumlu olup olmadığını kontrol eder
[module: RefSafetyRules(11)]
//Properties