using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player; //Declara uma variável do tipo GameObject. 
    private Vector3 offset = new Vector3(0, 8, -12);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   //offset the camera behind the player by adding  to the player position.
        transform.position = player.transform.position + offset; // Atribui a posição do player a camera.   
    }
}
