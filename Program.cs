using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            #region Zmienne
            Console.WriteLine("Type in your name: ");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello!");
            Console.WriteLine(userName);

            string someText = "Some text.";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = false;

            DateTime now = DateTime.Now; // Aktualna godzina
            Console.WriteLine(now);
            DateTime dateOfBirth = new DateTime(2000, 6, 6);

            byte byteNumber = 200;
            float floatNumber = 1.5f; // Trzeba dopisać "f" aby program wiedział że to float
            decimal decimalNumber = 1.5m; // Trzeba dopisać "m" aby program wiedział że to decimal
            double doubleNumber = 1.5; // Jeżeli nic nie dopiszemy to program sam uzna że typem zmienno przcinkowym jest double



            // Stringi

            string message1;
            message1 = "Some value";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);

            string message3 = string.Empty;
            Console.WriteLine(message3);

            string text = "He said \"Hi\"";
            string windowsLocation = "c:\\windows";
            Console.WriteLine(text);
            Console.WriteLine(windowsLocation);

            string fontsFolder = @"c:\windows\fonts"; // Dodajemy @ aby przy dużej ilości \ nie pisać ich podwójnie tylko raz.
            Console.WriteLine(fontsFolder);           // Jest to String dosłowny. Ale zawsze bedzie trzeba poprzedzić znak " backslashem.

            string concatenated = string.Concat(text, " to ", "me"); // Są to połączenia stringów
            string concatenated2 = text + " to " + "me";
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);

            string interpolated = $"{text} to me"; // To spowalnia wydajność
            Console.WriteLine(interpolated);


            StringBuilder sb = new StringBuilder("This"); // To jest rozwiązanie do interpolated aby nie spowalniało to wydajności pogramu
            sb.Append("is");
            sb.Append('a');
            sb.Append("long");
            sb.Append("text");

            string result = sb.ToString();
            Console.WriteLine(result);

            #endregion


            #region Powszechne operatory
            // Powszechne operatory


            int wynik;
            int x = 10;
            int y = 5;
            wynik = (x + y);
            Console.WriteLine("Wynik dodawania x + y to: " + wynik);

            wynik = (x - y);
            Console.WriteLine("Wynik odejmowania x - y to: " + wynik);

            wynik = (x * y);
            Console.WriteLine("Wynik mnożenia x * y to: " + wynik);

            wynik = (x / y);
            Console.WriteLine("Wynik dzielenia x / y to: " + wynik);

            wynik = (x % y);
            Console.WriteLine("Wynik modullo z  x % y to: " + wynik);

            int value = (2 + 2) * 5; // 20

            Console.WriteLine("************************************");

            int value1 = 10;
            int value2 = 10;
            Console.WriteLine("Pre-icrement result: ");
            Console.WriteLine(++value1);

            Console.WriteLine("Post-increment result: ");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);


            Console.WriteLine("\n**************************\n");
            bool boolResult;
            x = 2;
            y = 10;

            boolResult = (x == y); // Czy są równe
            Console.WriteLine("(x == y) - " + boolResult);

            boolResult = (x > y); // Czy x jest więkrzy od y
            Console.WriteLine("(x > y) - " + boolResult);

            boolResult = (x < y); // Czy x jest mniejszy od y
            Console.WriteLine("(x < y) - " + boolResult);

            boolResult = (x >= y); // Czy x jest wiekrzy bądź równy y
            Console.WriteLine("(x >= y) - " + boolResult);

            boolResult = (x <= y); // Czy x jest mniejszy bądź równy y
            Console.WriteLine("(x <= y) - " + boolResult);

            boolResult = (x != y); // Czy x jest rózny od y
            Console.WriteLine("(x != y) - " + boolResult);


            Console.WriteLine("\n**************************\n");

            // Operatory logiczne zmiennej bool


            bool a = true;
            bool b = false;

            boolResult = a && b;
            Console.WriteLine("Operator AND: a && b = " + boolResult);

            boolResult = a || b;
            Console.WriteLine("Operator OR: a || b = " + boolResult);

            boolResult = !a;
            Console.WriteLine("Operator NOT: a! = " + boolResult);

            Console.WriteLine("\n**************************\n");

            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);

            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }

            #endregion


            #region if-else 

            Console.WriteLine("Whats your birth year: "); // Podajesz w jakim roku się urodziłeś
            string userInput = Console.ReadLine(); // Program to odczytuje

            int yearOfBirth = int.Parse(userInput); // Wartość jest parsowana na typ int
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18; // Warunek który sprawdza czy w tym momencie masz powyżej 18 lat
            if (isUserOver18)
            {
                Console.WriteLine("Hello!"); // Jeżeli ten warunek okaże się prawdziwy to dalsze elseif oraz else nie zostaną wykonane i zobaczymy "Bye"
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Oh well its Tuesday");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            Console.WriteLine("Bye");
            #endregion

            #region Switch

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("\nToday is Monday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("\nLast day of the week");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("\nIts Weekend");
                    break;
                default:
                    Console.WriteLine("\nThe middle of the week");
                    break;
            }
            #endregion


            #region Konwersja typów i rzutowanie

            byte byteValue = 100; // nadanie zmiennej byteValue wartości 100
            int intValue = byteValue; // Konwesja jej na typ int
            byte byteValue2 = (byte)intValue; // Jeżeli chcemy na odwrót to musimy dać w nawiasie wartość na jaką chcemy dokonać konwersji
            double doubleValue = 3.5;
            int intValue2 = (int)doubleValue;

            string stringValue2 = intValue.ToString(); // Aby konwertować na string wystarczy dodać .ToString()


            string userInputs = Console.ReadLine();
            int yearOfBirths;
            if(int.TryParse(userInputs,out yearOfBirths))
            {
                int age = DateTime.Now.Year - yearOfBirths;
                Console.WriteLine("Your age is: " + age);
            }
            else
            {
                Console.WriteLine("Incorect value");
            }
            #endregion


            #region BMI
            Console.WriteLine("Witaj w kalkulatorze BMI.");
            Console.WriteLine("\nPodaj swoją wagę (kg): ");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj teraz swój wzrost (metry): ");
            double wzrost = Convert.ToDouble(Console.ReadLine());

            double bmi = waga / (Math.Pow(wzrost,wzrost));
            
            if(bmi >= 35)
            {
                Console.WriteLine("Otyłość olbrzymia");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("Otyłość");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Nadwaga");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Waga normalna");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }

            Console.WriteLine("Twoje BMI wynosi: " + bmi);

            #endregion
*/
            #region Tablice i pętle

            string[] cars = { "Volvo", "BMW", "Audi", "Lexus", "Porsche", "Mazda"};
            Console.WriteLine(cars[0]);

            int arrayLenght = cars.Length; // 6
            cars[5] = "Tesla";

            Console.WriteLine(cars[cars.Length - 1]);

            Console.WriteLine("**************************");


            // Pętla while

            int i = 0;
            while(i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW") // Jeżeli program znajdzie pole w tablicy o nazwnie "BMW" to działanie pętli zakończy sie
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }



            // Pętla do-while

            Console.WriteLine("To exit, type 'x'");
            string toExit;

            do // Mamy pewność że pętla wykona się minimum 1 raz
            {
                toExit = Console.ReadLine();
                Console.WriteLine($"Echo: {toExit} ");
            } while (toExit != "x"); // Jeżeli wpiszemy cos innego niż x to pętla będzie sie powtarzałć, za to jak wpiszemy pętla przestanie działać



            // Pętla for

            for(int j =  0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]); // wypisze nam to wszystko co jest w tabeli cars
                if (cars[j] == "BMW")
                {
                    Console.WriteLine("Bye"); // Jeżeli wypisze "BMW" to pętla się zamknie
                    break;
                }
            }

            Console.WriteLine("****************************");

            // Pętla foreach

            foreach (string car in cars)
            {
                Console.WriteLine(car);
                if (car == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            
            #endregion


        }
    }

    #region GradeCalculator
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage)
        {
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
    #endregion


    #region ParkingCalculator
    public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;
            double fee = 5.0; // Opłata za pierwszą godzinę

            switch (hours)
            {
                case 1:
                    result = fee;
                    break; // Opłata za pierwszą godzinę jest już przypisana
                default:
                    result = fee + (hours - 1) * 3.0; // Opłata za pierwszą i kolejne godziny
                    break;
            }

            return result;
        }
    }
    #endregion
}