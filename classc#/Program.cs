
using classc_.models;
using System.Text;
#region task1


//string input = Console.ReadLine();
//Console.WriteLine(Reverse(input));
//StringBuilder Reverse(string input)
//{
//    StringBuilder result = new();
//    for (int i = input.Length - 1; i >= 0; i--)
//    {
//        result.Append(input[i]);
//    }

//    return result;
//}
#endregion
#region task2
Console.Write("Username:");
string username = Console.ReadLine();
Console.Write("Password:");
string password = Console.ReadLine();
Account input2 = new(username, password);
input2.Condition();
#endregion