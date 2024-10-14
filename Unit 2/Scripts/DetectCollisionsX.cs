using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
		//destroy the ball when comes in contact with the dog
		
        Destroy(gameObject);

    }
	
}
