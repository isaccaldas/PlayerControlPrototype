using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player; //Declara uma variável do tipo GameObject. 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   //offset the camera behind the player by adding  to the player position.
        transform.position = player.transform.position + new Vector3(0, 5, -7); // Atribui a posição do player a camera.   
    }
}
