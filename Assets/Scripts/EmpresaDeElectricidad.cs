using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeElectricidad : MonoBehaviour
{
    public Domicilio[] domicilios;

    // Start is called before the first frame update
    void Start()
    {
         domicilios = FindObjectsOfType<Domicilio>();
         
         for (int i = 0; i < domicilios.Length; i++)
     {
        domicilios[i].servicioElectricoActivo = Random.value > 0.5f;
        domicilios[i].luzDomicilio.SetActive(domicilios[i].servicioElectricoActivo);
     }
        //Para cada domicilio generar y asignar aleatoriamente un valor booleano 
        // para su propiedad servicioElectricoActivo
        //Para cada domicilio, activar o desactivar el objeto luz 
        // de acuerdo a si la propiedad servicioElectricoActivo es verdadero o falso, respectivamente.         

        MostrarInfoEnConsola();
    }

    // Update is called once per frame
    void Update()
    {
        //Tecla C (CORTE): apaga todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (Domicilio dom in domicilios)
            {
                dom.luzDomicilio.SetActive(false);
            }
            Debug.Log("CORTE: Todas las luces apagadas.");
        }
        //Tecla R(RESTITUCION): enciende las luces solo de los domicilios 
        // con servicioElectricoActivo verdadero
        if (Input.GetKeyDown(KeyCode.R))
        {
        }
        //Tecla T(TODOS): enciende todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.T))
        {
        }
    }

    void MostrarInfoEnConsola()
    {
        //cuántos domicilios tienen su servicio eléctrico activo
        // porcentaje de domicilios con servicio eléctrico activo
    }
}
