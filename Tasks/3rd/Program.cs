// Таблица кубов чисел
try {
    Console.WriteLine("Enter an integer number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(coube(x));
} catch {
    Console.WriteLine("Enter a number!");
}

string coube(int x) {
    string coubeX = "";
    for (int i = 1; i <= x; i++) {
        coubeX += i*i*i + ", ";
    }
    return coubeX;
}