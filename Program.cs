// Console.WriteLine("Hello, World!");


// string name="Murad";
// int age=15;
// long number=111111111111111;
// ulong number2=1111111111111111;
// double weight=85.3;
// float tall=16.7F;
// char classNumber='x';
// bool isStudent=true;



// if (age>18)
// {
//     Console.WriteLine("Sen boyumusen");

// }
// else if (age==0)
// {
// Console.WriteLine("Usaqsan");
// }
// else {
//     Console.WriteLine("Hele boyumemisen");
// }


// if (name=="Murad") {
//     Console.WriteLine("Salam Murad necesen?");

// }



// Console.WriteLine("Hello, World!");


// Console.Write("Adinizi daxil edin;");
// var userInput=Console.ReadLine();
// Console.WriteLine(userInput+" Xos gelmisiniz!");

// string email="ehmed@compar.edu.az";
// string password="12345678";


// Console.Write("Write email: ");

// var emailInput =Console.ReadLine();

// Console.Write("Write password:");
// var passwordInput=Console.ReadLine();

// if (email==emailInput&&password==passwordInput){
//     Console.WriteLine("Xos geldin Ehmed");
// }
// else {
//     Console.WriteLine("Email ve ya sifre yalnisdir");
// }


// int number1=10+4;

// Console.WriteLine(5+5);
// Console.WriteLine(5-2);
// Console.WriteLine(5*2);
// Console.WriteLine(10/2);
// Console.WriteLine(10%2);
// Console.WriteLine(10%4);
// Console.WriteLine(number1);

Console.Write("Balinizi daxil edin");

int studentResult=Convert.ToInt32(Console.ReadLine());

if (studentResult>0 && studentResult<=50){
    Console.WriteLine("F");
}
else if (studentResult>=51 && studentResult<=60) {
    Console.WriteLine("E");
}
else if (studentResult>=61 && studentResult<=70) {
    Console.WriteLine("D");
}
else if (studentResult>=71 && studentResult<=80) {
    Console.WriteLine("C");
}
else if (studentResult>=81 && studentResult<=90) {
    Console.WriteLine("B");
}
else if (studentResult>=91 && studentResult<=100) {
    Console.WriteLine("A");
}

else {
    Console.WriteLine("Yeniden sehd edin");
}
