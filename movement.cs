using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // private float vel = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.Translate (new Vector3 (vel * Time.deltaTime, 0, 0));
        // }
        // else if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.Translate (new Vector3 ((-1 * vel) * Time.deltaTime, 0, 0));
        // }
        // Usa-se o Vector3 porque se trabalha com os eixos X, Y, e Z.
        // transform.Translate (new Vector3 (0.1f, 0, 0)); Movimento
        // transform.Rotate (new Vector3()); Rotação
        // transform.localScale += new Vector3(0.1f, 0.1f, 0); Escalonamento
        float hrt = Input.GetAxis("hrz");
        transform.Translate (new Vector3(hrt * Time.deltaTime, 0, 0));
        float vrt = Input.GetAxis("vrt");
        transform.Translate (new Vector3(0,vrt * Time.deltaTime, 0));

    }
}
