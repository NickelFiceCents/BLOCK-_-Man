using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMov : MonoBehaviour
{
    Vector3 PlayerMovementInput;

    public Rigidbody player;
    public Animator anim;

    public float speed;
    public float JumForce;

    public bool isGrounded;

    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    private void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Ground" && view.IsMine)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.AddForce(Vector3.up * JumForce, ForceMode.Impulse);

                anim.SetTrigger("Jump");
            }
        }

        isGrounded = false;
        if (view.IsMine)
        {
            PlayerMovementInput = new Vector3(0, 0, Input.GetAxis("Vertical"));

            Vector3 MoveDirection = transform.TransformDirection(PlayerMovementInput) * speed;

            player.velocity = new Vector3(MoveDirection.x, player.velocity.y, MoveDirection.z);

            transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0);

            if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }
        }
    }
}
