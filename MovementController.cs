using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        player = GameObject.Find("player");
        animator.SetBool("IsIdle", true);
        animator.SetBool("IsWalking", false);

    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            animator.SetBool("IsIdle", false);
            animator.SetBool("IsWalking", true);

        }
        else
        {
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsWalking", false);

        }
        if (player.transform.position.y <= 9.25)
        {
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsWalking", false);
        }

    }
}