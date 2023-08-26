using UnityEngine;
using System;
using System.Collections;

public class CreateObjects : MonoBehaviour
{

    public GameObject[] obj;
    private void Update()
    {
        // Invoke("Create", 2f);
        if(Input.GetKeyUp(KeyCode.P))
         StartCoroutine(Create3dObjects(2f));
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

    private IEnumerator Create3dObjects(float wait)
    {
        while (true)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }
}
