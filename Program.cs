//print array 
using DSA_C_;
int[] darray = { 3, 3, 45, 56, 3, 21, 4, 3 };
DArray arr = new DArray();
arr.PrintArray(darray);
//remove even 
Console.WriteLine("remove even ");

int[] result = arr.RemoveEven(darray);
arr.PrintArray(result);
Console.WriteLine("reverse array in c#");
//reverse

int[] a = { 2, 4, 6, 7, 89, 80, 4, 6, 3 };
DArray d=new DArray();
d.reverse_array(a, 0, a.Length - 1);
d.PrintArray(a);

int x=d.findminmum(a);

Console.WriteLine("the minmum value in the project is ");
Console.WriteLine(x);
Console.WriteLine("the second max");
int z=d.thesecondmax(a);
Console.WriteLine($"the second max is {z}");
Console.WriteLine("move zero in c# ");
int[] move = { 0, 0, 0, 1,0, 1, 1 };
d.movezeros(move);
d.PrintArray(move);
Console.WriteLine("resize array in c# ");
 int[] re=d.resize_array(move,20);
Console.WriteLine(re.Length);
Console.WriteLine("print two dimensional array ");
int[,,] two = {{ { 1, 2 }, { 4, 5 }, { 6, 7 } },{ { 11, 12 }, { 14, 15 }, {16, 17 } } };
d.three_dimensiona_print(two);
Console.WriteLine("two dimension array "+two.GetLength(0)); Console.WriteLine("two dimension array " + two.GetLength(1)); Console.WriteLine("two dimension array " + two.GetLength(2));