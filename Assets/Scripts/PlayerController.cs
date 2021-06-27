using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;
    public Animator tyAnimator;
    public TyAudioController audioController;
    public bool grounded = true;

    [HideInInspector]public int terrain;

    private Rigidbody player;
    private Vector3 respawnPoint = new Vector3(0, 5.25f, 0);
    private Vector3 direction;
    private Vector3 movement;
    private Vector3 mouseRotation = Vector3.zero;
    private Vector3 lastGroundPosition;
    private Quaternion charRotation;
    private float fallDistance = 0f;
    private CapsuleCollider playerCollision;
    private LayerMask ground;
    private AnimatorStateInfo currentAnimation;
    private float animatioTime;

    // Initial Setup.
    void Start()
    {
        //Getting the player's Rigidbody
        player = GetComponent<Rigidbody>();
        playerCollision = GetComponent<CapsuleCollider>();
        ground = LayerMask.GetMask("Default");
    }

    void Update()
    {
        currentAnimation = tyAnimator.GetCurrentAnimatorStateInfo(0);

        //Rotating
        if (Input.GetMouseButton(1))
            mouseRotation.y += Input.GetAxis("Mouse X");

        // Respawn if you fall from the platforms.
        if (player.transform.position.y <= -50)
            PlayerReset();
        if (Input.GetButtonDown("Jump") && grounded)
            Jump();
        tyAnimator.SetBool("inMidAir", !grounded);
        if (!grounded)
            fallDistance = lastGroundPosition.y - player.transform.position.y;
        tyAnimator.SetFloat("fallDistance", fallDistance);
    }

    // Controlling the player's movement
    private void FixedUpdate()
    {
        grounded = Physics.CheckCapsule(playerCollision.bounds.center, new Vector3(playerCollision.bounds.center.x, playerCollision.bounds.min.y, playerCollision.bounds.center.z),
            playerCollision.radius * 0.7f, ground);
        Move();
    }

    private void Move()
    {
        // X and Z movement
        float strafe = Input.GetAxis("Horizontal");
        float walk = Input.GetAxis("Vertical");

        direction.x = strafe;
        direction.z = walk;
        Vector3.Normalize(direction);

        movement = Vector3.forward * direction.magnitude;
        Vector3.Normalize(movement);

        if (direction.magnitude != 0)
        {
            charRotation = Quaternion.LookRotation(direction);
            transform.rotation = charRotation;
            transform.Rotate(mouseRotation);
        }
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.Self);
        if (movement.magnitude != 0)
            tyAnimator.SetBool("isMoving", true);
        else
            tyAnimator.SetBool("isMoving", false);

        currentAnimation = tyAnimator.GetCurrentAnimatorStateInfo(0);
        animatioTime = currentAnimation.normalizedTime;
    }

    private void Jump()
    {
        player.AddForce(0, jumpPower, 0, ForceMode.Impulse);
        tyAnimator.SetTrigger("isJumping");
    }

    // Reset the player if he falls of the game.
    private void PlayerReset()
    {
        player.transform.position = respawnPoint;
        player.transform.rotation = Quaternion.Euler(0, 0, 0);
        mouseRotation = Vector3.zero;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grass"))
            terrain = 0;
        else
            terrain = 1;
    }
}
