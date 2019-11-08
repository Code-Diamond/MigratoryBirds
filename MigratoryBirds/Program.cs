using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    private static List<int> counters = new List<int> { 0, 0, 0, 0, 0, 0 };
    
    static int migratoryBirds(List<int> arr)
    {
        //filter the array through a switch and counter how many of each instance there are
        for(int i = 0; i < arr.Count; i++)
        {
            switch (arr[i])
            {
                case 1:
                    counters[1]++;
                    break;
                case 2:
                    counters[2]++;
                    break;
                case 3:
                    counters[3]++;
                    break;
                case 4:
                    counters[4]++;
                    break;
                case 5:
                    counters[5]++;
                    break;
            }
            
        }

        //Find what the highest number of occurences is
        int highest = 0;
        for(int i = 0; i < counters.Count; i++)
        {
            if(counters[i] > highest)
            {
                highest = counters[i];
            }
        }


        //Find which instance of the array the highest number of occurences occurs fist (the lower of the type)
        int instance = 0;
        for(int i = 0; i < counters.Count; i++)
        {
            if(counters[i] == highest)
            {
                instance = i;
                break;
            }
        }

        //Console.WriteLine(instance);

        return instance;
    }

    static void Main(string[] args)
    {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        Console.WriteLine(result);

    }
}
