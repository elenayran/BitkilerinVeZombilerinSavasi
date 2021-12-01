using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public static void SeviyeninKilidi(int seviye)
    {
        if (seviye < SceneManager.sceneCountInBuildSettings)
        {

                                //seviye_acik_0
                                // seviye_acik_1 1 acik artik
            PlayerPrefs.SetInt(SEVIYE_ANAHTARI + seviye.ToString(), 1);
        }
        else
        {
            Debug.LogError("Oyunda Olmayan bir sahne acilamaz.");
        }
    }

// seviyenin kilidinin acik olup olmadigini kontrol eden fonk.
    public static bool SeviyeAcikMi(int seviye)
    {
        int seviyeDegeri = PlayerPrefs.GetInt(SEVIYE_ANAHTARI + seviye.ToString());
        bool SeviyeAcikMi = (seviyeDegeri == 1);
        if (seviye < SceneManager.sceneCountInBuildSettings)
        {
            return SeviyeAcikMi;
        }
        else
        {
            Debug.LogError("Oyunda olmayan seviyenin kilidini sorgulayamazsin.");
            return false;
        }
    }

    // zorlugu ayarlayacak bir fonksiyon
    public static void ZorluguAyarla(float zorluk)
    {
        if (zorluk >=0f && zorluk<=1)
        {
            PlayerPrefs.SetFloat(ZORLUK_ANAHTARI, zorluk);
        }
        else
        {
            Debug.LogError("zorluk seviyesi [0,1] degeri arasinda olmalidir");
        }
    }

    // zorlugun degerini gösterecek bir fonksiyon yazilacak
    public static float ZorluguAl()
    {
        return PlayerPrefs.GetFloat(ZORLUK_ANAHTARI);
    }
}
