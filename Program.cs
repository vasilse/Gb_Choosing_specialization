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


if (fillWay != "A")
{
    Console.WriteLine("You have choosen - Auto method ");
}
else
{
    Console.WriteLine("You have choosen - Manual method ");

}


fillWay = Console.ReadLine();


void AutoMethod()
{
   var autoArray = new string[] { "НАСОС", "ПУЛЬТ", "УПРАВЛЕНИЯ", "ЩИТ", "УПРАВЛЕНИЯ", "КЛАПАН", "ШЛЮЗ", "БАК", "УСТАНОВКА", "УПРАВЛЕНИЯ", "ДРЕЛЬ", "АККУМУЛЯТОР", "ЩЕТКИ", "КИСТИ", "ГЕНЕРАТОР", "ФИЛЬТРА", "ПРОФИЛЬ", "УГОЛ", "ФЛАНЦА", "БОЛТ", "НАСОСЫ" };
   string[] resultArray = new string[0];
    foreach (var item in autoArray)
        if (item.Length<=3)
            resultArray = AddItemToArray(resultArray, item);




}
void ManualMethod()
{
    
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