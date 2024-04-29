using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Caja : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public SpriteRenderer spriteRenderer;
    public int id;
    public float limitesy;
    public float limitesx;

    private void Awake()
    {
        textMeshPro = GetComponentInChildren<TextMeshPro>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //collider = GetComponent<Collider2D>();

    }
    private void Start()
    {
        Aleatorio();
    }
    private void Update()
    {
        textMeshPro.text = id.ToShortString();
        
    }
    private void OnBecameVisible()
    {
        Aleatorio();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null && Juego.cajasVivas==id)
        {
            gameObject.SetActive(false);
            Juego.cajasVivas++;
        }
    }
    
    void Aleatorio()
    {
        Color a = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        transform.position = new Vector2(Random.Range(-limitesx, limitesx), Random.Range(-limitesy, limitesy));
        spriteRenderer.color = a;
        textMeshPro.color = new Color(a.r*2, a.g*2, a.b*2, 1);

    }
}
