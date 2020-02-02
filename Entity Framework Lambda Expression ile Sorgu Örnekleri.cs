//ToList() => Products tablomdaki tüm ürünleri getir.
List<Product> liste = db.Products.ToList();
 
//OrderBy() => Products tablomdaki ürünleri isme göre (A'dan --> Z'ye) sırala sonra ToList() ile liste halinde bana getir.
List<Product> liste = db.Products.OrderBy(p => p.ProductName).ToList();
 
//OrderByDescending() => Products tablomdaki ürünleri testen (Z'den --> A'aya) isme göre sırala sonra ToList() ile liste halinde bana getir.
List<Product> liste = db.Products.OrderByDescending(p => p.ProductName).ToList();

//Take() => Ürünleri tersten listele ve Take() ile ilk 5 ürünü alıp liste halinde bana getir.
List<Product> liste = db.Products.OrderByDescending(p => p.ProductName).Take(5).ToList();
 
//FirstOrDefault() => ProductID si 5 olan ürünü alıp getir.
Product urun = db.Products.FirstOrDefault(p => p.ProductID == 5);
 
//ProductName => ProductID si 3 olan ürünün ProductName'ini getir.
string ad = db.Products.FirstOrDefault(p => p.ProductID == 3).ProductName;
 
//Where => CategoryID si 5 olan ürünlerin listesini getir.
List<Product> liste = db.Products.Where(p => p.CategoryID == 5).ToList();
 
//Kategori ID si 3 ve Supplier ID si 2 olan ürünleri isme göre sırala ilk 5 ini alıp liste olarak getir.
List<Product> liste = db.Products.Where(p => p.CategoryID == 3 && p.SupplierID == 2).OrderBy(p => p.ProductName).Take(5).ToList();
 
//Contains() => ProductName de a harfi geçen ürünlerin listesini getir.
List<Product> liste = db.Products.Where(p => p.ProductName.Contains("a")).ToList();
 
//StartsWith() => ProductName'inde a harfi ile başlayan ürünlerin listesini getir.
List<Product> liste = db.Products.Where(p => p.ProductName.StartsWith("a")).ToList();
 
//EndsWith() => ProductName'inde a harfi ile biten ürünlerin listesini getir.
List<Product> liste = db.Products.Where(p => p.ProductName.EndsWith("a")).ToList();
 
//Any() => Kategori varmı? Varsa true, yoksa false döner.
bool VarMi = db.Categories.Any();
 
//Any() => Kategori IDsi 5 olan kategori var mı?
bool VarMi = db.Category.Any(c => c.CategoryID == 5);
 
//Any() => ProductName de 'ha' içeren ürün var mı? Küçük veya büyük harf farketmez.
bool VarMi = db.Product.Any(p => p.ProductName.Contains("ha"));
 
//ToArray() => Sonucu array'e çevirir.
Product[] dizi = db.Products.ToArray();
 
//Count() => Sonucun toplam sayısını verir. Burda ürün sayısını geterdi.
int adet = db.Products.Count();
 
//Count() => product tablomdaki QuantityPerUnit sayısı(tabloda bu kolon eğer null ise toplama eklenmeyecektir)
int adet = db.Products.Count(p => p.QuantityPerUnit != null);
 
//Sum() => Product tablomdaki ürün fiyatlarının toplamını verir.
decimal? toplamfiyat = db.Products.Sum(p => p.UnitPrice);
 
//Max() Product tablomdaki ürünlerden en yüksek fiyatlı olanını verir
decimal? pahaliurun = db.Products.Max(a => a.UnitPrice);
 
//isme göre sıraladığında ilk 5 ürünü atla kalan ürünleri listele
List<Product> plist10 = db.Products.OrderBy(p => p.ProductName).Skip(5).ToList();
 
//Skip() => ProductName'e göre sıraladığında ilk 5 ürünü atla 10 ürünü listele
List<Product> plist11 = db.Products.OrderBy(p => p.ProductName).Skip(5).Take(10).ToList();
 
//Distinct() => Orders tablosundaki ShipCountry kolonuna distinct uygular(sql karşılığı "select distinct o.ShipCountry //from Orders o")
List<string> countrylist = db.Orders.Select(a => a.ShipCountry).Distinct().ToList();
 
//Find() => Products tablosundaki primary key alanındaki değere eşdeğer product getirir(5 numaralı ProductID //değerini getirir)
Product prdct = db.Products.Find(5);
