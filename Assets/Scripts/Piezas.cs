using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Piezas : MonoBehaviour
{
    public Inventario inventario;
    // Start is called before the first frame update
    public GameObject inf;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        inf.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            inventario.cantidad += 1;
            Destroy(gameObject);
            inf.SetActive(true);
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0.0f,60.0f,0.0f) *Time.deltaTime);
        //transform.Translate(new Vector3(0.0f,0.001f*Mathf.Sin((float)Time.time*0.9f),0.0f));
    }
}
