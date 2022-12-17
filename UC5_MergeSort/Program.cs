// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UC5_MergeSort;

MergeSorting merge = new MergeSorting();
int[] arrPass = { 55, 89, 214, 62, 150, 66, 99, 33, 11, 45 };
int len = Convert.ToInt32(arrPass.Length);
merge.MergeSort(arrPass, 0, len - 1);
for (int i = 0; i < arrPass.Length; i++)
{
    Console.Write(arrPass[i] + " ");
}

