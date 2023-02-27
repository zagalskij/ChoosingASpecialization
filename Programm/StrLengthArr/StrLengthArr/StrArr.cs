using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class StrArr
    {
    public string[] FillArray(int number)
    {
        string[] strArr= new string[number];
        for (int i = 0; i < number; i++)
        {
            strArr[i] = Console.ReadLine();
        }
        return strArr;
    }
    public string[] LengthStrArr(int number, string[] array)
    {
        string[] strArrLength = new string[0];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= number)
            {
     
                    Array.Resize(ref strArrLength, count + 1);
                    strArrLength[count] = array[i];
                    count++;
                
            }
        }
        return strArrLength;
    }
    public void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\""+array[i]+"\",");
            }

        Console.Write("\b]");
    }
}
