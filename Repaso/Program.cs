string miVariable;
miVariable = "Jose";
string materia = "Estructura de Datos";
//miVariable = string.Format("Hello: {0} {1}", miVariable, materia);

miVariable = $"Hello: {miVariable} {materia}" + 3;
int x = 5;

Console.WriteLine(miVariable);
