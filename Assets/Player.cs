using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float velocity;
    public Collider2D col;
    public float limitesy;
    public float limitesx;

    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized * Time.deltaTime * velocity);
        Limites();

        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift))
        {
            velocity = 10;
        }
        else
        {
            velocity = 5;
        }
    }
    public void Limites()
    {
        Vector3 Posicion = transform.position;
        Posicion.y = Mathf.Clamp(Posicion.y, -limitesy, limitesy);
        Posicion.x = Mathf.Clamp(Posicion.x, -limitesx, limitesx);
        transform.position = Posicion;
    }
}
