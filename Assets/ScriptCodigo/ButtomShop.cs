using System.Collections; // Espacio de nombres para colecciones.
using System.Collections.Generic; // Espacio de nombres para colecciones genéricas.
using UnityEngine; // Funcionalidades de Unity.
using TMPro; // Sistema de texto avanzado en Unity.

public class ButtomShop : MonoBehaviour
{
    [SerializeField]
    private Cartera myWallet; // Referencia a la cartera del jugador.

    [SerializeField]
    private string[] posiblesNombres; // Nombres posibles para los ítems.

    private TextMeshProUGUI textoBotton; // Componente de texto para mostrar el precio del ítem.

    [SerializeField]
    private string nameItem = "objeto"; // Nombre del ítem a comprar.

    [SerializeField]
    private float priceItem; // Precio del ítem.

    // Método Start que se ejecuta al iniciar el juego.
    private void Start()
    {
        textoBotton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        // Asigna un nombre y precio aleatorio al ítem.
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        priceItem = Random.Range(25f, 500f);

        // Formatea el texto del botón para mostrar el precio.
        textoBotton.text = priceItem.ToString("0.00") + " €\n" + nameItem;
    }

    // Método que se llama al presionar el botón de la tienda.
    public void ClickEnBotonDeTienda()
    {
        // Genera un nuevo nombre y precio al presionar el botón.
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        priceItem = Random.Range(25f, 500f);

        // Informa a la cartera sobre la compra del ítem.
        myWallet.InformarCompra(nameItem, priceItem);
    }
}




