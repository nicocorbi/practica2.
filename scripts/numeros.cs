using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TMP_Text textUI;
    [SerializeField] TMP_Text randomnumberUI;
    [SerializeField] TMP_Text contadorUI;
    [SerializeField] TMP_Text recordUI;
    [SerializeField] GameObject inicioUI;
    [SerializeField] GameObject fondoverdeUI;
    [SerializeField] GameObject fondorojoUI;
    [SerializeField] int currentValue = 0;
    [SerializeField] double timePerNumber = 0;
    [SerializeField] float elapsedTime = 0;
    [SerializeField] int randomnumber;
    [SerializeField] int Timerandomnumber;
    [SerializeField] int nivelActual = 0;
    [SerializeField] int recordGame = 0;
    [SerializeField] int recordMaximo = 0; 






    void Start()
    {
        randomnumber = Random.Range(1, 15);
        randomnumberUI.text = randomnumber.ToString();
        Debug.Log("Pulsa espacio para empezar");
        inicioUI.SetActive(true);
        fondoverdeUI.SetActive(false);
        fondorojoUI.SetActive(false);
    }

   
    void Update()
    {
       
        elapsedTime = elapsedTime + Time.deltaTime;
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            inicioUI.SetActive(false);
           
            if (currentValue == 0)
            {
                nivelActual = 0;
                

            }
            
            if (currentValue == randomnumber)
            {
                fondoverdeUI.SetActive(true);
                nivelActual++;
                timePerNumber = timePerNumber * 0.90;
                Puntos();
                recordGame++;
                record();





            }
            else 
            {
                nivelActual = 0;
                fondorojoUI.SetActive(true);
                fondoverdeUI.SetActive(false);
                recordGame = 0;
                
                Puntos();
            }
            
            
            
            
            currentValue = 0;
            textUI.text = currentValue.ToString();
            randomnumber = Random.Range(1, 15);
            randomnumberUI.text = randomnumber.ToString();
        }

        if (currentValue >= 0.2)
            {
                 fondoverdeUI.SetActive(false);
                 fondorojoUI.SetActive(false);
            }

        if (elapsedTime >= timePerNumber)
        {
            currentValue++;
            textUI.text = currentValue.ToString();
            elapsedTime = 0;
        }
        
        if ( nivelActual == 0)
        {
            timePerNumber = 1;
           
            
        }
        
       
    }
   void Puntos()
    {
        
        print("contador:" + 1);
        contadorUI.text = nivelActual.ToString();
       
    }
    void record()
    {
        
        if (recordGame > recordMaximo)
        {
            recordMaximo++;
        }
        print("contador" + 1);
        recordUI.text = recordMaximo.ToString();

    }
   
    
}
// Time.deltaTime
