using UnityEngine;
using System.Collections;

public class Ingrediente2 : MonoBehaviour
{
    public CookManagerScript cookManagerScript;
    public GameObject Puff;
    public Transform PuffPositon;
    public Transform TPIngrediente;
    public GameObject IngFalso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        cookManagerScript.I2 = true;
        cookManagerScript.cantidadIng++;
        Instantiate(Puff, PuffPositon);
        StartCoroutine(TPIngredienteTiming());
        
    }

    IEnumerator TPIngredienteTiming()
    {

        yield return new WaitForSeconds(0.583f);
        
        invoqueIng();




    }
    public void invoqueIng()
    {
        Instantiate(IngFalso, TPIngrediente);
    }
}
