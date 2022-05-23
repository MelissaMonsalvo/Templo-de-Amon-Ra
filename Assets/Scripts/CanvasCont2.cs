using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCont2 : MonoBehaviour
{
    public GameObject pantalla;
    bool f = true;
    public Inventario inventario;

    void Start()
    {
         inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(inventario.cantidad >= 1){
            pantalla.SetActive(false);
            gameObject.SetActive(true);
        }
        
    }
}
