using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.fixedDeltaTime;
        rotation *= Time.fixedDeltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation != 0 && Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isJumping", false);
            anim.SetFloat("characterSpeed", translation);
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("isJumping", true);
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetFloat("characterSpeed", translation);
            }
        }
        else if (translation == 0 && Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetFloat("characterSpeed", translation);
        }
        else if (translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isJumping", false);
            anim.SetFloat("characterSpeed", translation);
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("isJumping", true);
                anim.SetBool("isWalking", true);
                anim.SetBool("isRunning", false);
                anim.SetFloat("characterSpeed", translation);
            }
        }
        else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isWalking", false);
            anim.SetBool("isJumping", false);
            anim.SetFloat("characterSpeed", 0);
        }

    }
}
