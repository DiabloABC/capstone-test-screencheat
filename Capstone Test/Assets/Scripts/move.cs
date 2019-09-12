using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb2d_player;

    // Start is called before the first frame update
    void Start()
    {
        rb2d_player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "Player 1")
        {
            rb2d_player.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        
        if (name == "Player 2")
        {
            rb2d_player.velocity = new Vector2(Input.GetAxisRaw("Horizontal_2"), Input.GetAxisRaw("Vertical_2"));
        }
    }
}
