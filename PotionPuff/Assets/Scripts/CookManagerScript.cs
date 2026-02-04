using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public float potionPoint;

    public PedidosManager pedidosManager;

    public GameObject losePuff;
    public Transform losePuffTransform;

    [Header("Timer")]
    public Slider timeSlider;
    public float sliderTimer;
    public bool stopTimer = false;

    [Header("Progresion")]
    public Slider progSlider;
    [Header("Puntuacion")]
    public int puntos;
    public int puntosGanados;
    public int puntosperdidos;

    public buhoScript buhoScript;

    void Start()
    {
        ResetIngredientes();
        potionPoint = 0;

        SalidaEscoba = false;
     
        timeSlider.maxValue = sliderTimer;
        timeSlider.value = sliderTimer;

        progSlider.maxValue = 10f;

        StartTimer();

    }

    // Update is called once per frame
    void Update()
    {
        Cocinar();
        PotionLose();

        if (potionPoint == 10)
        {
            SceneManager.LoadScene(2);
        }

        progSlider.value = potionPoint;
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
            GanarPotionPoint();
            ResetTimer();
            GanarPuntos(30);
            AudioManager.Instance.PlaySFX(3);
            buhoScript.Celebrar();
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
            GanarPotionPoint();
            ResetTimer();
            GanarPuntos(30);
            AudioManager.Instance.PlaySFX(3);
            buhoScript.Celebrar();
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
            GanarPotionPoint();
            ResetTimer();
            GanarPuntos(30);
            AudioManager.Instance.PlaySFX(3);
            buhoScript.Celebrar();

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
            GanarPotionPoint();
            ResetTimer();
            GanarPuntos(30);
            AudioManager.Instance.PlaySFX(3);
            buhoScript.Celebrar();
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
            perderPotionPoint();
            ResetTimer();
            StartCoroutine(InvocarExplosion());
            PerderPuntos(50);
            buhoScript.Enfadarse();
            
        }
    }
     public void TimePotionLose()
    {
        Debug.Log("Has fallado la pocion");
        ResetIngredientes();
       
        pedidosManager.PedidoRandom();
        perderPotionPoint();
        ResetTimer();
    }

  public void GanarPotionPoint()
    {
        potionPoint++;
    }
    
   
    public void perderPotionPoint()
    {
        potionPoint--;
    }
  
    //Timer

    public void StartTimer()
    {
        StartCoroutine(StartTheTimerTicker());
    }
    IEnumerator StartTheTimerTicker()
    {
        while (stopTimer == false)
        {
            sliderTimer -= Time.deltaTime;
            yield return new WaitForSeconds(0.001f);

            if (sliderTimer <= 0)
            {
                
                TimePotionLose();
            }
            if (stopTimer == false)
            {
                timeSlider.value = sliderTimer;
            }
        }
        
    }

    public void StopTimer()
    {
        stopTimer = true;
    }

    public void ResetTimer()
    {
        sliderTimer = 20;
        timeSlider.maxValue = sliderTimer;
        timeSlider.value = sliderTimer;
        stopTimer = false;
        SalidaEscoba = true;
    }

    IEnumerator InvocarExplosion()
    {
        yield return new WaitForSeconds(1.3f);
        Instantiate(losePuff, losePuffTransform);
        AudioManager.Instance.PlaySFX(2);
    }

    public void GanarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
    }

    public void PerderPuntos(int puntosPerdidos)
    {
        puntos -= puntosPerdidos;
    }
}
