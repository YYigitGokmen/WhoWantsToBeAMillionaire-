

using System.Threading.Tasks.Sources;

Console.WriteLine("Kim Milyoner Olmak İstere Hoş Geldiniz!");
Console.WriteLine("----------------------------------");

Console.WriteLine("1 -> Hangi şehir Türkiyenin En Doğusundadır?");

int correct = 0;
//bütün koşullara göre tepki veren bir if else yapısı oluşturdum correct değişkeni ile birlikte.
//yarışmacı oyunun sonunu göremediğinde return ile programı orda sonlandırdım.

Console.WriteLine(" a) Çankırı b) Iğdır ");

    string first = Console.ReadLine().ToLower();



            if (first == "b")
            { 
                correct++;
            Console.WriteLine("Doğru!");
            }
                else
            {
                Console.WriteLine("Yanlış");
                }


    Console.WriteLine("2 -> Hangi meyve daha şekerlidir?");

        Console.WriteLine(" a) Muz b) Üzüm ");

            string second = Console.ReadLine().ToLower();

           

            if (second == "b")
                 {
                      correct++;
                 Console.WriteLine("Doğru!");

                if (correct == 2) {

                  Console.WriteLine("TEBRİKLER 1 MILYON TL LIK BÜYÜK ÖDÜLÜ KAZANDINIZ!!!");
                        return;
                             }

                        }
                      else
                     {
                          Console.WriteLine("Yanlış");

                             if (correct == 1 || correct == 0)
                                 {
                                  Console.WriteLine("Malesef ki büyük ödülü kazanma şansınızı kaybettiniz.Yarıştığınız için teşekkürler");
                                                     return;
                                        }

                      }



Console.WriteLine("3 -> Türkiyenin kaç tane sınır komşusu vardır? ");

        Console.WriteLine(" a) 6 b) 8");

            string third = Console.ReadLine().ToLower();

            

            if (third == "b")
                 {
                             correct++;

                 Console.WriteLine("Doğru!");
                    }
                        else
                             {
                        Console.WriteLine("Yanlış");
                         }


            if(correct==2 || correct==3)
                {
                    Console.WriteLine("TEBRİKLER 1 MILYON TL LIK BÜYÜK ÖDÜLÜ KAZANDINIZ!!!");
                    }   






