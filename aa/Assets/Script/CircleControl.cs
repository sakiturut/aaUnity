using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject circle;
    public Rigidbody2D circleRigidBody2D;
    void Start()
    {
        circleRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1), (float)0.5);

        if (Input.GetKey(KeyCode.W))
        {
            circle.transform.position += new Vector3(0, (float)0.01, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "circle")
        {
           
            Debug.Log("Circle Collider");
            GameObject obj;
            obj = (GameObject)Instantiate(prefab);
            // child the object to MyShip:
            obj.transform.position = new Vector3((float)-0.77, (float)-0.24, (float)-0.327);
            obj.transform.parent = transform;
        }
    }

}
