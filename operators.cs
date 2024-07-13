//assignment
//arithmetic

static void Main(string[] args)
{
    Calculation(10,2);
}
public static void Calculation(int a , int b)
{
    var result = a+b;
    Console.WriteLine($"Addition : {result}");
    result = a-b;
    Console.WriteLine($"Substraction : {result}");
    result = a*b;
    Console.WriteLine($"Multiplication : {result}");
    result = a/b;
    Console.WriteLine($"Division : {result}");
}

//relational
static void Main(string[] args)
{
    int a = 10;
    int b = 20;
    bool result = a < b;
    bool result = a > b;
    Console.WriteLine(result);
}

//logical
static void Main(string[] args)
{
    int a = 10;
    
    Console.WriteLine(+a);
    Console.WriteLine(-a);
    Console.WriteLine(a++);
    Console.WriteLine(a);
    Console.WriteLine(++a);
    Console.WriteLine(--a);
    
}

//unary
int a = 10;
int b = 20;
string result = a<b ? "A Less Than B" : "A Greater than B"
Console.WriteLine(result);  