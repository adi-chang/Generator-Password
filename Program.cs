/// sample project 
/// Password Generator 
/// using helper library from : https://www.nuget.org/packages/PasswordGenerator/

using PasswordGenerator;

// var pwd = new Password();

IPassword? pwd = 
   new Password(8) // default, it will generate 16 karakter 
   .IncludeUppercase()
   .IncludeLowercase()
   .IncludeNumeric()
   .IncludeSpecial();

Enumerable.Range(1, 10).ToList().ForEach(i => {
   var password = pwd.Next();
   Console.WriteLine($"{i, 2}. Password Generated = {password}");
});
