//db deki product tablomdaki tüm verileri listeye ata
List<Product> plist = db.Products.ToList();
 
//ürünleri isme göre listele ve listeme ata
List<Product> plist2 = db.Products.OrderBy(p => p.ProductName).ToList();
 
//ürünleri isme göre tersten listele
List<Product> plist3 = db.Products.OrderByDescending(p => p.ProductName).ToList();

//ürünleri tersten listele ve ilk 5 ürünü yakalayıp listeme ata
List<Product> plist4 = db.Products.OrderByDescending(p => p.ProductName).Take(5).ToList();
 
//id si 5 olan ürün yakala
Product prdc = db.Products.FirstOrDefault(p => p.ProductID == 5);
 
//id si 3 olan ürünün ADINI ver
string ad = db.Products.FirstOrDefault(p => p.ProductID == 3).ProductName;
 
//Kategori ID si 5 olan ürünlerin listesi
List<Product> plist5 = db.Products.Where(p => p.CategoryID == 5).ToList();
 
//Kategori ID si 3 ve Supplier ID si 2 olan ürünleri isme göre sırala ilk 5 imi al
List<Product> plist6 = db.Products.Where(p => p.CategoryID == 3 && p.SupplierID == 2).OrderBy(p => p.ProductName).Take(5).ToList();
 
//productname a harfi geçen ürünlerin listesi
List<Product> plist7 = db.Products.Where(p => p.ProductName.Contains("a")).ToList();
 
//product name a harfi ile BAŞLAYAN ürünlerin listesi
List<Product> plist8 = db.Products.Where(p => p.ProductName.StartsWith("a")).ToList();
 
//productname a harfi ile BİTEN ürünlerin listesi
List<Product> plist9 = db.Products.Where(p => p.ProductName.EndsWith("a")).ToList();
 
//Kategori Var Mi
bool VarMi = db.Categories.Any();
 
//Kategori IDsi 5 olan kategori var mı_
bool VarMi2 = db.Category.Any(c => c.CategoryID == 5);
 
//İsminde 'ha' içeren ürün var mı? Küçük veya büyük harf farketmez
bool VarMi3 = db.Product.Any(p => p.ProductName.Contains("ha"));
 
//Ürün dizisine atar
Product[] pdizi = db.Products.ToArray();
 
//ürün sayısı
int adet = db.Products.Count();
 
//product tablomdaki QuantityPerUnit sayısı(tabloda bu kolon eğer null ise toplama eklenmeyecektir)
int adet2 = db.Products.Count(p => p.QuantityPerUnit != null);
 
//product tablomdaki ürün fiyatlarımın toplamı
decimal? toplamfiyat = db.Products.Sum(p => p.UnitPrice);
 
//en pahalı ürünüm
decimal? pahaliurun = db.Products.Max(a => a.UnitPrice);
 
//isme göre sıraladığında ilk 5 ürünü atla kalan ürünleri listele
List<Product> plist10 = db.Products.OrderBy(p => p.ProductName).Skip(5).ToList();
 
//isme göre sıraladığında ilk 5 ürünü atla 10 ürünü listele
List<Product> plist11 = db.Products.OrderBy(p => p.ProductName).Skip(5).Take(10).ToList();
 
 
//order tablosundaki shipcountry kolonuna distinct uygular(sql karşılığı "select distinct o.ShipCountry //from Orders o")
List<string> countrylist = db.Orders.Select(a => a.ShipCountry).Distinct().ToList();
 
//product tablosundaki primary key alanındaki değere eşdeğer product getirir(5 numaralı ProductID //değerini getirir)
Product prdct = db.Products.Find(5);
