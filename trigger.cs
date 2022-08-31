using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool rot;
    public GameObject spr_asteroide;

    // Start is called before the first frame update
    void Start()
    {
        rot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rot == true)
        {
            spr_asteroide.gameObject.transform.Rotate(new Vector3(0, 0, 50 * Time.deltaTime));
        }
    }
    void OnTriggerEnter2D(Collider2D outro) 
        {
            if(outro.gameObject.CompareTag("personagem"))
            {
                rot = true;
            }
        }

        void OnTriggerExit2D(Collider2D outro) 
        {
            if(outro.gameObject.CompareTag("personagem"))
            {
                rot = false;
            }
        }
}
