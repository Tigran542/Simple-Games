using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{

    public float speed = 5f;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);

        if (Input.GetKeyUp(KeyCode.DownArrow))
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed);

        //if (Input.GetKeyUp(KeyCode.RightArrow))
            //transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);

       // if (Input.GetKeyUp(KeyCode.LeftArrow))
          //  transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    }

}
