using UnityEngine;
using UnityEngine.PlayerLoop;

public class Basics : MonoBehaviour
{

    public GameObject[] objs = new GameObject[3];
    public Transform pos;
    public BoxCollider Box;
    public Light light1;

    public Transform[] transforms = new Transform[3];

    public float speed = 5.0f;
    public float Rotatespeed = 10f;
    private void Start()
    {
        // obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
        // pos.position = new Vector3(10, 5, 7);
        // light1.intensity = 0.5f;

        // for (int i = 0; i < objs.Length; i++)
           // objs[i].SetActive(false);
    }

    private void Update()
    {
        for (int i = 0; i < transforms.Length; i++)
        {
            transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transforms[i].Rotate(new Vector3(-1, 0, 0) * Rotatespeed * Time.deltaTime);

            float posX = transforms[i].position.x;
            if (posX < -10f && transforms[1].gameObject.name == "Cube")
                Destroy(transforms[1].gameObject);
        }

    }
}
