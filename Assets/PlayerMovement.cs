using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movSpeed = 2;
    public Rigidbody2D rigidBody;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    public void Update() {
        // Input

        //Movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Animations
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    public void FixedUpdate() {
        // Actions
        rigidBody.MovePosition(rigidBody.position + movement.normalized * movSpeed * Time.fixedDeltaTime);
    }
}
