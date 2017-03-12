using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour {

    // Use this for initialization
    bool triOn = false;
    bool tri2On = false;

	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if ( !triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = true;
            other.gameObject.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
        else if (triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = false;
            other.gameObject.transform.Rotate(new Vector3(0,0,0));
        }

        if (!tri2On && other.gameObject.CompareTag("Triangle2"))
        {
            tri2On = true;
            other.gameObject.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
        else if (tri2On && other.gameObject.CompareTag("Triangle2"))
        {
            tri2On = false;
            other.gameObject.transform.Rotate(new Vector3(0, 0, 0));
        }


        }

    // Update is called once per frame
    void Update () {
		
	}
}
