var arr = Array.CreateInstance(typeof(int), 4);

arr.SetValue(5, 0);
arr.SetValue(4, 1);
arr.SetValue(1, 2);
arr.SetValue(2, 3);

// 0:5 , 1:4 , 2:1 , 3:2     (x inci göz : y elemanı)

// Console.WriteLine(arr.GetValue(0));
//try
//{
//    Console.WriteLine(arr.GetValue(5)); // ==> OutOfRange hatası verir
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

var terstenyazdır = new DataStructures.Array.Array(1,3,5,7,9);

foreach (var item in terstenyazdır)
{
    Console.WriteLine(item);
}

Console.ReadKey();
