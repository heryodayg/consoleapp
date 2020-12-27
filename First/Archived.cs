using System;

namespace consoleapp.First
{
    public class Archived
    {
        public void Run(){
             Deji deji = new Deji();
            int age = deji.Age();
            Console.WriteLine(age);
            string namex = deji.Namex();
            Console.WriteLine(namex);
             string state1 = deji.state1();
            Console.WriteLine(state1);
            string state2 = deji.state2();
            Console.WriteLine(state2);
            bool Correct = deji.Correct();
            Console.WriteLine(Correct);
            string state3 = deji.state3();
            Console.WriteLine(state3);
            string state4 = deji.state4();
            Console.WriteLine(state4);
            string state5 = deji.state5();
            Console.WriteLine(state5);
            string state6 = deji.state6();
            Console.WriteLine(state6);
            bool answer2 = deji.answer2();
            Console.WriteLine(answer2);
            bool answer3 = deji.answer3();
            Console.WriteLine(answer3);
            bool answer4 = deji.answer4();
            Console.WriteLine(answer4);
            int figure = deji.figure();
            Console.WriteLine(figure);
            int figure2 = deji.figure2();
            Console.WriteLine(figure2);
            int figure3 = deji.figure3();
            Console.WriteLine(figure3);
            int figure4 = deji.figure4();
            Console.WriteLine(figure4);
            int a = deji.a();
            int b = deji.b();
            Console.WriteLine(a + b);
            int msaka = deji.Msaka();
            Console.WriteLine(msaka);
            string informal = deji.informal();
            Console.WriteLine(informal);
            bool word = deji.word();
            Console.WriteLine(word);
            int nomber = deji.nomber();
            Console.WriteLine("Id: " + nomber);
            string nome = deji.nome();
            Console.WriteLine("Name : " + nome);
            char gender = deji.gender();
            Console.WriteLine("Gender: " + gender);
            double score = deji.score();
            Console.WriteLine("Score: " + score);
            bool isverified = deji.isverified();
            Console.WriteLine("Status: " + isverified);
            int digit = deji.digit();
            Console.WriteLine("ID: " + digit);
            string developer = deji.developer();
            Console.WriteLine("Name :" + developer);
            char sex = deji.sex();
            Console.WriteLine("Gender : " + sex);
            int age1 = deji.age1();
            Console.WriteLine("Age : " + age1);
            bool statusadeola = deji.statusadeola();
            Console.WriteLine("Status : " + statusadeola);
            string welcomemessage = deji.welcomemessage();
            Console.WriteLine(welcomemessage);
            string further = deji.further();
            Console.WriteLine(further);
            string newwelcome = deji.newwelcome();
            Console.WriteLine(newwelcome);
            string newfurther = deji.newfurther();
            Console.WriteLine(newfurther);
            int number = deji.number();
            Console.WriteLine("ID : " + number);
            int Dob = deji.Dob();
            Console.WriteLine("Age: " + Dob);
            char Sex = deji.Sex();
            Console.WriteLine("Gender: " + Sex);
            string oruko = deji.oruko();
            Console.WriteLine("Name : " + oruko);
            double score1 = deji.score1();
            Console.WriteLine("Score :" + score1);
            bool Status = deji.Status();
            Console.WriteLine("Status: " + Status);
            string nibo = deji.nibo();
            Console.WriteLine(nibo);
            int nsaka = deji.nsaka();
            Console.WriteLine(nsaka);
            string car = deji.car();
            Console.WriteLine(car);
            string hint = deji.hint();
            Console.WriteLine(hint);
            string txt = deji.txt();
            Console.WriteLine("The length of the txt is :" + txt.Length);
            string text = deji.text();
            Console.WriteLine(text.ToUpper());
            string var = deji.var();
            Console.WriteLine(var[2]);
            string space = deji.space();
            Console.WriteLine(space);
            string Newline = deji.Newline();
            Console.WriteLine(Newline);
            string Leo = deji.Leo();
            Console.WriteLine(Leo.Length);
            string perfection = deji.perfectection();
            Console.WriteLine(perfection);
            bool hard = deji.hard();
            Console.WriteLine(10 < 9);
            bool easy = deji.easy();
            Console.WriteLine(30 < 20);
            bool fade = deji.fade();
            Console.WriteLine(b == 5);
            bool fast = deji.fast();
            if (30 > 20)
                Console.WriteLine("30 is greater than 20");
            bool time = deji.time();
            if (30 > 20)
            {
                Console.WriteLine("Good day deji");
            }
            else
            {
                Console.WriteLine("good afternoon deji");
            }
            bool error = deji.error();
            if (50 > 20)
            {
                Console.WriteLine("good evening mr oladeinde");
            }
            else
            {
                Console.WriteLine("good morning mr oladeinde");
            }
            bool salute = deji.salute();
            if (50 > 20)
                Console.WriteLine("we did it man congratulations");
            string trian = deji.trian();
            Console.WriteLine(trian[2]);
            int sleep = deji.sleep();
            while (sleep < 5)
            {
                Console.WriteLine(sleep);
                sleep++;
            }


            int sand = deji.sand();
            for (int t = 0; t <= 10; t = t + 2)
            {
                Console.WriteLine(t);
            }

            int deci = deji.deci();
            do
            {
                Console.WriteLine(deci);
                deci++;
            }
            while (deci < 5);       
            int YES = deji.YES();
            for (int t = 0; t < 5; t++)
            {
                Console.WriteLine("YES");
            }

            int remote = deji.remote();
            for (int z = 0; z < 10; z++)
            {
                if (z == 4)
                {
                    break;
                }
                Console.WriteLine(z);
            }

            int wel = deji.wel();
            while (wel < 10)
            {
                if (wel == 4)
                {
                    wel++;
                    continue;
                }
                Console.WriteLine(wel);
                wel++;
            }

            string dad = deji.dad();
            string[] cars = { "volvo", "BMW", "FORD", "TOYOTA" };
            Console.WriteLine(cars[2]);

            string beast = deji.beast();
            string[] i = { "food", "money", "job" };
            i[1] = "opel";
            Console.WriteLine(i[1]);


            string[] heat = { "music", "song", "BMw", "hiphop" };
            for (int h = 0; h < heat.Length; h++)
            {
                Console.WriteLine(heat[h]);
            }

            string[] machine = { "jet", "boat", "train", "lambo" };
            foreach (string light in machine)
            {
                Console.WriteLine(light);
            }


            string[] scared = { "tobi", "zino", "naira", "marley" };
            Array.Sort(scared);
            foreach (string touch in scared)
            {
                Console.WriteLine(touch);
            }

            int[] myNoM = { 2, 8477, 478, 5, 766 };
            Array.Sort(myNoM);
            foreach (int h in myNoM)
            {
                Console.WriteLine(h);
            }


            string[] tita = { "maga", "bitter", "waje", "kayamata" };
            tita[1] = "dog";
            Console.WriteLine(tita[1]);

            Console.WriteLine("triangle");

            Console.WriteLine("300AD");

            int goldtime = deji.goldtime();
            while (goldtime < 5)
            {
                if (goldtime == 6)
                {
                    goldtime++;
                    continue;
                }
                Console.WriteLine(goldtime);
                goldtime++;
            }

               


           int tecno = deji.tecno();
           Console.WriteLine(tecno);  



          bool away = deji.away();
          if (30 < 10)
          {
            Console.WriteLine("we are there!!!");
          }
          else
          {
            Console.WriteLine("we are still moving");
          }
          
          Deji myObj = new Deji();
          Console.WriteLine(deci);

          
           
           
           int vero = deji.vero();
           Console.WriteLine(vero);


          int saydo = deji.saydo();
          for(int f=0; f<5; f++ )
          {
            Console.WriteLine("Value of F:  {0}" , f);
          }
     


          
          
           int lightday = deji.lightday();
           switch(lightday)
           {
             case 1:
             Console.WriteLine("Its Monday baby");
             break;
             case 2:
             Console.WriteLine("Its tuesday baby");
             break;
             case 3:
             Console.WriteLine("Its wednesday baby");
             break;
             default:
             Console.WriteLine("its Holiday bitches");
             break;
           }
          
          
          
            int weekday = deji.weekday();
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
            }

            int holiday = deji.holiday();
            switch (holiday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
            }


            int bull = deji.bull();
            switch (bull)
            {
                case 6:
                    Console.WriteLine("friday");
                    break;
                case 7:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("everyday is not christmas");
                    break;
            }



            Console.WriteLine("Enter your password");
            Console.Read();
            Console.WriteLine("ENter your username");
            Console.Read();
            string UserName = Console.ReadLine();
            Console.WriteLine("User ID" + UserName);
            Console.WriteLine("Enter your password");
            bool verification = deji.verification();
            Console.WriteLine(verification);

          












        }
    }
}