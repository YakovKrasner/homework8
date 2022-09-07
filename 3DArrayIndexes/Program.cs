int FirstDimension = 2;
int SecondDimension = 2;
int ThirdDimension = 2; 
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 9;
int [,,] Array = new int [FirstDimension,SecondDimension,ThirdDimension];


for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
                for (int k = 0; k < Array.GetLength (2); k ++)
                Array [i,j,k] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                
            }
        Console.WriteLine ();
    }

Console.WriteLine ();

for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
                for (int k = 0; k < Array.GetLength (2); k ++)
                Console.WriteLine ($"{Array[i,j,k]}({i},{j},{k})");              
            }
    }