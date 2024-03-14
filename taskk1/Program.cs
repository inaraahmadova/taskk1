//int num = 82;
//int largestnum = 0;
//while (num != 0)
//{
//    int eded = num % 10;
//    if (eded > largestnum)
//    {
//        largestnum = eded;
//    }
//    num /= 10;
//}
//Console.WriteLine(largestnum);









//int num = 6;
//while (num > 1)
//{
//    if (num % 2 != 0)
//    {
//        Console.WriteLine("eded 2-nin quvveti deyil");
//        break;
//    }
//    num /= 2;
//    if (num == 1)
//    {
//        Console.WriteLine("eded 2-nin quvvetidir");
//        break;
//    }
//}







//int[] num = { 5, 8, 7, 11, 13, 9 };
//int max = num[0];
//int min = num[0];
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] < min)
//    {
//        min = num[i];
//    }
//    if (num[i] > max)
//    {
//        max = num[i];
//    }
//}
//sum = min + max;
//Console.WriteLine(sum);








//int[] arr = { 5, 9, 8, 3, 7, 4, 6 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0 && arr[i] % 3 == 0)
//    { count++; }
//}
//Console.WriteLine(count);







int[] arr = { 6, 8, 1, 5, 19, 33, 27 };
int count = 0;
for (int i = 1; i < arr.Length; i++)
{
    for (int j = 2; j < arr[i]; j++)
    {
        if (arr[i]%j==0)
        {
            count++;
            break;
        }
    }
}
Console.WriteLine(count);





