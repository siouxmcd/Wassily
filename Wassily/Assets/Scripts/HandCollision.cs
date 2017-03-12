using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour {

    // Use this for initialization
    public AudioSource[] sounds;
    public AudioSource tri1audio;
    public AudioSource tri2audio;

    bool triOn = false;
    bool tri2On = false;

	void Start () {
        sounds = GetComponents<AudioSource>();
        tri1audio = sounds[0];
        tri2audio = sounds[1];
        //tri1audio.GetComponent<AudioSource>();
        //tri1audio.mute = false;
        tri2audio.mute = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if ( !triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = true;
            //tri1audio.mute = false;
            other.gameObject.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
        else if (triOn && other.gameObject.CompareTag("Triangle1"))
        {
            triOn = false;
           // tri1audio.mute = true;
            other.gameObject.transform.Rotate(new Vector3(0,0,0));
        }

        if (!tri2On && other.gameObject.CompareTag("Triangle2"))
        {
            tri2On = true;
            tri2audio.mute = false;
            other.gameObject.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
        else if (tri2On && other.gameObject.CompareTag("Triangle2"))
        {
            tri2On = false;
            tri2audio.mute = true;
            other.gameObject.transform.Rotate(new Vector3(0, 0, 0));
        }


        }

    // Update is called once per frame
    void Update () {
		
	}
}
