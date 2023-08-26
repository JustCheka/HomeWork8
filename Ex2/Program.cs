Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m,n];

int maxStr = 0;
for (int i = 0; i < arr.GetLength(0); i++){
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(0,10);
        Console.Write(arr[i,j] + " ");
        sum += arr[i,j];
    }
    Console.WriteLine();
    if (i == 0) {
        maxStr = sum;
    }
    else {
        if (sum > maxStr){
            maxStr = sum;
        }
    }
}
Console.WriteLine();
Console.WriteLine(maxStr);