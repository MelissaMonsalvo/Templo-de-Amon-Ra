using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public int cantidad = 0;
    public Text textoContador;
    public GameObject pantalla;
    public GameObject pantalla2;

    
    void start(){
          
    }
    
    void Update()
    { 
        textoContador.text = cantidad.ToString();
        if(cantidad >= 10){
            pantalla.SetActive(false);
            pantalla2.SetActive(true);
            cantidad-=1; 
        }

        if (Input.GetKey(KeyCode.JoystickButton0))
        {
             pantalla2.SetActive(false);
        }        
    
    }

}
