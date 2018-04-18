using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidBody;

    [SerializeField]
    private float MovementSpeed;

	// Use this for initialization
	void Start ()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
           

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    { 
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);

		
	}
    private void HandleMovement(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal*MovementSpeed, myRigidBody.velocity.y);

    }

}
