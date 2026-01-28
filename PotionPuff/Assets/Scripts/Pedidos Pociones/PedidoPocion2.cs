using UnityEngine;

public class PedidoPocion2 : MonoBehaviour
{
    CookManagerScript cookManagerScript;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cookManagerScript = FindObjectOfType<CookManagerScript>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        cookManagerScript.Potion2Win();
        cookManagerScript.PotionLose();
    }
    public void Salir()
    {
        animator.SetBool("SalidaEscoba", true);
    }
}

