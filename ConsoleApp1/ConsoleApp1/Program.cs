/*1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.*/

Console.Clear();
Console.WriteLine("-----------");
Console.WriteLine("Bienvenido!");
Console.WriteLine("-----------");

int n;
int adivinado = 0;
int i=0;
string linea;

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
Console.WriteLine(numeroSecreto.ToString());

do
{
    Console.WriteLine("Por favor ingresa un numero entre el 1 y el 20");
    Console.WriteLine("");
    linea = Console.ReadLine();

    n = int.Parse(linea);

    if (n == numeroSecreto)
    {
        
        adivinado++;
    }
    else if (n > numeroSecreto)
    {
        Console.WriteLine("El numero que ingresaste es mas grande");
        Console.WriteLine("");
    }
    else 
    {
        Console.WriteLine("El numero que ingreasate es mas chico");
        Console.WriteLine("");
    }
    i++;

}
while (adivinado == 0);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("-------------------------------------------------------- " );
Console.WriteLine("Felicitaciones, has adivinado el número secreto que era: " + numeroSecreto);
Console.WriteLine("-------------------------------------------------------- " );
Console.WriteLine("");
Console.WriteLine("Lo has adivinado en [ " + i + " ] intentos");