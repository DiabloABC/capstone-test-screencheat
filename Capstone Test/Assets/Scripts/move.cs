using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb2d_player;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        rb2d_player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        if (name == "Player 1")
        {
            rb2d_player.velocity = new Vector3(0, yAxis, 0);
        }
        
        if (name == "Player 2")
        {
            rb2d_player.velocity = new Vector2(Input.GetAxisRaw("Horizontal_2"), Input.GetAxisRaw("Vertical_2"));
        }

        /*if (Input.GetButtonDown("a"))
        {
            y++;
        }

        if (Input.GetButtonDown("d"))
        {
            y--;
        }*/

        y = xAxis * 3;
        Rotate(y);
    }

    void Rotate(float y)
    {
        //transform.Rotate(new Vector3(0f, 0f, y));
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z += Input.GetAxisRaw("Horizontal") * -2f;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        //Vector3 pos = 
    }
}
