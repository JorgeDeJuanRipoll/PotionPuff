using System.Collections;
using UnityEngine;

public class MostrarIngredientesP2 : MonoBehaviour
{
    public GameObject panelIngredientes;
    public float tiempoVisible = 2f;

    public void Mostrar()
    {
        StopAllCoroutines(); // por si se pulsa varias veces
        StartCoroutine(MostrarTemporalmente());
    }

    IEnumerator MostrarTemporalmente()
    {
        panelIngredientes.SetActive(true);
        yield return new WaitForSeconds(tiempoVisible);
        panelIngredientes.SetActive(false);
    }
}
