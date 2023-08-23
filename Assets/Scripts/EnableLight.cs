using UnityEngine;

public class EnableLight : MonoBehaviour
{

    public Light mainlig;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            mainlig.enabled = !mainlig.enabled;
    }

}
