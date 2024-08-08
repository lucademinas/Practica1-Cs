string mensaje(string nombre, string ciudad)
{
    return $"Hola {nombre} bienvenido a {ciudad}";
}

string mostrar = mensaje("Luca", "Rosario");
Console.WriteLine(mostrar);