using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnColliisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {

        }
    }
}
