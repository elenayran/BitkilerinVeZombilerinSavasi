using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Ses Baslangic Degeri:" + OyuncuAyarlari.AnaSesAl());
        OyuncuAyarlari.AnaSesiAyarla(0.2f);
        //Debug.Log("Ses Ayarlandiktan Sonraki Deger:" + OyuncuAyarlari.AnaSesAl());

        //Debug.Log(OyuncuAyarlari.SeviyeAcikMi(2));
        //OyuncuAyarlari.SeviyeninKilidi(2);
        //Debug.Log(OyuncuAyarlari.SeviyeAcikMi(2));

        //Debug.Log(OyuncuAyarlari.ZorluguAl());
        //OyuncuAyarlari.ZorluguAyarla(3f);
        //Debug.Log(OyuncuAyarlari.ZorluguAl());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
