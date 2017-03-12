using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Triangle1"))
        {
            other.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
