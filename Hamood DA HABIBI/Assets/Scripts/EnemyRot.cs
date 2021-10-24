using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRot : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}
