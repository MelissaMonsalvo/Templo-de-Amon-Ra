﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public int cantidad = 0;
    public Text textoContador;
    
    void Update()
    { textoContador.text = cantidad.ToString();}

}
