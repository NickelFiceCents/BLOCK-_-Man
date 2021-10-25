using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Ragdoll1 : MonoBehaviour
{

    private Rigidbody[] rigidbodies;
    private Collider[] colliders;

    Animator anim;
    public Collider PlayerCol;
    public Rigidbody PlayerRb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();

        SetCollidersEnabled(false) ;
        SetRigidbodiesKinematic(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetCollidersEnabled(bool enabled)
    {
        foreach(Collider col in colliders)
        {
            col.enabled = enabled;
            PlayerCol.enabled = true;
        }
    }
    private void SetRigidbodiesKinematic(bool kinematic)
    {
        foreach(Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = kinematic;
            PlayerRb.isKinematic = false;
        }
    }
    private void RagdollEnable()
    {
        this.GetComponent<EnemyRot>().enabled = false;
        Destroy(PlayerCol);
        Destroy(PlayerRb);
        anim.enabled = false;

        SetCollidersEnabled(true);
        SetRigidbodiesKinematic(false);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Weapon")
        {
            RagdollEnable();
        }
    }
}
