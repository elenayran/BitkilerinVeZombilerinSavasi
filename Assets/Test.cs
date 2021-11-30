using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ses Baslangic Degeri:"+OyuncuAyarlari.AnaSesAl());
        OyuncuAyarlari.AnaSesiAyarla(0.5f);
        Debug.Log("Ses Ayarlandiktan Sonraki Deger:"+OyuncuAyarlari.AnaSesAl());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
