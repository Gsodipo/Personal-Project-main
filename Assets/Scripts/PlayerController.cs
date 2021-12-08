using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public Rigidbody rb;
   public float speed = 5f;
   public float jump = 5f;
   public AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
       rb =  GetComponent<Rigidbody>();
      
    }
      
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, verticalInput * speed);

        if(Input.GetButtonDown("Jump"))
        {
           Jump();
        }

    }

    void Jump()
    {
         rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
         jumpSound.Play();
         
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collisionInfo.transform.parent.gameObject);
            Jump();
        }
    }

}
