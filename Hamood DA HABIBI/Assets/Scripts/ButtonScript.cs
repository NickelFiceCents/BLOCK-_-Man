using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioClip clickSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayClipAtPoint(clickSound, transform.position);
        }
    }
    public void UrMom()
    {
        AudioSource.PlayClipAtPoint(clickSound, transform.position);
    }
}
