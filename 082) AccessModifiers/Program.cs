
// Access Modifiers -> Erişim Belirteçleri

using _082__AccessModifiers;

Sample x = new Sample();

x.PublicProperty = 1;
x.InternalProperty = 2;
//x.PrivateProperty = 4; // Class içerisinde private tanımlandığı için class dışarısında bir alanda erişemez.

// Erişim seviyesi arttıkça, güvenlik seviyesi azalır.
// Güvenlik seviyesi arttıkça, erişim seviyesi azalır.
// Ters orantı vardır.

// Bir yapının erişilebilirlik seviyesini belirlemek için erişim belirteçleri kullanılabilir.

// public -> her yerden erişilebilir.
// internal -> aynı projede erişilebilir.
// private -> yalnızca aynı scope içerisinde erişilebilir.

// EN YÜKSEK PROTECTON LEVEL -> Private
// EN DÜŞÜK PROTECTON LEVEL -> Public

// Bir access modifiers yazılmadığı zaman yapı alabileceği en düşük güvenlikli modifieri default olarak alır. ( Class -> Internal, Property -> Private, Metot -> Private )