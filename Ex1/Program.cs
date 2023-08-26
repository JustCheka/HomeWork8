void PrintArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(0); j++){
            for (int k = 0; k < arr.GetLength(1) - 1; k++){
                if (arr[j,k] < arr[j,k + 1]){
                    int temp = arr[j,k];
                    arr[j,k] = arr[j,k + 1];
                    arr[j,k + 1] = temp;
                }           
            }
        }
    }
}

Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m,n];

for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = new Random().Next(0,10);
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

ChangeArr(arr);
PrintArr(arr);