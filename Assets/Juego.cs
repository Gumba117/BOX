using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public List<Caja> cajas;
    public Caja caja;
    public static int cajasVivas;
    public int numCajas;

    void Start()
    {
        cajas.Clear();
        numCajas = 1;
        cajasVivas = 0;
        DarIdCajas();

    }
    void Update()
    {
        ReapareceCajas();

        SpawnMasCajas();



    }
    void DarIdCajas()
    {
        for (int i = 0; i < cajas.Count; i++)
        {
            cajas[i].id = i;
        }
        cajasVivas = 0;

    }
    void ReapareceCajas()
    {
        if (cajasVivas == cajas.Count)
        {
            for (int i = 0; i < cajas.Count; i++)
            {
                cajas[i].gameObject.SetActive(true);
                cajasVivas = 0;
                
            }
            numCajas++;
        }
    }
    void SpawnMasCajas()
    {
        if (cajas.Count < numCajas)
        {
            for (int i = 0; i < numCajas - cajas.Count; i++)
            {
                Caja a = Instantiate(caja);
                cajas.Add(a);
                DarIdCajas();
                // Debug.Log("I es: "+ i + "Resta es: " + (numCajas-cajas.Count));
            }
        }
    }
}
