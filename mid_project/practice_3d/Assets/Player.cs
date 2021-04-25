using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{	
	public int jumpPower = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
		// {
			// GetComponent<Rigidbody>().velocity = new Vector3(0,5,0); // space를 누르면 y축이 5만큼 올라감.
		// }
		
		if(Input.GetButtonDown("Fire1"))
	 	{
			GetComponent<Rigidbody>().velocity = new Vector3(0,jumpPower,0); // space를 누르면 y축이 5만큼 올라감.
		}
		

    }
}


