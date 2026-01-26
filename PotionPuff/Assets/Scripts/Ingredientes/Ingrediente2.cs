using UnityEngine;

public class Ingrediente2 : MonoBehaviour
{
    public CookManagerScript cookManagerScript;
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
    }
}
