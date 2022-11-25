using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody2D robody2D;
    private bool isOnGround;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        robody2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("state", 1);
            this.transform.position += new Vector3(0f, speed * Time.fixedDeltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.localScale = new Vector3(System.Math.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            this.transform.position += new Vector3(-speed * Time.fixedDeltaTime, 0f, 0f);
            animator.SetInteger("state", 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.localScale = new Vector3(-1 * System.Math.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            this.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0f, 0f);
            animator.SetInteger("state", 3);


        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("state", 2);
            this.transform.position += new Vector3(0f, -speed * Time.fixedDeltaTime, 0f);

        }
        else
        {
            animator.SetInteger("state", 0);
        }

    }
}
