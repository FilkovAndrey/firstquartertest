// Написать программу, которая из имеющегося массива строк формирует 
//массив из строк, длина которых менше либо равна 3 символа. Первоначальный массив можно ввести
//с клавиатуры, либо задать на старте выполнения алгоритма.
void printArray(string[] arr) {
  for(int i = 0; i < arr.Length; i++) {
    if(i != arr.Length - 1) {
      Console.Write($"{arr[i]}, ");
    } else Console.Write($"{arr[i]}");
  }
}

string[] stringArrayCountThree(string[] arr) {
  int size = 0;
  string[] newArr = new string[size];
  for(int i = 0; i < arr.Length; i++) {
    if(arr[i].Length <= 3) {
      Array.Resize(ref newArr, newArr.Length + 1);
      newArr[size] = arr[i];
      size++;
    }
  }
  return newArr;
}

printArray(stringArrayCountThree(new string[] { "world", "253", "long", "48" }));