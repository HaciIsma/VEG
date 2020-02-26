using System;

namespace VEG
{
    class UserInterface
    {
        const string LeftTop = "╔";
        const string RightTop = "╗";
        const string LeftBottom = "╚";
        const string RightBottom = "╝";
        const string HorizontalTop = "╦";
        const string HorizontalBottom = "╩";
        const string VerticalLeft = "╠";
        const string MiddleJoint = "╬";
        const string VerticalRight = "╣";
        const string HorizontalLine = "═";
        const string VerticalLine = "║";

        private static void Header()
        {
            for (int i = 0; i < 100; ++i)
            {
                if (i == 0) Console.Write(LeftTop);
                else if (i == 12 || i == 26 || i == 45 || i == 66 || i == 85) Console.Write(HorizontalTop);
                else if (i == 99) Console.WriteLine(RightTop);
                else Console.Write(HorizontalLine);
            }
            Console.WriteLine($"{VerticalLine} VEG Store {VerticalLine} RANK :      {VerticalLine} CAPITAL :        {VerticalLine} PRODUCT RANGE :    {VerticalLine} CUSTOMERS :      {VerticalLine} DAYS :      {VerticalLine}");
            for (int i = 0; i < 100; ++i)
            {
                if (i == 0) Console.Write(LeftBottom);
                else if (i == 12 || i == 26 || i == 45 || i == 66 || i == 85) Console.Write(HorizontalBottom);
                else if (i == 99) Console.WriteLine(RightBottom);
                else Console.Write(HorizontalLine);
            }
        }
        private static void Subheader()
        {
            for (int i = 0; i < 100; ++i)
            {
                if (i == 0) Console.Write(LeftTop);
                else if (i == 33 || i == 77) Console.Write(HorizontalTop);
                else if (i == 99) Console.WriteLine(RightTop);
                else Console.Write(HorizontalLine);
            }
            Console.WriteLine($"{VerticalLine} {" ",13} BUY {" ",12} {VerticalLine}  {" ",8}  STATE AFTER SORTING  {" ",8}  {VerticalLine} {" ",5}STATISTICS{" ",4} {VerticalLine}");
            for (int i = 0; i < 100; ++i)
            {
                if (i == 0) Console.Write(VerticalLeft);
                else if (i == 33 || i == 77) Console.Write(MiddleJoint);
                else if (i == 21 || i == 40 || i == 50 || i == 59 || i == 68 || i == 88) Console.Write(HorizontalTop);
                else if (i == 99) Console.WriteLine(VerticalRight);
                else Console.Write(HorizontalLine);
            }
            Console.WriteLine($"{VerticalLine}    PRODUCT NAME    {VerticalLine}   COUNT   {VerticalLine}  ALL {VerticalLine}  FRESH  {VerticalLine} NORMAL {VerticalLine} ROTTEN {VerticalLine}  TOXIC {VerticalLine}   SOLD   {VerticalLine}   TURF   {VerticalLine}");
            for (int i = 0; i < 100; ++i)
            {
                if (i == 0) Console.Write(VerticalLeft);
                else if (i == 21 || i == 33 || i == 40 || i == 50 || i == 59 || i == 68 || i == 77 || i == 88) Console.Write(MiddleJoint);
                else if (i == 99) Console.WriteLine(VerticalRight);
                else Console.Write(HorizontalLine);
            }
        }
        private static void Body()
        {
            for (int j = 0; j < 18; ++j)
            {
                if (j == 17)
                {
                    for (int i = 0; i < 100; ++i)
                    {
                        if (i == 0) Console.Write(LeftBottom);
                        else if (i == 21 || i == 33 || i == 40 || i == 50 || i == 59 || i == 68 || i == 77 || i == 88) Console.Write(HorizontalBottom);
                        else if (i == 99) Console.WriteLine(RightBottom);
                        else Console.Write(HorizontalLine);
                    }
                }
                else
                {
                    int count = 0;
                    int fresh = 0;
                    int normal = 0;
                    int rotten = 0;
                    int toxic = 0;
                    int sold = 0;
                    int turf = 0;
                    int buyyed = 0;

                    if (Data.Vegetables.ContainsKey((VegetableName)j) == true)
                    {
                        count = Data.Vegetables[(VegetableName)j].Count;
                        fresh = Data.VegetablesState[(VegetableName)j][0];
                        normal = Data.VegetablesState[(VegetableName)j][1];
                        rotten = Data.VegetablesState[(VegetableName)j][2];
                        toxic = Data.VegetablesState[(VegetableName)j][3];
                        sold = Data.VegetablesStats[(VegetableName)j][0];
                        turf = Data.VegetablesStats[(VegetableName)j][1];
                        buyyed = Data.VegetablesStats[(VegetableName)j][2];
                    }

                    Console.WriteLine($"{VerticalLine}{(VegetableName)j,-20}{VerticalLine}{"+" + buyyed,11}{VerticalLine}{count,6}{VerticalLine}{fresh,9}{VerticalLine}{normal,8}{VerticalLine}{rotten,8}{VerticalLine}{toxic,8}{VerticalLine}{sold,10}{VerticalLine}{turf,10}{VerticalLine}");
                    if (j != 16)
                    {
                        for (int i = 0; i < 100; ++i)
                        {
                            if (i == 0) Console.Write(VerticalLeft);
                            else if (i == 21 || i == 33 || i == 40 || i == 50 || i == 59 || i == 68 || i == 77 || i == 88) Console.Write(MiddleJoint);
                            else if (i == 99) Console.WriteLine(VerticalRight);
                            else Console.Write(HorizontalLine);
                        }
                    }
                }
            }
        }

        public static void UI()
        {
            Header();
            Subheader();
            Body();
        }

    }
}
