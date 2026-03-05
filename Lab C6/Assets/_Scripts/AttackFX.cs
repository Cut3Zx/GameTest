using UnityEngine;

public class AttackFX : MonoBehaviour
{
    private Animator animator;

    private static readonly int SpeedHash = Animator.StringToHash("Speed");
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    private float currentSpeed = 0f;
    public GameObject attackFX;

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
            TriggerFX();
        }
    }
    public void TriggerFX()
    {
        if (attackFX != null)
        {
            attackFX.SetActive(true);
            Invoke(nameof(DisableFX), 0.3f);
        }
    }
    void DisableFX()
    {
        attackFX.SetActive(false);
    }
}