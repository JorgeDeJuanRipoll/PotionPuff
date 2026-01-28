using UnityEngine;

public class EscobaScript : MonoBehaviour
{
    CookManagerScript cookManagerScript;

    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      animator = GetComponent<Animator>();
      cookManagerScript = FindObjectOfType<CookManagerScript>();
      cookManagerScript.SalidaEscoba = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (cookManagerScript.SalidaEscoba == true)
        {
            ExitAnim();
        }
    }

    public void DestroyEscoba()
    {
        Destroy(gameObject);
    }
    public void ExitAnim()
    {
        animator.SetBool("SalidaEscoba", true);
    }
    
}
