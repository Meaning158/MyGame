using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    
    public Camera cam;
    Vector2 mousePos;
    public Rigidbody2D rb;

    

    // Update is called once per frame
    void Update()
    {
            
        mousePos= cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 lookshot = mousePos - rb.position;
            float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
