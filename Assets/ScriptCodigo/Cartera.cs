using System.Collections;  // Importa el espacio de nombres para las colecciones.
using System.Collections.Generic;  // Importa el espacio de nombres para colecciones genéricas.
using UnityEngine;  // Importa el espacio de nombres para funcionalidades de Unity.
using TMPro;  // Importa el espacio de nombres para TextMeshPro, un sistema de texto avanzado en Unity.

public class Cartera : MonoBehaviour
{
    // Variable privada que almacena el saldo actual del jugador.
    float saldo;  // Saldo inicial de la cartera.

    // Componente de texto donde se mostrará el saldo.
    [SerializeField]
    TextMeshProUGUI LabelSaldo;  // Referencia al texto que muestra el saldo.

    // GameObjects para mostrar mensajes de compra.
    [SerializeField]
    GameObject confirmarCompra;  // Mensaje de confirmación de compra (no se utiliza en el código actual).
    [SerializeField]
    GameObject noSaldo;  // Mensaje que se muestra si el saldo es insuficiente.

    // Start se llama antes de la primera actualización del frame.
    void Start()
    {
        // Asigna un saldo aleatorio al jugador dentro del rango de 450 a 950 euros.
        saldo = Random.Range(450f, 950f);

        // Configura el texto del saldo, asegurando que tenga un formato de 3 dígitos, un decimal y el símbolo de euro.
        LabelSaldo.text = saldo.ToString("000.0" + " €");
    }

    // Método para restar una cantidad del saldo.
    public void RestarSaldo(float precio)
    {
        // Verifica si hay suficiente saldo para realizar la compra.
        if (saldo > precio)
        {
            // Resta el precio del saldo actual.
            saldo -= precio;

            // Actualiza el texto del saldo después de la compra.
            LabelSaldo.text = saldo.ToString("000.0" + " €");
        }
        else
        {
            // Activa el GameObject que informa al jugador que no tiene saldo suficiente.
            noSaldo.SetActive(true);
        }
    }

    // Update se llama una vez por frame, pero no se utiliza en este caso.
    void Update()
    {

    }
}

