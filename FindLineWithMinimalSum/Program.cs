int FirstDimension = 4; // число строк
int SecondDimension = 4; // число столбцов
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 50;
int [,] Array = new int [FirstDimension,SecondDimension];


int MinimalSumLine = 1;
int MinSum = 0;

for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
                Array [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }

for (int j = 0; j < Array.GetLength (1); j ++)
    {
        MinSum = MinSum + Array[0,j];
    }

for (int i = 1; i < Array.GetLength (0); i ++)
    {    
        int CurrentSum = 0;
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
                CurrentSum = CurrentSum + Array [i,j];
            }
        if (CurrentSum < MinSum)
            {
                MinSum = CurrentSum;
                MinimalSumLine = i + 1; 
            }
    }

Console.WriteLine (MinimalSumLine);