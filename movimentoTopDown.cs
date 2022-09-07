using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoTopDown : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePos;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação
        movement.x = Input.GetAxisRaw("hrz");
        movement.y = Input.GetAxisRaw("vrt");

        // Posição do Mouse 
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);

        Vector2 lookdir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}
