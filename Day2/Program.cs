using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var noun = 0;
            var verb = 0;
            int[] result = new int[input.Length];

            while (noun < 100)
            {
                verb = 0;
                while (verb < 100)
                {
                    result = (int[])input.Clone();

                    result[1] = noun;
                    result[2] = verb;

                    var commandIndex = 0;
                    var run = true;
                    while (run)
                    {
                        switch (result[commandIndex])
                        {
                            case 1:
                                result[result[commandIndex + 3]] = result[result[commandIndex + 1]] + result[result[commandIndex + 2]];
                                break;
                            case 2:
                                result[result[commandIndex + 3]] = result[result[commandIndex + 1]] * result[result[commandIndex + 2]]; ;
                                break;
                        }
                        if (result[commandIndex] != 99)
                            commandIndex += 4;
                        else
                        {
                            run = false;
                            //break;
                        }
                    }
                    if (result[0] == 19690720) 
                    break;
                    verb++;
                }
                if (result[0] == 19690720) 
                break;
                noun++;
            }

            Console.WriteLine(string.Join(", ", result));
        }

        private static int[] input = new int[] { 1, 12, 2, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 9, 19, 1, 19, 5, 23, 2, 6, 23, 27, 1, 6, 27, 31, 2, 31, 9, 35, 1, 35, 6, 39, 1, 10, 39, 43, 2, 9, 43, 47, 1, 5, 47, 51, 2, 51, 6, 55, 1, 5, 55, 59, 2, 13, 59, 63, 1, 63, 5, 67, 2, 67, 13, 71, 1, 71, 9, 75, 1, 75, 6, 79, 2, 79, 6, 83, 1, 83, 5, 87, 2, 87, 9, 91, 2, 9, 91, 95, 1, 5, 95, 99, 2, 99, 13, 103, 1, 103, 5, 107, 1, 2, 107, 111, 1, 111, 5, 0, 99, 2, 14, 0, 0 };
    }
}
