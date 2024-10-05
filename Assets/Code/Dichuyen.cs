using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dichuyen : MonoBehaviour

{
    public FixedJoystick join;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        move.x = join.Horizontal;
        move.y = join.Vertical;

        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3 (0f, 0f, -zAxis);

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
