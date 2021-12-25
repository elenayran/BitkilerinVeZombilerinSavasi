using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kertenkele : MonoBehaviour
{
    private Animator kertenkeleAnimator;
    private Saldiranlar saldiranObje;
    // Start is called before the first frame update
    void Start()
    {
        kertenkeleAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject kertenkeleninEtkileþimeGirdigiObje = collision.gameObject;

        if (!kertenkeleninEtkileþimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else
        {
            kertenkeleAnimator.SetBool("SaldiriVarMi", true);
            saldiranObje.HedefiBelirle(kertenkeleninEtkileþimeGirdigiObje);
        }

    }
}
