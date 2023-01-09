// See https://aka.ms/new-console-template for more information


#region  PARAMETERS
using System.Text;

string? fillWay;

#endregion


Console.WriteLine("Hello, Dear User");
Console.WriteLine("Pls choose the way of filling Aray");
Console.WriteLine("Auto - A ");
Console.WriteLine("Manual - M");

do {
 fillWay = Console.ReadLine()?.ToUpper();
    if(fillWay != "A" && fillWay != "M")
        Console.WriteLine("Pls use A or M");
}
while (fillWay != "A" && fillWay != "M"); // should be choose right method


if (fillWay == "A")
{
    Console.WriteLine("You have choosen - Auto method ");
    var array = AutoMethod();

    ShowResult(array);
}
else
{
    Console.WriteLine("You have choosen - Manual method ");
    var array = ManualMethod();
    ShowResult(array);
}


fillWay = Console.ReadLine();


string[] AutoMethod()
{
   var autoArray = new string[] { "НАСОС", "ПУЛЬТ", "УПРАВЛЕНИЯ", "ЩИТ", "УПРАВЛЕНИЯ", "КЛАПАН", "ШЛЮЗ", "БАК", "УСТАНОВКА", "УПРАВЛЕНИЯ", "ДРЕЛЬ", "АККУМУЛЯТОР", "ЩЕТКИ", "КИСТИ", "ГЕНЕРАТОР", "ФИЛЬТРА", "ПРОФИЛЬ", "УГОЛ", "ФЛАНЦА", "БОЛТ", "НАСОСЫ" };
   string[] resultArray = new string[0];
    foreach (var item in autoArray)
        if (item.Length<=3)
            resultArray = AddItemToArray(resultArray, item);

    return resultArray;
}
string[] ManualMethod()
{
    string[] resultArray = new string[0];
    string[] tempArray = new string[0];
    int arrayLength = 0;
    Console.WriteLine("Pls setup array length, it should be NUM (1,2,3... 99999");
    do 
    {
        var arrayLengthStr = Console.ReadLine();
        int.TryParse(arrayLengthStr, out arrayLength);
        if (arrayLength < 1)
            Console.WriteLine("Input data is not Number or not more than 0");

    } while(arrayLength < 1);

    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Pls spell data for Array item {i+1}");
        var arrayStr = Console.ReadLine();
        tempArray = AddItemToArray(tempArray, arrayStr);

    }

    foreach (var item in tempArray)
        if (item.Length <= 3)
            resultArray = AddItemToArray(resultArray, item);

    return resultArray;

}
string[] AddItemToArray(string[] array, string str)
{ 
    var tempArray = new string[array.Length+1];
    array.CopyTo(tempArray,0);

    tempArray[array.Length] = str;

    return tempArray;
}
void ShowResult(string[] array)
{
    Console.WriteLine();
    Console.WriteLine($"we have found {array.Length} item(s) at Array with Length 3 digits or less");

    var str = new StringBuilder();

    str.Append("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i!= array.Length-1)
            str.Append($"{array[i]},");
        else
            str.Append($"{array[i]}");
    }

    str.Append("]");

    Console.WriteLine(str.ToString());
}