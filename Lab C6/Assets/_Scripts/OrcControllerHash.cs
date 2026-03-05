using UnityEngine;

public class OrcControllerHash : MonoBehaviour
{
    private Animator animator;

    private static readonly int SpeedHash = Animator.StringToHash("Speed");
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    private float currentSpeed = 0f;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
        Attack();
    }

    void Movement()
    {
        float moveInput = Mathf.Abs(Input.GetAxis("Horizontal"));
        currentSpeed = moveInput;
        animator.SetFloat(SpeedHash, currentSpeed);
        
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(AttackHash);
        }
    }
}