string[] array1 = new string[5] { "Hello", "Vas", "YaBogat", "din", "Lavr"};
string[] array2 = new string[array1.Length];

void Massiv2 (string[] array1, string[] array2 )
{
    int count = 0;
    for( int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
        System.Console.WriteLine($"{array2}");
    }
}

void PrintArray(string[] array)
{
   for ( int i = 0; i < array1.Length; i++)
   {
        System.Console.WriteLine($"{array[i]} ");
   }
   System.Console.WriteLine();
}

Massiv2 (array1,array2 );
PrintArray(array2);






