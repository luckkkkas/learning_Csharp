

using Dictionary.Extensions;
using System.Reflection.Metadata;

//Dictionary<String, String> cookies = new Dictionary<string, string>();

////cookies.Add();
//cookies["User"] = "Lucas";
//cookies["email"] = "lucashbo321@gmail.com";
//cookies["phone"] = "988213446";
//cookies["phone"] = "98821";

//Console.WriteLine(cookies["email"]);
////cookies.Remove("email");

//foreach (KeyValuePair<string, string> item in cookies) {
//    Console.WriteLine($"{item.Key}: {item.Value}");
//}

DateTime dt = new DateTime(2025, 02, 27, 19, 48, 45);
Console.WriteLine(dt.ElapsedTime());

string s1 = "Bom Dia, Queridos estudantes!";
Console.Write(s1.Cut(10));