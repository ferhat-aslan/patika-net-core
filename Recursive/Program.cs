// See https://aka.ms/new-console-template for more information
            byte qw = 5;
            sbyte @as = 30;
            short fr = 10;

            int dw = qw + @as + fr;
            Console.WriteLine("d: " + dw);

            long hf = dw;
            Console.WriteLine("h: " + hf);

            float ih = hf;
            Console.WriteLine("i: " + ih);

            string e = "ferf";
            char f = 'd';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            //ToString Metodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yecy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zxcvz: " + zz);

        
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

           