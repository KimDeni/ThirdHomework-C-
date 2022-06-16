void leanght(int ax, int ay, int az, int bx, int by, int bz){

    double leanght = ((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay)) + ((bz - az) * (bz - az));

    Console.Write($"Расстояние между точками A и B: ");
    Console.Write( Math.Sqrt(leanght));
}
Console.WriteLine("Введите x, y, z координаты точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x, y, z координаты точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());



leanght(xa, ya, za, xb, yb ,zb);