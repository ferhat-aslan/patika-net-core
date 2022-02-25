  try
           {
               
               int a = int.Parse("-vdv");
           }
           catch (ArgumentNullException ex)
           {
               Console.WriteLine("boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("veri tipi uygun defil");
               Console.WriteLine(ex);
           }    
           catch (OverflowException ex)
           {
               Console.WriteLine("çok küçük veya .ok büyük deger girdiniz");
               Console.WriteLine(ex);
           }
           finally
           {
               Console.WriteLine("işlem başarı ile tamamlandı");
           }