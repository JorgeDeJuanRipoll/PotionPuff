using UnityEngine;


public class PedidoPocion4 : MonoBehaviour
{
    CookManagerScript cookManagerScript;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cookManagerScript = FindObjectOfType<CookManagerScript>();
       
    }

    // Update is called once per frame
    void Update()
    {
        cookManagerScript.Potion4Win();
        cookManagerScript.PotionLose();
       
    }
    
}
