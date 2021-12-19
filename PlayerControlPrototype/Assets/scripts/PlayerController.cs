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
        //Move o ve�culo para frente
        //transform.Translate(0, 0, 1); //usa o componente "transform" e o seu m�todo "Translate" usando as coodernadas x,y,z
        //*Time.deltaTime * 20. multiplica a velocidade por um per�odo de tempo nesse caso 20m por segundo. 
        transform.Translate(Vector3.forward * Time.deltaTime * 20); // outra forma de fazer com que o objeto v� para frente.
    
    }
}
