using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackChaseRange : MonoBehaviour
{
    Animator anim;

    public Collider sphereCol;

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(AttackRange());
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isRunning", true);
        }
    }
    IEnumerator AttackRange()
    {
        yield return new WaitForSeconds(2);

        sphereCol.enabled = true;
    }
}
