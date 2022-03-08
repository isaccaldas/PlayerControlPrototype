using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dentro do GetAxis, a String deve ser o mesmo nome do Axis, setado no Input Manager
        horizontalInput = Input.GetAxis("Horizontal"); 

        //Move o veículo para frente
        //transform.Translate(0, 0, 1); //usa o componente "transform" e o seu método "Translate" usando as coodernadas x,y,z
        //*Time.deltaTime * 20. multiplica a velocidade por um perìodo de tempo nesse caso 20m por segundo. 
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // outra forma de fazer com que o objeto vá para frente.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
