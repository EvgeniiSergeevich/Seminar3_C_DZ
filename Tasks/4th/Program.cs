// Расстояние между 2х точек в N-мерном пространстве
try {
    Console.WriteLine("Введите размерность пространства: ");
    int dimention = Convert.ToInt32(Console.ReadLine());
    int[] dotA = new int[dimention];
    int[] dotB = new int[dimention];
    Console.WriteLine("Введите координаты первой точки: ");
    int i = 0;
    while(i < dotA.Length) {
        dotA[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    i = 0;
    Console.WriteLine("Введите координаты второой точки: ");
    while(i < dotB.Length) {
        dotB[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    Console.WriteLine(distanceAB(dotA, dotB));

} catch {
    Console.WriteLine("Введи число!!1");
}

double distanceAB(int[] dotA, int[] dotB) {
    double dist = 0;
    int sum = 0;
    for(int i = 0; i < dotA.Length; i++) {
        sum  += (dotB[i] - dotA[i]) * (dotB[i] - dotA[i]);
    }
    dist = Math.Round(Math.Sqrt(sum), 2);
    return dist;
}
