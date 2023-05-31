using Unity.VisualScripting;
using UnityEngine;

public class hero1 : MonoBehaviour
{
    public float speed = 0.5f;
    public Transform fire;

    private Animator anim;
    private Rigidbody2D rb;
    

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        rb.MovePosition(rb.position + speed * Time.deltaTime * new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Find("Firepoint").localPosition = new(.405f * Input.GetAxis("Horizontal") < 0 ? -0.5f : 0.5f, 0, 0);
            
        }

        anim.SetFloat("speed", Input.GetAxis("Horizontal"));    
        anim.SetBool("forth", Input.GetKey(KeyCode.W));
        anim.SetBool("back", Input.GetKey(KeyCode.S));
    }
}