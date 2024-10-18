using System.Collections;  // Espacio de nombres para colecciones.
using System.Collections.Generic;  // Espacio de nombres para colecciones genéricas.
using UnityEngine;  // Espacio de nombres para funcionalidades de Unity.
using TMPro;  // Espacio de nombres para el sistema de texto avanzado en Unity.

public class Cartera : MonoBehaviour
{
    private float saldo;  // Saldo actual del jugador.
    private float precioOQ;  // Precio del objeto en consulta.

    [SerializeField]
    private TextMeshProUGUI LabelSaldo;  // Etiqueta para mostrar el saldo del jugador.

    [SerializeField]
    private TextMeshProUGUI labelConfirmo;  // Etiqueta para mostrar el mensaje de confirmación de compra.

    [SerializeField]
    private GameObject confirmarCompra;  // Panel para confirmar la compra.

    [SerializeField]
    private GameObject noSaldo;  // Panel de alerta de saldo insuficiente.

    // Método Start que se ejecuta al iniciar el juego.
    private void Start()
    {
        // Asigna un saldo aleatorio entre 450 y 950 euros y actualiza la etiqueta.
        saldo = Random.Range(450f, 950f);
        LabelSaldo.text = saldo.ToString("0.00") + " €";

        // Desactiva los paneles de compra al inicio.
        confirmarCompra.SetActive(false);
        noSaldo.SetActive(false);
    }

    // Método llamado cuando el jugador intenta comprar un objeto.
    public void InformarCompra(string nameItem, float precio)
    {
        if (saldo >= precio)  // Verifica si hay saldo suficiente.
        {
            labelConfirmo.text = $"¿Estás seguro que quieres comprar {nameItem} por {precio} €?";  // Mensaje de confirmación.
            confirmarCompra.SetActive(true);  // Activa el panel de confirmación.
            precioOQ = precio;  // Almacena el precio para usarlo al confirmar la compra.
        }
        else
        {
            noSaldo.SetActive(true);  // Muestra alerta de saldo insuficiente.
        }
    }

    // Métodos para cerrar los paneles.
    public void CerrarSaldo() => noSaldo.SetActive(false);  // Cierra el panel de saldo insuficiente.

    public void CerrarCompra() => confirmarCompra.SetActive(false);  // Cierra el panel de confirmación.

    // Método que completa la compra.
    public void Comprar()
    {
        if (saldo >= precioOQ)  // Verifica si hay saldo suficiente para completar la compra.
        {
            saldo -= precioOQ;  // Descuenta el precio del saldo actual.
            precioOQ = 0.0f;  // Reinicia el precio después de la compra.
            LabelSaldo.text = saldo.ToString("0.00") + " €";  // Actualiza el saldo mostrado.
            confirmarCompra.SetActive(false);  // Cierra el panel de confirmación.
        }
        else
        {
            noSaldo.SetActive(true);  // Muestra alerta de saldo insuficiente.
        }
    }
}



