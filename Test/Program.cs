 string a = "4";
Console.WriteLine(a.Length);

 string[] s = a.Split(',');
 Console.WriteLine(s.Length);
//  int i = Convert.ToInt32(s[1]) - Convert.ToInt32(s[0]) + 1;
//  Console.WriteLine(i); 

//  if (a.Length > 2)
//     {
//         string[] s = a.Split('-');
//         int i = Convert.ToInt32(s[1]) - Convert.ToInt32(s[0]) + 1;
//         int[] result = new int[i];
//         for (int j = 0; j < result.Length; j++)
//         {
//             result[j] = Convert.ToInt32(s[0]) + j;
//         }
//        Console.WriteLine(string.Join(' ', result));
// //     }
//     else
//     {
//         int[] array = new int[1];
//         array[0] = Convert.ToInt32(a);
        
//     }
//     Console.WriteLine(string.Join(' ', result));