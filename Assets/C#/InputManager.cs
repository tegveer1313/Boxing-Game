using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public NewControls controls;
    public Damage damage;
    AnimaterManager animaterManager;

    public Vector2 movementInput;
    public bool leftPunchInput;
    public bool rightPunchInput;
    public bool leftLegInput;
    public bool rightLegInput;
    public bool rollInput;
    public bool blockInput;


    public float verticalInput;
    public float horizontalInput;


    private float moveHorizontal;
    private float moveVertical;
    private bool tran;



    private void Awake()
    {
        animaterManager = GetComponent<AnimaterManager>();
    }

    private void OnEnable()
    {
        if(controls == null)
        {
            controls = new NewControls();

            //Player movement input from input systerm.
            controls.Player.move.performed += i => movementInput = i.ReadValue<Vector2>();
            //Rolling action
            controls.Player.roll.performed += i => rollInput = true;
            controls.Player.roll.canceled += i => rollInput = false;

            //Player action input from input systerm.
            //Hand actions
            controls.PlayerAction.leftPunch.performed += i => leftPunchInput = true;
            controls.PlayerAction.leftPunch.canceled += i => leftPunchInput = false;
            controls.PlayerAction.rightPunch.performed += i => rightPunchInput = true;
            controls.PlayerAction.rightPunch.canceled += i => rightPunchInput = false;
                    //Leg actions
            controls.PlayerAction.leftLeg.performed += i => leftLegInput = true;
            controls.PlayerAction.leftLeg.canceled += i => leftLegInput = false;
            controls.PlayerAction.rightLeg.performed += i => rightLegInput = true;
            controls.PlayerAction.rightLeg.canceled += i => rightLegInput = false;

                    //Block actions
            controls.PlayerAction.block.performed += i => blockInput = true;
            controls.PlayerAction.block.canceled += i => blockInput = false;
        }

        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    public void HandelAllMovement()
    {
        HandelMovementInput();
        Punched();
        Kick();
        Rolled();
        Blocked();
    }

    void HandelMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
        moveHorizontal = horizontalInput;
        moveVertical = Mathf.Clamp01(Mathf.Abs(verticalInput));

        if(moveHorizontal == 0)
        {
            tran = true;
        }
        else if(moveHorizontal != 0)
        {
            tran = false;
        }

        animaterManager.UpdateAnimatorValue(tran, moveHorizontal, moveVertical);
    }

    void Punched()
    {

        if (leftPunchInput || rightPunchInput)
        {
            //Debug.Log("left Punch");
            animaterManager.LeftPunch(leftPunchInput);
            animaterManager.RightPunch(rightPunchInput);
            
        }
        else if(leftPunchInput == false || rightPunchInput == false)
        {
            //Debug.Log("not pressed");
            animaterManager.LeftPunch(leftPunchInput);
            animaterManager.RightPunch(rightPunchInput);
        }
    }

    void Kick()
    {
        if (leftLegInput || rightLegInput)
        {
            //Debug.Log("Kicked");
            animaterManager.LeftKick(leftLegInput);
            animaterManager.RightKick(rightLegInput);

        }
        else if(leftLegInput == false || rightLegInput == false)
        {
            animaterManager.LeftKick(leftLegInput);
            animaterManager.RightKick(rightLegInput);
        }
    }

    void Rolled()
    {
        if (rollInput)
        {
            animaterManager.Roll(rollInput);
        }
        else if(rollInput == false)
        {
            animaterManager.Roll(rollInput);
        }
    }

    void Blocked()
    {
        if (blockInput)
        {
            animaterManager.Block(blockInput);
        }
        else if (blockInput == false)
        {
            animaterManager.Block(blockInput);
        }
    }
}
