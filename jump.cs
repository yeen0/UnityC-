using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float forca = 300f;
    public Rigidbody2D Bola;
    public bool pulo = false;
    public int duplo = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(duplo > 0)
        {
            if(Input.GetKeyDown(KeyCode.Space)) {
                Bola.AddForce (new Vector2 (0, forca * Time.deltaTime), ForceMode2D.Impulse);
                duplo -= 1;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D outro)
    {
        if(outro.gameObject.CompareTag("Chao"))
        {
            pulo = true;
            duplo = 2;
        }
    }
    void OnCollisionExit2D(Collision2D outro) 
    {
        if(outro.gameObject.CompareTag("Chao"))
        {
            pulo = false;
        }
    }
}
