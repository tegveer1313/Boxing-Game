using UnityEngine;

public class AnimaterManager : MonoBehaviour
{
    Animator animator;
    //int horizontal;
    int vertical;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        //horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }


    public void UpdateAnimatorValue(bool tran, float horizontalMovement, float verticalMovement)
    {
        animator.SetBool("Tran", tran);
        animator.SetFloat("Horizontal", horizontalMovement);
        animator.SetFloat(vertical, verticalMovement, 0.1f, Time.deltaTime);
    }

    public void LeftPunch(bool leftPunchPressed)
    {
        animator.SetBool("left", leftPunchPressed);
    }

    public void RightPunch(bool leftPunchPressed)
    {
        animator.SetBool("right", leftPunchPressed);
    }

    public void LeftKick(bool leftLegPressed)
    {
        animator.SetBool("leftLeg", leftLegPressed);
    }

    public void RightKick(bool rightLegPressed)
    {
        animator.SetBool("rightLeg", rightLegPressed);
    }

    public void Roll(bool rollPressed)
    {
        animator.SetBool("roll", rollPressed);
    }

    public void Block(bool blockPressed)
    {
        animator.SetBool("block", blockPressed);
    }
}
