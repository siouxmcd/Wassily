using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour {

    // Use this for initialization
    bool triOn = false;
    bool gridOrb = false;

	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if ( !triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = true;
            other.gameObject.transform.Rotate(new Vector3(1, 30, 45) * Time.deltaTime);
        }

        if (triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = false;
            other.gameObject.transform.Rotate(new Vector3());
        }

        if (!gridOrb && other.gameObject.CompareTag("gridsphere"))
        {
            gridOrb = true;
            while (gridOrb)
            {
                float moveHorizontal = Input.GetAxis("Horizontal");
                float moveVertical = Input.GetAxis("Vertical");
                Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
                movement =  new Vector3(0,0,0);

            }


        }

    // Update is called once per frame
    void Update () {
		
	}
}
