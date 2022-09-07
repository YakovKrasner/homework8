int FirstDimension = 4; // число строк
int SecondDimension = 4; // число столбцов
int [,] Array = new int [FirstDimension,SecondDimension];
int step = 1;

goRight (Array,0,0);

void goRight (int [,] ArgArray, int line, int column)
    {
        if (step < Array.Length) 
        {
            if (column == (ArgArray.GetLength(1) -1)) goDown (ArgArray, line, column);
            else
            {
                if (ArgArray [line,column + 1]==0) 
                    {
                        ArgArray [line,column] = step;
                        step = step + 1;
                        column = column + 1;
                        goRight (ArgArray, line, column);
                    }
                else goDown (ArgArray, line, column);
            }
        }
        else ArgArray [line,column] = ArgArray.Length;
    }

void goDown (int [,] ArgArray, int line, int column)
    {
        if (step < Array.Length) 
        {
            if (line == (ArgArray.GetLength(0) -1)) goLeft (ArgArray, line, column);
            else
            {
                if (ArgArray [line + 1,column]==0) 
                    {
                        ArgArray [line,column] = step;
                        step = step + 1;
                        line = line +1;
                        goDown (ArgArray, line, column);
                    }
                else goLeft (ArgArray, line, column);
            }
        }
        else ArgArray [line,column] = ArgArray.Length;
    }

void goLeft (int [,] ArgArray, int line, int column)
    {
        if (step < Array.Length) 
        {
            if (column == 0) goUp (ArgArray, line, column);
            else
            {
                if (ArgArray [line,column-1]==0) 
                    {
                        ArgArray [line,column] = step;
                        step = step + 1;
                        column = column - 1;
                        goLeft (ArgArray, line, column);
                    }
                else goUp (ArgArray, line, column);
            }
        }
        else ArgArray [line,column] = ArgArray.Length;
    }

void goUp (int [,] ArgArray, int line, int column)
    {
        if (step < Array.Length) 
        {
            if (line == 0) goRight (ArgArray, line, column);
            else
            {
                if (ArgArray [line-1,column]==0) 
                    {
                        ArgArray [line,column] = step;
                        step = step + 1;
                        line = line - 1;
                        goUp (ArgArray, line, column);
                    }
                else goRight (ArgArray, line, column);
            }
        }
        else ArgArray [line,column] = ArgArray.Length;
    }

    for (int i = 0; i < Array.GetLength (0); i ++)
    {    
        for (int j = 0; j < Array.GetLength (1); j ++)
            {
              Console.Write ($" {Array[i,j]}");
            }
        Console.WriteLine ();
    }