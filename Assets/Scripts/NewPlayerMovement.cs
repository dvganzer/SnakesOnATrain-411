using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 25f;
    Vector2 horizontalMove;
    bool jump = false;
    public Animator animator;

    public GameObject bullet;
    public Transform LaunchOffeset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove.x = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        animator.SetFloat("Speed", horizontalMove.x);
        animator.SetFloat("Speed", horizontalMove.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("Shoot", true);
            runSpeed = 0f;
            Invoke("shootBullet", .5f);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Shoot", false);
            runSpeed = 25f;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove.x * Time.fixedDeltaTime, jump);
        jump = false;
    }
    public void shootBullet()
    {
        Instantiate(bullet, LaunchOffeset.position, transform.rotation);
        Debug.Log("Shooting");
    }
}
