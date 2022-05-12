// Escribir un programa que haga lo siguiente:
/*1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".*/



Console.Clear();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Bienvenidx! Por favor, ingrese su nombre: ");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");


String nombre = Console.ReadLine();
Console.WriteLine("----------------------");
Console.WriteLine("¡Hola "+  nombre +"!");
Console.WriteLine("----------------------");
Console.WriteLine("");

Console.WriteLine("Desea continuar? S/N");
 
var respuesta = "S";
respuesta = Console.ReadLine(); 

while(respuesta.ToUpper() == "S"){


    Console.Clear();
 
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Bienvenidx! Por favor, ingrese su nombre: ");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("");

    String nombreNuevo = Console.ReadLine();

    Console.WriteLine("¡Hola "+  nombreNuevo +"!");
    Console.WriteLine("----------------------");
    Console.WriteLine("");

    Console.WriteLine("Desea continuar? S/N");
    Console.WriteLine("");
    respuesta = Console.ReadLine(); 
}

 if(respuesta.ToLower() == "n"){
    Console.WriteLine("Programa finalizado correctamente! Saludos " + nombre + "!");
}else {
    Console.WriteLine("Asegurese de ingresar un comando válido! :) ");
}
