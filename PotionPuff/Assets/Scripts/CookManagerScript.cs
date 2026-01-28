using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class CookManagerScript : MonoBehaviour
{
    [Header("ingradientes")]
    public bool I1;
    public bool I2;
    public bool I3;
    public bool I4;
    public bool I5;
    public bool I6;      
    public bool I7;
    public bool I8;

    public int potionNum;

    public int cantidadIng;

    public bool SalidaEscoba;
  


    public PedidosManager pedidosManager;
    void Start()
    {
        ResetIngredientes();

        SalidaEscoba = false;
     

    }

    // Update is called once per frame
    void Update()
    {
        Cocinar();
        PotionLose();
        
      
    }

    public void ResetIngredientes()
    {
        I1 = false;
        I2 = false;
        I3 = false;
        I4 = false;
        I5 = false;
        I6 = false;
        I7 = false;
        I8 = false;

        potionNum = 0;
        cantidadIng = 0;    
    }

    public void Cocinar()
    {
        if (I1 == true && I3 == true && I5 == true && cantidadIng == 3)
        {
            potionNum = 5;
        }
        if (I2 == true && I4 == true && I6 == true)
        {
            potionNum = 1;
        }
      if(I7 == true && I3 &&  I5 == true)
        {
            potionNum = 2;
        }
        if(I8 == true && I6 == true && I1 ==true)
        {
            potionNum = 3;
        }
        else if (cantidadIng == 4) 
        {
            potionNum = 4;
        }
    }

    public void Potion1Win()
    {
        if (potionNum == 5 && cantidadIng ==3)
        {
            Debug.Log("Has hecho la pocion 1");
            ResetIngredientes();
            SalidaEscoba = true;
            pedidosManager.PedidoRandom();
           

           
            
        }
    }
    public void Potion2Win()
    {
        if (potionNum == 1 && cantidadIng == 3)
        {
            Debug.Log("Has hecho la pocion 2");
            ResetIngredientes();
            SalidaEscoba = true;
            pedidosManager.PedidoRandom();
           


        }
    }
    public void Potion3Win()
    {
        if (potionNum == 2 && cantidadIng ==3)
        {
            Debug.Log("Has hecho la pocion 1");
            ResetIngredientes();
            SalidaEscoba = true;
            pedidosManager.PedidoRandom();
            




        }
    }
    public void Potion4Win()
    {
        if (potionNum == 3 && cantidadIng == 3)
        {
            Debug.Log("Has hecho la pocion 1");
            ResetIngredientes();
            SalidaEscoba = true;
            pedidosManager.PedidoRandom();
      


        }
    }
    public void PotionLose()
    {
        if (potionNum == 4 && cantidadIng == 4)
        {
            Debug.Log("Has fallado la pocion");
            ResetIngredientes();
            SalidaEscoba = true;
            pedidosManager.PedidoRandom();
            

        }
    }


  
    
   

  
  
}
