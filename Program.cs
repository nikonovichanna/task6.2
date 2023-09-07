
const int Coefficient = 0;
const int Const = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;  


double[] lineData1 = InputLineDate(line1);
double[] lineData2 = InputLineDate(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений {coord[x_coord]}, {coord[y_coord]}");
}
 
double Promt (string message)
{
    System.Console.WriteLine(message);
    string value = System.Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineDate(int namberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = Promt($"Введите коэффициент для прямой {namberOfLine}");
    lineData[Const] = Promt($"Введите константу для прямой{namberOfLine}");
    return lineData;
} 

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[Const] - lineData2[Const]) /
     (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[y_coord] = lineData1[Const] * coord[x_coord] + lineData1[Const];
    return coord; 
} 


bool ValidateLines(double[] lineData1, double[] lineDate2)
{
    if (lineData1[Coefficient] == lineData2[Coefficient])
    {
        if (lineData1[Const] == lineData2[Const])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}