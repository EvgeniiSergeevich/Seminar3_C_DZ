// Является ли число палиндромом
try {
    Console.WriteLine("Enter the integer number: ");
    string? num = Console.ReadLine();
    Console.WriteLine(checkPalindrom(num));
} catch {
    Console.WriteLine("Try again!");
}

String checkPalindrom(string num) {
    // string num = number.ToString();
    string result = "";
    for(int i = 0; i < num.Length / 2; i++) {
        if(num[i] == num[num.Length - 1 - i]) {
            result = $"The number {num} is palindrome!";
        } else {
            result = $"The number {num} is NOT palindrome!";
        }
    }

    return result;
}
