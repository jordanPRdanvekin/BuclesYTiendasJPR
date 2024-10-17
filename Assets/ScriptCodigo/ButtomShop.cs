using System.Collections;  // Importa el espacio de nombres para las colecciones.
using System.Collections.Generic;  // Importa el espacio de nombres para colecciones genéricas.
using UnityEngine;  // Importa el espacio de nombres para funcionalidades de Unity.
using TMPro;  // Importa el espacio de nombres para TextMeshPro, un sistema de texto avanzado en Unity.

public class ButtomShop : MonoBehaviour
{
    // Referencia a la clase 'Cartera', que se supone maneja el saldo del jugador.
    [SerializeField]
    Cartera myWallet;  // Variable privada para almacenar la referencia a la billetera del jugador.

    // Variable para el componente de texto que mostrará el precio del objeto.
    TextMeshProUGUI textoBotton;  // Componente de texto donde se mostrará el precio del objeto.

    // Nombre del ítem que se va a comprar.
    [SerializeField]
    string nameItem = "objeto";  // Nombre del artículo a comprar (se puede modificar en el inspector).

    // Precio del ítem.
    [SerializeField]
    float priceItem;  // Precio del artículo que se va a mostrar y restar de la billetera.

    // Método Start se llama antes de la primera actualización del frame.
    void Start()
    {
        // Obtiene el componente TextMeshProUGUI del primer hijo del objeto actual.
        textoBotton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        // Asigna un precio aleatorio al ítem dentro del rango de 25 a 500 euros.
        priceItem = Random.Range(25f, 500f);

        // Convierte el precio a string y lo asigna al texto del botón, seguido de " €".
        textoBotton.text = priceItem.ToString() + " €";
    }

    // Método que se llama cuando el botón de la tienda es presionado.
    public void ClickEnBotonDeTienda()
    {
        // Llama al método 'RestarSaldo' de la cartera, restando el precio del ítem.
        myWallet.RestarSaldo(priceItem);
    }
}

