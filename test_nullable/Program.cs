// See https://aka.ms/new-console-template for more information

//declare
int? test_int = null;
string? test_str = null;
DateTime? test_dt = null;

Console.WriteLine("int?: " + test_int);
Console.WriteLine("string?: " + test_str);
Console.WriteLine("datetime?: " + test_dt);

//check
if (test_int.HasValue == true)
{
    Console.WriteLine("int? -> true");
}
else
{
    Console.WriteLine("int? -> false");
}

//set value
var res_int = test_int.GetValueOrDefault();
var res_str = test_str;
var resr_dt = test_dt.GetValueOrDefault();

Console.WriteLine(res_int);
Console.WriteLine(res_str);
Console.WriteLine(resr_dt);

Console.ReadKey();
