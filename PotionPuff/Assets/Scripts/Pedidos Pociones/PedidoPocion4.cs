using UnityEngine;


public class PedidoPocion4 : MonoBehaviour
{
    CookManagerScript cookManagerScript;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cookManagerScript = FindObjectOfType<CookManagerScript>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cookManagerScript.Potion4Win();
        cookManagerScript.PotionLose();
       
    }
    public void Salir()
    {
        animator.SetBool("SalidaEscoba", true);
    }
}
