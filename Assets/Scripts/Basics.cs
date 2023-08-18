using UnityEngine;
using UnityEngine.PlayerLoop;

public class Basics : MonoBehaviour
{

    public GameObject[] objs = new GameObject[3];
    public Transform pos;
    public BoxCollider Box;
    public Light light1;


    private void Start()
    {
        // obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
        pos.position = new Vector3(10, 5, 7);
        light1.intensity = 0.5f;
    }
}
