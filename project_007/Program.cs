//Rastgele değer oluşturabilmek için bir kısayol değişkeni oluşturdum.
Random rastgele = new Random();

//numbers adlı liste değişkeni oluşturup, en fazla 10 değer alabileceğini belirttim.
int[] numbers = new int[10];

//numbers[] listesi içerisindeki tüm değerlere rastgele aracılığıyla 0 ile 100 arasında ki sayılar ile doldurdum.
for (int i = 0; i < numbers.Length; i++){
    numbers[i] = rastgele.Next(0, 100);
}

//numbers[] liste değişkeninin içindeki tüm değerleri sırasıyla konsol ekranına yazdırdım.
for (int i = 0; i < numbers.Length; i++){
    Console.WriteLine(string.Format("{0}. {1}", (i+1), numbers[i]));
}
Console.ReadKey();