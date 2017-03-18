using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleNote1 : MonoBehaviour {

    public AudioSource audioSource;
    bool tri2On = false;

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        //audioSource.clip = Resources.Load("Triangle2track") as AudioClip;
        //audioSource.Play();
        //audioSource.mute = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Triangle2"))
        {
            tri2On = true;
            audioSource.Play();
            //audioSource.mute = false;
            transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
        }
        //else if (tri2On && other.gameObject.CompareTag("Triangle2"))
        //{
        //    //audioSource.mute = true;
        //    tri2On = false;
        //    other.gameObject.transform.Rotate(new Vector3(0, 0, 0));
        //}
    }
    // Update is called once per frame
    void Update()
    {
    }
}
