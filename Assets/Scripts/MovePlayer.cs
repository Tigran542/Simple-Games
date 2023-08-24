using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 5f, hSpeed = 10f, _thrust = 500f;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(-v, _rb.velocity.y, h));
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
        }
    }
    private void OnCollisionStay(Collision other)
    {
       // Debug.Log("Zoski");
    }
    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Zoski");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
        {
            Debug.Log("ZaLebigu");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
        {
            Debug.Log("ZaZelenskogo");
        }
    }
}
