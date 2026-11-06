using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform respawn;
    public GameObject Ememy;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            transform.position = respawn.position;

        }
    }

}
