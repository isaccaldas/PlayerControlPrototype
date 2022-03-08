using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dentro do GetAxis, a String deve ser o mesmo nome do Axis, setado no Input Manager
        //get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move o veículo para frente
        //transform.Translate(0, 0, 1); //usa o componente "transform" e o seu método "Translate" usando as coodernadas x,y,z
        //*Time.deltaTime * 20. multiplica a velocidade por um perìodo de tempo nesse caso 20m por segundo. 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); // outra forma de fazer com que o objeto vá para frente.
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput );
        
        //Rotaciona o veículo
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
