/*
 * Welcome to Grand Circus’ Room Detail Generator!

Enter Length: {user input here, for example: 24.5}
Enter Width: {user input here, for example: 20}
Area: {calculated: 490}
Perimeter: {calculated: 89 }
{calculated: This is a medium-sized room.}

Thank you for using the Room Detail Generator!


1 Point The application prompts the user to enter values of length and width of the classroom.
2 Points: The application displays the area and perimeter of that classroom.
2 Points: The application classifies the room as small (up to and including 250 square feet),
medium (more than 250 but less than 650 square feet), or large (650 square feet or more).

Formulas
P = 2 * (l+w)
A = l*w

H = A / width
Volume = lwh
A=2(wl+hl+hw)
 */


Console.WriteLine("Welcome to the Room Detail Caluclator");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}, Please enter the length of your room");
double length = double.Parse( Console.ReadLine() );
Console.WriteLine("Enter the width of your room");
double width = double.Parse( Console.ReadLine() );
Console.WriteLine("Enter the height of your room");
double height = double.Parse(Console.ReadLine());





double area = length * width;
double perimeter = (length + width) * 2;



double volume = length * width * height;
double s_area = 2 * ((width * length) + (height * length) + (height * width)) ;





string classify;

if (area <= 250)
{
    classify = "small";
}
else if (area > 250 &&  area < 650)
{
    classify = "medium";
}
else
{
    classify = "large";
}





Console.WriteLine($"The area is: {area}");
Console.WriteLine($"The perimeter is {perimeter}");
Console.WriteLine($"The surface area is: {s_area}");
Console.WriteLine($"The volume is {volume}");
Console.WriteLine($"{name}, Your room is considered: {classify}");


