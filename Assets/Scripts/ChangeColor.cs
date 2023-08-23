using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    private MeshRenderer meshr;

    private void Awake()
    {
        meshr = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            meshr.material.color = Color.blue;

        if (Input.GetKeyDown(KeyCode.R))
            meshr.material.color = Color.red;

        if (Input.GetKeyDown(KeyCode.G))
            meshr.material.color = Color.green;
    }

}
