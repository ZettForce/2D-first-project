using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalmove;
    public Rigidbody2D ridigbody;
    public float jump = 3;

    bool voltear = true;
    SpriteRenderer Render;
    void Start()
    {
        ridigbody = GetComponent<Rigidbody2D>();
        Render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal");
        ridigbody.velocity = new Vector2(horizontalmove, ridigbody.velocity.y);
        if (Input.GetKey(KeyCode.Space))
        {
            ridigbody.velocity = new Vector2(horizontalmove, jump);
        }
    }

    void FixedUpdate()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal");
        ridigbody.velocity = new Vector2(horizontalmove, ridigbody.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            ridigbody.velocity = new Vector2(horizontalmove, jump);
        }

        if (horizontalmove > 0 && !voltear)
        {
            Voltear();
        }
        else if (horizontalmove < 0 && voltear)
        {
            Voltear();
        }

        void Voltear()
        {
            voltear = !voltear;
            Render.flipX = !Render.flipX;
        }
    }
}
