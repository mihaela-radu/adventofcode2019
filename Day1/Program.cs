﻿using System;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelForModules = GetTotalFuel();
            int fuelForFuel = fuelForModules;
            var totalFuel = fuelForModules;
            do
            {
                fuelForFuel = GetFuel(fuelForFuel);
                if (fuelForFuel > 0) totalFuel += fuelForFuel;
            }
            while (fuelForFuel > 0);
            Console.WriteLine("Total fuel: " + totalFuel);
        }

        public static int CalculateFuel(int mass)
        {
            var fuel = mass / 3 - 2;
            return (fuel <= 0) ? 0 : fuel + CalculateFuel(fuel);
        }

        private static int GetTotalFuel()
        {
            int totalFuel = 0;
            foreach (var mass in moduleMasses)
            {
                totalFuel += GetFuel(mass);
            }
            return totalFuel;
        }
        private static int GetFuel(decimal mass)
        {
            return (int)Math.Floor(mass / 3) - 2;
        }

        private static int[] moduleMasses = new int[]
        {
            102777,
            107296,
            131207,
            116508,
            99009,
            120098,
            83121,
            87846,
            126604,
            79906,
            63668,
            143932,
            51829,
            106383,
            121354,
            138556,
            123426,
            111544,
            84395,
            147066,
            61897,
            133724,
            75867,
            106697,
            67782,
            86191,
            50666,
            138928,
            118740,
            136863,
            123108,
            85168,
            138487,
            115656,
            104811,
            114986,
            147241,
            73860,
            99186,
            134657,
            98379,
            59914,
            144863,
            119851,
            82549,
            93564,
            79437,
            70761,
            134303,
            108109,
            116208,
            80702,
            111018,
            131996,
            119367,
            74305,
            65905,
            116871,
            102184,
            101880,
            100453,
            111281,
            103134,
            129529,
            133885,
            76153,
            56890,
            86262,
            52804,
            139907,
            131360,
            80009,
            121015,
            74438,
            54470,
            73386,
            112961,
            116283,
            81353,
            80610,
            142522,
            64946,
            125652,
            61688,
            58367,
            118930,
            89711,
            115239,
            66403,
            92405,
            114593,
            112818,
            75964,
            126093,
            139781,
            144801,
            88725,
            125958,
            116869,
            119676
        };
    }
}
