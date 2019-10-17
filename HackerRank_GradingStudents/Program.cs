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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> roundedGradesList = new List<int>();

        foreach (var grade in grades)
        {
            // If value Less than  38 -> no round will happen
            if (grade < 38)
            {
                roundedGradesList.Add(grade);
            }
            else
            {
                // Chack difference between grade and new mutiple of 5 
                if ((grade + 2) % 5 == 0)
                {
                    roundedGradesList.Add(grade + 2);
                }
                else if ((grade + 1) % 5 == 0)
                {
                    roundedGradesList.Add(grade + 1);
                }
                else
                {
                    roundedGradesList.Add(grade);
                }
            }

        }

        // Return the list
        return roundedGradesList;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
        Console.ReadKey();


    }
}
