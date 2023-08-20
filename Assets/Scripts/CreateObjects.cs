using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public GameObject[] obj;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            // GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
            //  newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));

        }
    }

    private int RandomNumber()
    {
        return Random.Range(0, obj.Length);
    }
}
