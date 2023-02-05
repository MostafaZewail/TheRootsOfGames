using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MarioEnemy : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private Vector3 direction;
   [SerializeField] private float speed = 2;

    

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        this.direction = new Vector3(0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
        Vector3 noramal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, noramal);
    }
}
