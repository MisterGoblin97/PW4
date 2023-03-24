namespace PW4_3
{
    internal class Program
    {
        class Orc
        {
            private static int orcCount;
            private const int MaxGoldValue = 2;
            public Orc()
            {
                orcCount++;
            }
            public int ActualGoldValue
            {
                get { if (orcCount <= 5) { return orcCount * MaxGoldValue; } else { return (MaxGoldValue * 5) - (orcCount - 5) * 2; } }
            }
            public void Output()
            {
                Console.Write("У ");
                Console.Write(orcCount);
                Console.WriteLine(" орка сейчас максимальное значение золота ");
            }
        }
        static void Main(string[] args)
        {
            Orc orc_1 = new Orc();
            orc_1.Output();
            Console.WriteLine(orc_1.ActualGoldValue);

            Orc orc_2 = new Orc();
            orc_2.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);

            Orc orc_3 = new Orc();
            orc_3.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);
            Console.WriteLine(orc_3.ActualGoldValue);

            Orc orc_4 = new Orc();
            orc_4.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);
            Console.WriteLine(orc_3.ActualGoldValue);
            Console.WriteLine(orc_4.ActualGoldValue);

            Orc orc_5 = new Orc();
            orc_5.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);
            Console.WriteLine(orc_3.ActualGoldValue);
            Console.WriteLine(orc_4.ActualGoldValue);
            Console.WriteLine(orc_5.ActualGoldValue);

            Orc orc_6 = new Orc();
            orc_6.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);
            Console.WriteLine(orc_3.ActualGoldValue);
            Console.WriteLine(orc_4.ActualGoldValue);
            Console.WriteLine(orc_5.ActualGoldValue);
            Console.WriteLine(orc_6.ActualGoldValue);

            Orc orc_7 = new Orc();
            orc_7.Output();
            Console.WriteLine(orc_1.ActualGoldValue);
            Console.WriteLine(orc_2.ActualGoldValue);
            Console.WriteLine(orc_3.ActualGoldValue);
            Console.WriteLine(orc_4.ActualGoldValue);
            Console.WriteLine(orc_5.ActualGoldValue);
            Console.WriteLine(orc_6.ActualGoldValue);
            Console.WriteLine(orc_7.ActualGoldValue);
        }
    }
}