// See https://aka.ms/new-console-template for more information

//ex1
// int[] numbers = takeArrayInput();
//
// Console.WriteLine("Mang sap xep tang dan: ");
// Array.Sort(numbers);
// showResult(numbers);
//
// Console.WriteLine("\nMang sap xep giam dan: ");
// Array.Reverse(numbers);
// showResult(numbers);



//ex2
// int[] numbers = takeArrayInput();
//
// Console.WriteLine("Mang ban dau: ");
// showResult(numbers);
//
// int[] newNumbers = new int[numbers.Length];
// numbers.CopyTo(newNumbers, 0);
// Console.WriteLine("\nMang copied: ");
// showResult(newNumbers);
// Console.WriteLine("\nTong cac phan tu: " + newNumbers.Sum());




//ex3
// int[] numbers = takeArrayInput();
// Console.WriteLine("Mang ban dau: ");
// showResult(numbers);
//
// Console.WriteLine("Danh sach cac so trung nhau: ");
//
// Dictionary<int, List<int>> map = new Dictionary<int, List<int>>(); //value, indexs
// for (int i = 0; i < numbers.Length; i++) {
//     int key = numbers[i];
//     if (!map.ContainsKey(key)) {
//         map.Add(key, new List<int>());
//     }
//     map[key].Add(i);
// }
//
//
// foreach (var item in map) {
//     Console.Write("Value: " + item.Key + " -> Index: ");
//     foreach (int index in item.Value) {
//         Console.Write(index + " ");
//     }
//     
//     Console.WriteLine();
// }





//ex4
// int[] numbers = takeArrayInput();
//
// Dictionary<int, List<int>> map = new Dictionary<int, List<int>>(); //value, num
//
// for (int i = 0; i < numbers.Length; i++) {
//     if (!map.ContainsKey(numbers[i])) {
//         map.Add(numbers[i], new List<int>());
//     }
//     
//     map[numbers[i]].Add(i);
// }
//
// foreach (var item in map) {
//     Console.WriteLine("\nVi tri cac phan tu = " + item.Key);
//     foreach (int index in item.Value) {
//         Console.Write(index + " ");
//     }
//     
// }
//
// Console.WriteLine("\nGia tri max trong mang: " + map.Keys.Max(item => item));
// Console.WriteLine("Gia tri min trong mang: " + map.Keys.Min(item => item));




//ex5
// int[] numbers = takeArrayInput();
//
// List<int> list1 = new List<int>();
// List<int> list2 = new List<int>();
//
// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] % 2 == 0) {
//         list1.Add(numbers[i]);
//     } else {
//         list2.Add(numbers[i]);
//     }
// }
//
// int[] array1 = list1.ToArray();
// int[] array2 = list2.ToArray();
//
// Console.WriteLine("Mang ban dau: ");
// showResult(numbers);
// Console.WriteLine("\nMang so chan: ");
// showResult(array1);
// Console.WriteLine("\nMang so le: ");
// showResult(array2);



//ex6
int[] numbersOrigin = takeArrayInput();  //caching origin
int[] numbersImpl = new int[numbersOrigin.Length];
Array.Copy(numbersOrigin, numbersImpl, numbersOrigin.Length);
do {
    Console.WriteLine("\n1. Sap xep mang tang dan.");
    Console.WriteLine("2. Sap xep mang giam dan.");
    Console.WriteLine("3. Chen phan tu vao mang sau khi sap xep.");
    Console.WriteLine("4. Chen phan tu vao mang chua sap xep.");
    Console.WriteLine("5. Xoa phan tu trong mang.");
    Console.WriteLine("6. Tim phan tu lon thu hai trong mang.");
    Console.WriteLine("7. Tim phan tu nho thu hai trong mang.");
    Console.WriteLine("0. Reset mang ve ban dau.");
    Console.WriteLine("Nhap lua chon: ");
    int input = Convert.ToInt32(Console.ReadLine());

    switch (input) {
        case 0:
            Array.Copy(numbersOrigin, numbersImpl, numbersOrigin.Length);
            Console.WriteLine("Mang ban dau: ");
            showResult(numbersImpl);
            break;
        case 1:
            Console.WriteLine("Mang sau khi sap xep: ");
            Array.Sort(numbersImpl);
            showResult(numbersImpl);
            break;
        case 2: //ok
            Console.WriteLine("Mang sau khi sap xep: ");
            int[] arrayDesc = numbersImpl.OrderByDescending(element => element).ToArray();
            numbersImpl = arrayDesc;
            showResult(numbersImpl);
            break;
        case 3: //ok
            if (!isSorted(numbersImpl)) {
                Console.WriteLine("Vui long sap xep mang truoc...");
                break;
            }
            
            Console.WriteLine("Nhap vi tri can chen: ");
            int index1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia tri can chen: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            
            int[] arrayPlus1 = insertElement(index1, value1, numbersImpl);
            numbersImpl = arrayPlus1;
            
            Console.WriteLine("Mang sau khi chen: ");
            showResult(numbersImpl);
            break;
        case 4: //ok
            Console.WriteLine("Nhap vi tri can chen: ");
            int index2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia tri can chen: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            
            int[] arrayPlus2 = insertElement(index2, value2, numbersImpl);
            numbersImpl = arrayPlus2;
            
            Console.WriteLine("Mang sau khi chen: ");
            showResult(numbersImpl);
            break;
        case 5: //ok
            Console.WriteLine("Nhap vi tri can xoa: ");
            int index3 = Convert.ToInt32(Console.ReadLine());
            
            int[] arrayPlus3 = removeElement(index3, numbersImpl);
            numbersImpl = arrayPlus3;
            
            Console.WriteLine("Mang sau khi xoa 1 phan tu: ");
            showResult(numbersImpl);
            break;
        case 6:
            Array.Sort(numbersImpl);
            Console.WriteLine("Phan tu lon thu hai trong mang: " + numbersImpl[numbersImpl.Length - 2]);
            break;
        case 7:
            Array.Sort(numbersImpl);
            Console.WriteLine("Phan tu nho thu hai trong mang: " + numbersImpl[1]);
            break;
        default:
            Console.WriteLine("Phuong thuc khong hop le...");
            break;
    }
} while (true);


bool isSorted(int[] array) {
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < array.Length - 1; i++) {
        if (array[i] <= array[i + 1]) {
            count1++;
        } else {
            count2++;
        }
    }

    if (count1 < array.Length - 1 && count2 < array.Length - 1) {
        return false;
    }

    return true;
}

int[] insertElement(int index, int value, int[] array) {
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < index; i++) {
        newArray[i] = array[i];
    }

    newArray[index] = value;
    for (int i = index + 1; i < newArray.Length; i++) {
        newArray[i] = array[i - 1];
    }

    return newArray;
}

int[] removeElement(int index, int[] array) {
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < index; i++) {
        newArray[i] = array[i];
    }
    
    for (int i = index; i < newArray.Length; i++) {
        newArray[i] = array[i + 1];
    }

    return newArray;
}





//ex7
// Console.WriteLine("Nhap ma tran thu nhat...");
// int[,] matrix1 = takeMatrixInput();
// Console.WriteLine("Nhap ma tran thu hai...");
// int[,] matrix2 = takeMatrixInput();
//
// int row = matrix1.GetLength(0);
// int col = matrix1.GetLength(1);
//
// int[,] matrixSum = new int[row, col];
// int[,] matrixSub = new int[row, col];
// int[,] matrixMulti = new int[row, col];
//
//
// for (int i = 0; i < matrix1.GetLength(0); i++) {
//     for (int j = 0; j < matrix1.GetLength(1); j++) {  //maxtrix 1 or 2 -> ok
//         matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
//         matrixSub[i, j] = matrix1[i, j] - matrix2[i, j];
//         matrixMulti[i, j] = matrix1[i, j] * matrix2[i, j];
//     }
// }
//
// Console.WriteLine("Tong hai ma tran: ");
// showMatrixResult(matrixSum);
// Console.WriteLine("Hieu hai ma tran: ");
// showMatrixResult(matrixSub);
// Console.WriteLine("Tich hai ma tran: ");
// showMatrixResult(matrixMulti);
//
// Console.WriteLine("Tong cac hang cua ma tran: " + row);
// Console.WriteLine("Tong cac cot cua ma tran: " + col);
//
// var equal =
//     matrix1.Rank == matrix2.Rank &&
//     Enumerable.Range(0,matrix1.Rank).All(dimension => matrix1.GetLength(dimension) == matrix2.GetLength(dimension)) &&
//     matrix1.Cast<int>().SequenceEqual(matrix2.Cast<int>());
// if (!equal) {
//     Console.WriteLine("Hai ma tran khong bang nhau....");
// } else {
//     Console.WriteLine("Hai ma tran bang nhau...");
// }
//
//
//
//
// int[,] takeMatrixInput() {
//     Console.WriteLine("Nhap chieu rong: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Nhap chieu cao:");
//     int col = Convert.ToInt32(Console.ReadLine());
//
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < row; i++) {
//         for (int j = 0; j < col; j++) {
//             Console.WriteLine("Nhap vi tri: [" + (i + 1) + "," + (j + 1) + "]: ");
//             matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//
//     return matrix;
// }
//
//
// void showMatrixResult(int[,] matrix) {
//     for (int i = 0; i < matrix.GetLength(0); i++) {
//         for (int j = 0; j < matrix.GetLength(1); j++) {
//             Console.Write(matrix[i,j] + " ");
//         }
//
//         Console.WriteLine();
//     }
// }






int[] takeArrayInput() {
    Console.WriteLine("Nhap so phan tu cua mang: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
        Console.WriteLine("Nhap phan tu thu " + (i + 1) + ": ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
}

void showResult(int[] nums) {
    foreach (int item in nums) {
        Console.Write(item + ", ");
    }
}
