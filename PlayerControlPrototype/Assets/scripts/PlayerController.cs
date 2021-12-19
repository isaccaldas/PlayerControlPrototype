using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move o veículo para frente
        //transform.Translate(0, 0, 1); //usa o componente "transform" e o seu método "Translate" usando as coodernadas x,y,z
        transform.Translate(Vector3.forward); // outra forma de fazer com que o objeto vá para frente.
    
    }
}
