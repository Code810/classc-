
using classc_.models;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
#region task1

Console.WriteLine("Ters cevrilecek metni daxil edin:");
string input = Console.ReadLine();
Console.WriteLine(Reverse(input));
StringBuilder Reverse(string input)
{
    StringBuilder result = new();
    for (int i = input.Length - 1; i >= 0; i--)
    {
        result.Append(input[i]);
    }

    return result;
}
#endregion
#region task2
Console.WriteLine("Giris ucun melumatlari daxil edin:");
Console.Write("Username:");
string username = Console.ReadLine();
Console.Write("Password:");
string password = Console.ReadLine();
Account input2 = new(username, password);
input2.Condition();
#endregion
#region task3
Console.WriteLine("Faktoru hesablanacaq reqemi daxil edin:");
int num = int.Parse(Console.ReadLine());
Factorial input3 = new(num);
input3.Factor();
#endregion
#region task4
Console.WriteLine("Caculate");
Console.Write("reqemi daxil edin:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("prossesi daxil edin (+,-,*,/):");
string prosses = Console.ReadLine();
Console.Write("reqemi daxil edin:");
int num2 = int.Parse(Console.ReadLine());
Caculate test1 = new(num1, num2, prosses);
test1.StartProsses();
#endregion

