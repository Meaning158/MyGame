using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    public int AttackDamage = 40;
    public AudioClip attack;  
    private Animator animator;

    private void Awake() => animator = GetComponent<Animator>();

    private void Update()
    {
        var moveVector = Camera.main.ScreenToViewportPoint(Input.mousePosition) + new Vector3(-.5f, -.5f);
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && moveVector.x > 0)
        {
            animator.SetTrigger("AttackRight");
            var hitEnamies = Physics2D.OverlapCapsuleAll(new Vector3(0.7f, -0.05f ,0) + transform.position, 
                new Vector2 (0.7f , 1f) ,CapsuleDirection2D.Vertical , attackRange, enemyLayers);
            GetComponent<AudioSource>().PlayOneShot(attack);
            foreach (Collider2D enemy in hitEnamies) enemy.GetComponent<enemy>().TakeDamage(AttackDamage);
            
        }
        else if(Input.GetKeyDown(KeyCode.Mouse0) && moveVector.x < 0)
        {
            animator.SetTrigger("AttackLeft");
            var hitEnamies = Physics2D.OverlapCapsuleAll(new Vector3(-0.7f, -0.05f, 0) + transform.position, 
                new Vector2(0.7f, 1f), CapsuleDirection2D.Vertical, attackRange, enemyLayers);
            GetComponent<AudioSource>().PlayOneShot(attack);
            foreach (Collider2D enemy in hitEnamies) enemy.GetComponent<enemy>().TakeDamage(AttackDamage);
        }
    }
}
