// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
void FindStep (int a, int b)
 {
    int resalt = 1;
    for (int i = 0; i < b; i++)
    {
        resalt *= a;
    }
     Console.WriteLine (resalt);
 }
 FindStep(3,5);