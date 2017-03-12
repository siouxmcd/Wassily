using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTriangle : MonoBehaviour {
    public AudioSource audioSource;
    bool tri1On = false;

    void Start()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        //audioSource.clip = Resources.Load("Triangle2track") as AudioClip;
        audioSource.Play();
        audioSource.mute = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!tri1On && other.gameObject.CompareTag("Triangle2"))
        {
            tri1On = true;
            audioSource.mute = false;
        }
        else if (tri1On && other.gameObject.CompareTag("Triangle2"))
        {
            audioSource.mute = true;
            tri1On = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tri1On)
        {
            transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
        else if (!tri1On)
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
    }
}
