using UnityEngine;

public class PedidosManager : MonoBehaviour
{
    public GameObject Pedido1;
    public GameObject Pedido2;
    public GameObject Pedido3;
    public GameObject Pedido4;

    public int NPedidos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PedidoRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PedidoRandom()
    {
        NPedidos = Random.Range(0, 4);

        if ( NPedidos == 0 )
        {
            Debug.Log("Pedido1 es 1,3,5");
            Instantiate(Pedido1);
        }
        else if ( NPedidos == 1 )
        {
            Debug.Log("Pedido2 es 2,4,6");
            Instantiate(Pedido2);
        }
        else if( NPedidos == 2 )
        {
            Debug.Log("Pedido3 es 7,3,5");
            Instantiate(Pedido3);
        }
        else if(NPedidos == 3)
        {
            Debug.Log("Pedido4 es 8,6,1");
            Instantiate(Pedido4);
        }
    }
}
