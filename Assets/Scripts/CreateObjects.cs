using UnityEngine;
using System;
using System.Collections;

public class CreateObjects : MonoBehaviour
{

    public GameObject[] obj;
    private void Start()
    {
        // Invoke("Create", 2f);
        StartCoroutine(Create3dObjects());
    }

    private void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            // GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
            //  newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));

        }
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, obj.Length);
    }

    private IEnumerator Create3dObjects()
    {
        yield return new WaitForSeconds(3f);
        Create();
        Debug.Log("Lebiga");
    }
}
