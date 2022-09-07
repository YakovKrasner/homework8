int FirstDimension = 2; // число строк
int SecondDimension = 2; // число столбцов
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 9;
int [,] Array1 = new int [FirstDimension,SecondDimension];
int [,] Array2 = new int [FirstDimension,SecondDimension];
int [,] MatricesMultplication = new int [FirstDimension,SecondDimension];

for (int i = 0; i < Array1.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array1.GetLength (1); j ++)
            {
                Array1 [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array1[i,j]}");
            }
        Console.WriteLine ();
    }
Console.WriteLine ();

for (int i = 0; i < Array2.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array2.GetLength (1); j ++)
            {
                Array2 [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array2[i,j]}");
            }
        Console.WriteLine ();
    }
Console.WriteLine ();

for (int i = 0; i < MatricesMultplication.GetLength (0); i ++)
    {    
        for (int j = 0; j < MatricesMultplication.GetLength (1); j ++)
            {
                for (int i1 = 0; i1 < Array1.GetLength(0); i1 ++)
                MatricesMultplication [i,j] = MatricesMultplication [i,j] + (Array1 [i,i1])*(Array2 [i1,j]);
                Console.Write ($" {MatricesMultplication[i,j]}");
            }
        Console.WriteLine ();
    }