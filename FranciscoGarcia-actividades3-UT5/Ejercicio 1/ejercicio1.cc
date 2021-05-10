#include <iostream>
using namespace std;

/**
 *  @class persona
 *  @brief Representa una clase persona con sus métodos públicos y un campo privado
 */
class persona
{
public:
    void dormir(); /**< método void dormir */
    void hablar(); /**< método void hablar */
    void contar(int); /**< método void contar */
    void adquirirNombre(); /**< método void adquirirNombre */
    void decirNombre(); /**< método void decirNombre */

private:
    char nombre[40]; /**< campo privado nombre de tipo char */
};
/**
* @brief Método que se usa para dormir al personaje. El método saca por pantalla una
* cadena de caracteres formada por una secuencia de “z”
**/
void persona::dormir()
{
    cout << "zzzzzzzzz" << endl;
}
/**
* @brief Método que se usa para hacer hablar al personaje. 
*
* El método saca por pantalla una cadena de caracteres formada por una secuencia de 
* tres carácteres "bla" que se repite cuatro veces.
**/
void persona::hablar()
{
    cout << "bla bla bla bla" << endl;
}
/**
* @brief Método que se usa para hacer contar al personaje. 
*
* El método recibe un parámetro de tipo numérico int denominado limite, el cúal marca el tope hasta 
* donde contará el personaje. Saca por pantalla los números contados de forma sucesiva.
**/
void persona::contar(int limite)
{
    for (int i = 0; i < limite; i++)
    {
        cout << i << endl;
    }
}
/**
* @brief Método que se usa asignar un nombre al personaje. 
*
* El método solicita que se introduzca un nombre, el cuál es asignado al personaje mediante el campo "nombre".
**/
void persona::adquirirNombre()
{
    cout << "Soy una persona. Ingrese mi nombre: ";
    cin >> nombre;
}
/**
* @brief Método que se usa para que el personaje diga su nombre. 
*
* El método saca por pantalla el nombre del personaje, el cúal está asignado en el campo "nombre".
**/
void persona::decirNombre()
{
    cout << "Mi nombre es: " << nombre << endl;
}/**
* @brief Método main. 
*
* Se solicita al usuario si desea crear un nuevo objeto persona. Si la respuesta es afirmativa, 
* se crea el nuevo objeto. Posteriormente, se pide si se desea que la persona se vaya a dormir, y si
* se desea que la persona cuente, para lo cuál se llamaría a los métodos dormir(), y contar(int), respectivamente,
* si la respuesta fuera afirmativa.
**/
int main()
{
    int respuesta = 0;
    cout << "Desea crear una persona? 1=Si, 0=No: ";
    cin >> respuesta;
    if (respuesta == 1)
    {
        persona *p = new persona();
        cout << "Desea que vaya a dormir? 1=Si, 0=No: ";
        cin >> respuesta;
        if (respuesta == 1)
        {
            p->dormir();
        }
        cout << "Desea oirme contar? 1=Si, 0=No: ";
        cin >> respuesta;
        if (respuesta == 1)
        {
            p->contar(20);
        }
    }
    system("pause");
    return 0;
}