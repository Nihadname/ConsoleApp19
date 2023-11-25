// See https://aka.ms/new-console-template for more information
using ConsoleApp19.Helpers;
using ConsoleApp19.Models;

Console.WriteLine("Hello, World!");
int num = 5;
Console.WriteLine(num.Calculator());
string word = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";
string Email = "nihad123@gmail.com";
string PhonePattern = "\\(?\\d{3}\\)?[. -]? *\\d{3}[. -]? *[. -]?\\d{4}";
string PhoneNumber = "(281)388-0388";
Console.WriteLine(Email.EmailChecking(word));
Console.WriteLine(PhoneNumber.PhoneNumberChecking(PhonePattern));