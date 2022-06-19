using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    InputManager inputManager;

    public Transform player;
    public Rigidbody playerRigidbody;
    public float movementSpeed = 7.0f;
    public float rotationSpeed = 15.0f;

    Vector3 moveDirction;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    public void AllMovement()
    {
        HandelMovement();
        //HandelRotation();
    }

    private void HandelMovement()
    {
        moveDirction = player.forward * inputManager.verticalInput;
        moveDirction = moveDirction + player.right * inputManager.horizontalInput;
        moveDirction.Normalize();
        moveDirction.y = 0;
        moveDirction = moveDirction * movementSpeed;

        Vector3 MovementVelocity = moveDirction;
        playerRigidbody.velocity = MovementVelocity;
    }

    private void HandelRotation()
    {
        Vector3 targetDirection = Vector3.zero;

        targetDirection = player.forward * inputManager.verticalInput;
        targetDirection = targetDirection + player.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if(targetDirection == Vector3.zero)
        {
            targetDirection = transform.forward;
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }
}
