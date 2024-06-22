// See https://aka.ms/new-console-template for more information
int b = 5;
Metot1(b);
Console.WriteLine($"Metot1 sonucu b'nin değeri = {b}");


Metot2(ref b);
Console.WriteLine($"Metot2 sonucu b'nin değeri = {b}");


Console.WriteLine($"Metot4 sonucu b'nin değeri = {Metot4(ref b)}");


Console.WriteLine("Hello, World!");

#region 1.senaryo
//Metot1 metodunu yukarıda çağırıp parametre olarak b'yi verdiğimizde DEEPCOPY ile b'nin değerini a'ya atayacak ve bellekte yeni bir a değişkeni tanımlanıp değeri b ile aynı olacak şekilde kopyalanacak. Daha sonra metot içinde biz a'nın değerini değiştirsek bile bu sadece a'yı etkileyecek, b değeri değişmeyecek.
void Metot1(int a)
{
    a = 50;
};
#endregion

#region 2.senaryo REF keyword'ü ile value type'ların ref type gibi davranmasını sağlamak
//Metot2 'de ise biz parametrenin değerini değil referansını aldığımızdan dolayı, metot içindeki değişiklikler gelen değişkeni de etkileyecek ve değişmesine sebep olacaktır. Bellekte a ve b farklı tanımlamalar değil aynı tanımlamayı işaret edeceğinden dolayı birindeki değişim, diğerini de etkileyecektir.
void Metot2(ref int a)
{
    a = 533;
};
#endregion

#region 3.senaryo Metotların geriye value type referansları döndürmesi 
//Bu şekilde bir metot int türünde bir değer döndürecektir
int Metot3(int a)
{
    return a = 533;
};

//biz ise int türünde bir referans döndürmesini istiyorsak metotdu REF keyword'ü ile işaretlemeliyiz.
ref int Metot4(ref int a)
{
    a = 111;
    return ref a;
};
#endregion
