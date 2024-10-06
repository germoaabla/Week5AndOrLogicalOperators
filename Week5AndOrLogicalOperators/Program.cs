//AND (&&) and OR (||) logical operators

//AND
//true && true => true
//true && fakse => false
//false && true => false
//false && false => false

string username, password; //username: admind //password: admin1234

Console.WriteLine("Enter username:");
username = Console.ReadLine();

Console.WriteLine("Enter password:");
password = Console.ReadLine();

//OR
//true || true => true
//true || fakse => true
//false || true => true
//false || false => false

if (username != "admin" || password != "admin1234") //=! => NOT
{
    Console.WriteLine("Invalid credentials!");
}
else
{
    Console.WriteLine("Welcome");
}

//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome!");
//}
//else
//{
//    Console.WriteLine("Invalid credentials!");
//}


