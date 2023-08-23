using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 5f;

    private void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        // transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);

        //if (Input.GetKey(KeyCode.DownArrow))
        //  transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed);

        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * v);

        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * h);

       // if (Input.GetKey(KeyCode.Space))
        // transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }

}
