int FirstDimension = 4; // число строк
int SecondDimension = 4; // число столбцов
int lowerLimitOfRandom = 0;
int upperLimitOfRandom = 50;
int [,] Array = new int [FirstDimension,SecondDimension];
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
                Array [i,j] = new Random().Next(lowerLimitOfRandom,upperLimitOfRandom+1);
                Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }

//Вводим метод, который будет распределять элементы в строчках двумхмерного массива по возрастанию методом пузырька
void gradeNumbersInLine(int [,] argArray)                                   
    {
        for (int i = 0; i < argArray.GetLength (0); i ++)
            {   
                for (int elementsGraded = 0; elementsGraded +1 != argArray.GetLength (1); elementsGraded ++) //вводим переменную elementsGraded  для определения количества отсортированных элементов и сокращения количества действий в каждом проходе пузырькового алгоритма
                    {     
                        for (int j = 0; j < (argArray.GetLength (1) - elementsGraded - 1); j ++)
                            {
                                if (argArray [i,j] > argArray [i,j+1])
                                    {
                                        int Max = argArray [i,j];
                                        argArray [i,j] = argArray [i,j+1];
                                        argArray [i,j+1] = Max;
                                    }
                            }
                    }
            }
    }

Console.WriteLine ();

gradeNumbersInLine (Array);
for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
               Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }


