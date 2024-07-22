namespace LearningObjects
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 1");
            int[] numArray1 = { 1, 2, 3, 4 };
            int[] numArray2 = { 1, 2, 3, 5 };
            CheckArraySumModulus(numArray1);
            CheckArraySumModulus(numArray2);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 2");
            int[] numArray3 = { 2, 1, 3 };
            int[] numArray4 = { 1, 2, 3 };
            CheckFirstArrayElement(numArray3);
            CheckFirstArrayElement(numArray4);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 3");
            int[] numArray5 = { 1, 2, 3, 4, 5 };
            int[] numArray6 = { 1, 2, 3, 5, 6 };
            CheckFirstAndLastArrayElement(numArray5);
            CheckFirstAndLastArrayElement(numArray6);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 4");
            int[] numArray7 = { 1, -3 };
            int[] numArray8 = { 1, 2 };
            int[] numArray9 = { -1, -2 };
            CheckArrayElementsIfPositive(numArray7);
            CheckArrayElementsIfPositive(numArray8);
            CheckArrayElementsIfPositive(numArray9);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 5");
            int[] numArray10 = { 1, 2, 3, 4 };
            int[] numArray11 = { 1, 11, 3, 5 };
            CheckArrayAverageOfOneAndThree(numArray10);
            CheckArrayAverageOfOneAndThree(numArray11);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 6");
            int[] numArray12 = { 4, 1, 3 };
            int[] numArray13 = { 1, 9, 1 };
            CheckArrayAllDifferentElements(numArray12);
            CheckArrayAllDifferentElements(numArray13);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 7");
            int[] numArray14 = { 100, -3, 276, 150 };
            int[] numArray15 = { 1, 499, 3, 4 };
            CheckArrayTwoElementsMoreThanFifty(numArray14);
            CheckArrayTwoElementsMoreThanFifty(numArray15);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 8");
            int[] numArray16 = { 16, 35 };
            int[] numArray17 = { 21, 26 };
            CheckArrayForPerfectSquare(numArray16);
            CheckArrayForPerfectSquare(numArray17);

        }

        /*task 1*/
        public static void CheckArraySumModulus(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i;
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("Suma yra lyginė : " + sum);
            }
            else { Console.WriteLine("Suma yra nelyginė : " + sum); }

        }

        /*task 2*/
        public static void CheckFirstArrayElement(int[] arr)
        {
            if (arr[0] > arr[1] && arr[0] < arr[2])
            {
                Console.WriteLine("Pirmas elementas yra tarp antro ir trečio");
            }
            else { Console.WriteLine("Pirmas elementas nėra tarp antro ir trečio"); }

        }

        /*task 3*/
        public static void CheckFirstAndLastArrayElement(int[] arr)
        {
            if ((arr[0] % 2 == 1) && (arr[arr.Length - 1] % 2 == 0))
            {
                Console.WriteLine("Pirmas nelyginis, paskutinis lyginis");
            }
            else { Console.WriteLine("Sąlyga neatitinka"); }

        }

        /*task 4*/
        public static void CheckArrayElementsIfPositive(int[] arr)
        {
            if ((arr[0] < 0 && arr[1] > 0) || (arr[1] < 0) && arr[0] > 0)
            {
                Console.WriteLine("Vienas elementas neigiamas, kitas teigiamas");
            }
            else { Console.WriteLine("Abu elementai teigiami arba abu neigiami"); }

        }

        /*task 5*/
        public static void CheckArrayAverageOfOneAndThree(int[] arr)
        {
            if (arr[1] == ((arr[0] + arr[2]) / 2))
            {
                Console.WriteLine("Antras elementas yra lygus pirmo ir trečio vidurkiui");
            }
            else { Console.WriteLine("Antras elementas nėra lygus pirmo ir trečio vidurkiui"); }

        }

        /*task 6*/
        public static void CheckArrayAllDifferentElements(int[] arr)
        {
            if (arr[0] != arr[1] && arr[0] != arr[2] && arr[1] != arr[2])
            {
                Console.WriteLine("Visi elementai yra skirtingi");
            }
            else { Console.WriteLine("Yra bent du vienodi elementai"); }

        }

        /*task 7*/
        public static void CheckArrayTwoElementsMoreThanFifty(int[] arr)
        {
            if ((arr[0] > 50 && arr[1] > 50) || 
                (arr[0] > 50 && arr[2] > 50) || 
                (arr[0] > 50 && arr[3] > 50) || 
                (arr[1] > 50 && arr[2] > 50) || 
                (arr[1] > 50 && arr[3] > 50) || 
                (arr[2] > 50 && arr[3] > 50))
            {
                Console.WriteLine("Bent du elementai didesni už 50");
            }
            else { Console.WriteLine("Mažiau nei du elementai didesni už 50"); }

        }

        /*task 8*/
        public static void CheckArrayForPerfectSquare(int[] arr)
        {
            int firstElement = Convert.ToInt32(Math.Sqrt(arr[0]));
            int secondElement = Convert.ToInt32(Math.Sqrt(arr[1]));

            if ((arr[0] > 0 || arr[1] > 0) && ((arr[0] == firstElement*firstElement) || (arr[1] == secondElement * secondElement)))
            {
                Console.WriteLine("Yra tobulas kvadratas");
            } else
            {
                Console.WriteLine("Nėra tobulo kvadrato");
            }
            
        }
    }
}