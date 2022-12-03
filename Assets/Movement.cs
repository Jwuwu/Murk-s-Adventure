using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal"), J = Input.GetAxis("Jump");
        Vector2 V = new Vector2(H, J);
        GetComponent<Rigidbody2D>().velocity = V;
    }
}
