void Zadacha1()
{
     Console.WriteLine ("Введите пятизначное число");
     int number= Convert.ToInt32 (Console.ReadLine());
     int n1= number/10000;
     int n2= number/1000 % 10;
     int n4= number % 100 / 10;
     int n5= number % 10;
     if (n1 == n5)
     {  
        if ( n2 == n4)
        {
            Console.WriteLine ("это число Палиндром");
        }
     }   
     
     else
        {
            Console.WriteLine ("это число не Палиндром");
        }
     

   

}
//Zadacha1();



void Zadacha2 ()
{
    Random random = new Random ();
    int x1= random.Next (0, 100);
    int x2= random.Next (0, 100);
    int y1= random.Next (0, 100);
    int y2= random.Next (0, 100);
    int z1= random.Next (0, 100);
    int z2= random.Next (0, 100);

    Console.WriteLine ($"A {x1}, {y1}, {z1}");
    Console.WriteLine ($"B {x2}, {y2}, {z2}");
    Console.WriteLine ($"Расстояние между точками = {Dist (x1,y1,z1,x2,y2,z2)}");

    double Dist(int x1,int y1,int z1, int x2,int y2,int z2)
    {
       return Math.Sqrt (Math.Pow ((x2-x1),2) + Math.Pow ((y2-y1),2) + Math.Pow ((z2-z1),2));
    }
}
//Zadacha2();

void Zadacha3 ()
{
    Console.WriteLine ("Введите число");
    int N = Convert.ToInt32 (Console.ReadLine());
    int i = 1;
    double Sqw;
while (i<= N)
{
    Sqw = Math.Pow (i, 3);
    Console.WriteLine ($"|{i}|{Sqw}|");
    i++;
}
}
//Zadacha3();