using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre;

    public void CargaEscena(string nombre1){
        SceneManager.LoadScene(nombre1);
    }
}
