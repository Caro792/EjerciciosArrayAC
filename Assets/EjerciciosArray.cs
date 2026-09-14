using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray : MonoBehaviour
{
    public GameObject[] cubitos;

    // Start is called before the first frame update
    void Start()
    {
       DesactivarPrimerElemento(cubitos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DesactivarPrimerElemento(GameObject[] arr) {
        if(arr.Lenght > 0) {
        arr[0].SetActive(false);
        } else {
            Debug.Log()
        }
    }

}
