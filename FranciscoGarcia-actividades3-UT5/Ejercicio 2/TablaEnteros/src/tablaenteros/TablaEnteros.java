/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tablaenteros;

/**
 * <h2>Implantación de varios métodos sobre una tabla de enteros</h2>
 * Teniendo una tabla con números enteros, se sumarán sus elementos, 
 * se mostrará el mayor de ellos, y se indicará la posición de uno de ellos.
 *
 * @author Francisco García
 *
 *
 */
public class TablaEnteros {
    
    //Campo de la clase
    private Integer[] tabla;
    /**
    * Este metodo es el constructor de la clase TablaEnteros.
    * @param tabla El parámetro tabla define el array de números enteros.
    */
    TablaEnteros(Integer[] tabla) {
        if (tabla == null || tabla.length == 0) {
            throw new IllegalArgumentException("No hay elementos");
        }
        this.tabla = tabla;
    }
    /**
    * Este metodo se usa para sumar todos los números enteros de la tabla.
    * @return int devuelve la suma de los elementos de la tabla.
    */
    public int sumaTabla() {
        int suma = 0;
        for (int i = 0; i < tabla.length; i++) {
            suma += tabla[i];
        }
        return suma;
    }
    /**
    * Este metodo se usa para encontrar el número mayor de la tabla.
    * @return int devuelve el mayor elemento de la tabla.
    */
    public int mayorTabla() {
        int max = -999;
        for (int i = 0; i < tabla.length; i++) {
            if (tabla[i] > max) {
                max = tabla[i];
            }
        }
        return max;
    }
    /**
    * Este metodo se usa para encontrar la posición de un elemento en la tabla, en el caso de que exista el elemento.
    * @param n El parámetro n define el número que queremos buscar.
    * @return int devuelve la posición de un elemento cuyo valor se pasa.
    */    
    public int posicionTabla(int n) {
        for (int i = 0; i < tabla.length; i++) {
            if (tabla[i] == n) {
                return i;
            }
        }
        throw new java.util.NoSuchElementException("No existe" + n);

    }
}

