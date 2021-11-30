using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuAyarlari : MonoBehaviour
{
    const string ANA_SES_ANAHTARI = "ana_ses";
    const string ZORLUK_ANAHTARI = "zorluk";
    const string SEVIYE_ANAHTARI = "seviye_acik_";

    public static void AnaSesiAyarla(float ses)
    {
        if (ses >= 0 && ses <= 1)
        {
            PlayerPrefs.SetFloat(ANA_SES_ANAHTARI, ses);

        }
        else
        {
            Debug.LogError("[0,1]Aralik Disinda Bir Deger Giremezsiniz.");
        }
       
    }
    public static float AnaSesAl()
    {
        return PlayerPrefs.GetFloat(ANA_SES_ANAHTARI);
    }



}
