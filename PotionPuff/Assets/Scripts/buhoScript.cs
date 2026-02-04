using System.Collections;
using UnityEngine;

public class buhoScript : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enfadarse()
    {
        animator.SetBool("Enfadado", true);
        StartCoroutine(StopEnfado());
    }

    IEnumerator StopEnfado()
    {
        yield return new WaitForSeconds(1.03f);
        animator.SetBool("Enfadado", false);
    }

    public void Celebrar()
    {
        animator.SetBool("Contento", true) ;
        StartCoroutine(StopCelebracion());
    }

    IEnumerator StopCelebracion()
    {
        yield return new WaitForSeconds(2.21f);
        animator.SetBool("Contento", false);
    }
}
