Console.WriteLine("Enter the number of rows in the array");
int number = Convert.ToInt32(Console.ReadLine());
StrArr strArr = new();
string[] strArr1 = strArr.FillArray(number);
strArr.PrintArray(strArr1);
Console.Write("->");
strArr.PrintArray(strArr.LengthStrArr(3,strArr1));