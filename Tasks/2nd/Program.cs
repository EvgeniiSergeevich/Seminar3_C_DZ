// Расстояние между точек в 3D пространстве
try {
    Console.WriteLine("Enter point A coordinates");
    int xa = Convert.ToInt32(Console.ReadLine());
    int ya = Convert.ToInt32(Console.ReadLine());
    int za = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter point B coordinates");
    int xb = Convert.ToInt32(Console.ReadLine());
    int yb = Convert.ToInt32(Console.ReadLine());
    int zb = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Distance between points A & B = " + distanceAB(xa, ya, za, xb, yb, zb));

} catch {
    Console.WriteLine("Enter inteher numbers!");
}

double distanceAB(int xa, int ya, int za, int xb, int yb, int zb) {
    double dist = Math.Round(Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za)), 2);
    return dist;
}