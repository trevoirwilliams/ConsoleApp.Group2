// Print to screen
Console.WriteLine("Hello, World!");

// Added for GitHub Demo - Added by Alter Ego

// Input and variables
string fname = string.Empty;
string lname = "";
int age = 0;
char gender = ' ';
bool employed = false;
decimal salary = 0;
long pay;
decimal tax;

// $name = ''
// $name = 5
// string name = 5

DateTime dob;
DateOnly employedDate;
TimeOnly WakingTime;

Console.WriteLine("Enter your name: ");
fname = Console.ReadLine();
Console.WriteLine(fname);

Console.Write("Enter Age: ");
age = Convert.ToInt32(Console.ReadLine());
age = int.Parse(Console.ReadLine());

Console.WriteLine(age);

// +, -, / , *, 
// < > <= >= == 

// Sequence, Condition, Repition
// if, switch, while, do..while, for

if(age > 1)
{

}else if(age < 10)
{

}
else
{

}

switch (salary)
{
    case 100:
        Console.WriteLine("");
        break;
    default:
        break;
}

//while(employed == true)
while(employed)
{

}

do
{

} while (employed == true);

for (int i = 0; i < 12; i++)
{

}

// Collections
// Arrays 

int[] grades = new int[20];
int[] ages = { 10, 10, 25, 30, 46, 89, 85 };

var t = ages[5];

// List, IEnumerable, IQueryable, IObservableCollection, 

var students = new List<string>();
students.Add("Recordo");

students.Remove("Recordo");
var stuname = students[0];

foreach (var item in students)
{

}
