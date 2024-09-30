using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float velocidad;
    [SerializeField] private float fuerzaSalto;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float direccion = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }

        Mover(direccion);
    }

    private void Mover(float direccion)
    {
        rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);
    }

    private void Saltar()
    {
        rb.AddForce(new Vector2(0, fuerzaSalto));
    }
}
