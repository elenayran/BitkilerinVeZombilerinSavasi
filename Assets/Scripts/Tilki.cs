using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Saldiranlar))] // saldiranlar scripti žart!!!!!!
public class Tilki : MonoBehaviour
{
    private Animator tilkiAnimator;
    private Saldiranlar saldiranObje;
    // Start is called before the first frame update
    void Start()
    {
        tilkiAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject tilkininEtkiležimeGirdigiObje = collision.gameObject;

        if (!tilkininEtkiležimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else if (tilkininEtkiležimeGirdigiObje.GetComponent<Tas>())
        {
            tilkiAnimator.SetTrigger("ZiplamaIslemi");

        }
        else
        {
            tilkiAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(tilkininEtkiležimeGirdigiObje);
        }
        
    }
}
