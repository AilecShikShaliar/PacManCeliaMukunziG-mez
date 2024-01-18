using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public Rigidbody2D rb;
    public float velocidad = 10f;

    float Izquierda;
    float Derecha;
    float offset;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Izquierda = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 0.1f, 0.0f, 0.0f)).x;
        Derecha = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 0.85f, 0.0f, 0.0f)).x;

    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized * velocidad;

        if (transform.position.x < Izquierda - offset)
            transform.position = new Vector2(Derecha + offset, transform.position.y);
        else if (transform.position.x > Derecha + offset)
            transform.position = new Vector2(Izquierda - offset, transform.position.y);

    }
}
