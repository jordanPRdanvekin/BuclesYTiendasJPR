using System.Collections;  // Importa el espacio de nombres para las colecciones.
using System.Collections.Generic;  // Importa el espacio de nombres para colecciones gen�ricas.
using UnityEngine;  // Importa el espacio de nombres para funcionalidades de Unity.
using TMPro;  // Importa el espacio de nombres para TextMeshPro, un sistema de texto avanzado en Unity.

public class ButtomShop : MonoBehaviour
{
    // Referencia a la clase 'Cartera', que se supone maneja el saldo del jugador.
    [SerializeField]
    Cartera myWallet;  // Variable privada para almacenar la referencia a la billetera del jugador.

    // Variable para el componente de texto que mostrar� el precio del objeto.
    TextMeshProUGUI textoBotton;  // Componente de texto donde se mostrar� el precio del objeto.

    // Nombre del �tem que se va a comprar.
    [SerializeField]
    string nameItem = "objeto";  // Nombre del art�culo a comprar (se puede modificar en el inspector).

    // Precio del �tem.
    [SerializeField]
    float priceItem;  // Precio del art�culo que se va a mostrar y restar de la billetera.

    // M�todo Start se llama antes de la primera actualizaci�n del frame.
    void Start()
    {
        // Obtiene el componente TextMeshProUGUI del primer hijo del objeto actual.
        textoBotton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        // Asigna un precio aleatorio al �tem dentro del rango de 25 a 500 euros.
        priceItem = Random.Range(25f, 500f);

        // Convierte el precio a string y lo asigna al texto del bot�n, seguido de " �".
        textoBotton.text = priceItem.ToString() + " �";
    }

    // M�todo que se llama cuando el bot�n de la tienda es presionado.
    public void ClickEnBotonDeTienda()
    {
        // Llama al m�todo 'RestarSaldo' de la cartera, restando el precio del �tem.
        myWallet.RestarSaldo(priceItem);
    }
}

