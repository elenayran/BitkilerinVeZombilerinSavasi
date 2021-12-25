using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Saldiranlar))] // saldiranlar scripti �art!!!!!!
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
        GameObject tilkininEtkile�imeGirdigiObje = collision.gameObject;

        if (!tilkininEtkile�imeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else if (tilkininEtkile�imeGirdigiObje.GetComponent<Tas>())
        {
            tilkiAnimator.SetTrigger("ZiplamaIslemi");

        }
        else
        {
            tilkiAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(tilkininEtkile�imeGirdigiObje);
        }
        
    }
}
