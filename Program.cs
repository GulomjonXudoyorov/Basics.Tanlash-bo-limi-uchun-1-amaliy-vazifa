//1st task

// string str = "teLefOn";
// Console.Write("Son kiriting: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > str.Length){
//     string original = str;
//     string uppercase = original.ToUpper();
//     Console.WriteLine(uppercase);
// }
// else {
//     string original = str;
//     string lowercase = original.ToLower();
//     Console.WriteLine(lowercase);
// }


// 2nd task

// int x = 8;
// int y = 10;

// if( x > y ){
//     Console.WriteLine("X is greater than Y");
// }
// else if (x < y){
//     Console.WriteLine("X is less than Y");
// }
// else if (x == y){
//     Console.WriteLine(" X is equal to Y");
// }
// else {
//     Console.WriteLine(" X and Y are not comparable");
// }

// 3rd task

Console.Write("Hafta kunini kiriting: ");
string dayOftheWeek = Console.ReadLine();

string result = dayOftheWeek switch 
{
    "Dushanba" => "Monday",
    "Seshanba" => "Tuesday",
    "Chorshanba" => "Wednesday",
    "Payshanba" => "Thursday",
    "Juma" => "Friday",
    "Shanba" => "Saturday",
    "Yakshanba" => "Sunday",
    _ => "Bunday hafta kuni yo'q",
};

Console.WriteLine(result);