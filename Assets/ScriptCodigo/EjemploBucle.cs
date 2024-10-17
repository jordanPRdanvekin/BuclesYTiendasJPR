using System.Collections; // Importa la biblioteca de colecciones para estructuras como listas y colas
using System.Collections.Generic; // Importa las bibliotecas genéricas de colecciones para trabajar con listas genéricas
using UnityEngine; // Importa la biblioteca de Unity para usar sus funcionalidades

public class EjemploBucle : MonoBehaviour // Define una clase llamada EjemploBucle que hereda de MonoBehaviour
{
    public int[] arrayNumeros; // Declara un array de enteros para almacenar las notas
    public float media = 0; // Variable para calcular la media de las notas, inicializada a 0
    public float suma = 0; // Variable para acumular la suma de las notas, inicializada a 0
    public int bajo; // Variable para almacenar la nota más baja
    public int alta; // Variable para almacenar la nota más alta

    void Start()
    {
        // Verifica si el array tiene elementos
        if (arrayNumeros.Length > 0) // Asegura que el array no esté vacío
        {
            alta = arrayNumeros[0]; // Inicializa 'alta' con el primer elemento del array
            bajo = arrayNumeros[0]; // Inicializa 'bajo' con el primer elemento del array
        }

        // Bucle que recorre cada elemento del array
        for (int i = 0; i < arrayNumeros.Length; i++) // 'i' representa el índice actual
        {
            // Interacción: Muestra el índice y el valor de cada nota en la consola
            Debug.Log("La nota número " + i + " es igual a " + arrayNumeros[i]);

            // Acumula el valor de la nota en la variable 'suma'
            suma += arrayNumeros[i]; // Se actualiza 'suma' al agregar la nota actual

            // Interacción: Compara la nota actual con 'bajo' para encontrar la nota más baja
            if (arrayNumeros[i] < bajo)
            {
                bajo = arrayNumeros[i]; // Si la nota es menor, actualiza 'bajo'
            }

            // Interacción: Compara la nota actual con 'alta' para encontrar la nota más alta
            if (arrayNumeros[i] > alta)
            {
                alta = arrayNumeros[i]; // Si la nota es mayor, actualiza 'alta'
            }
        }

        // Cálculo de la media: se asegura que el array no esté vacío antes de dividir
        if (arrayNumeros.Length > 0) // Previene la división por cero
        {
            media = suma / arrayNumeros.Length; // Calcula la media
        }

        // Interacción final: Muestra en la consola la información acumulada
        Debug.Log("Además, la nota más baja del alumno es " + bajo +
                  ", la más alta es " + alta +
                  " y la media resultante sería " + media);
    }

    void Update()
    {
        // Este método se llama en cada cuadro de juego, pero actualmente no tiene código
    }
}

