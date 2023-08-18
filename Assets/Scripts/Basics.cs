using UnityEngine;
using UnityEngine.PlayerLoop;

public class Basics : MonoBehaviour
{

    public GameObject obj;
    public Transform pos;
    public BoxCollider Box;

    private void Start()
    {
        // obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
        pos.position = new Vector3(10, 5, 7);
    }
}
