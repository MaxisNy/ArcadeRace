using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    private float rotationAngle = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 movement = new Vector3(0,0,0);

        if (Input.GetKey(KeyCode.W)){
            movement += new Vector3(0,1,0);
        } else if (Input.GetKey(KeyCode.S)){
            movement += new Vector3(0,-1,0);
        }

        if (Input.GetKey(KeyCode.A)){
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0.0f, 0.0f, rotationAngle), 40.0f * Time.deltaTime);
            movement += new Vector3(-1,0,0);
        } else if (Input.GetKey(KeyCode.D)){
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0.0f, 0.0f, -rotationAngle), 40.0f * Time.deltaTime);
            movement += new Vector3(1,0,0);
        } else {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.identity, 40.0f * Time.deltaTime);
        }

        transform.position += movement * Time.deltaTime * speed;
    }
}
