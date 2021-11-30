using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrolu : MonoBehaviour
{
    public float SonrakiSahneninYuklenmeSuresi;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "0.MenudenOncekiSahne") 
        {
            Invoke("SonrakiSahne", SonrakiSahneninYuklenmeSuresi);
        }
        
    }
    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OyundanCikis()
    {
        Application.Quit();
    }

    public void IsimleSahneCagirma(string SahneIsmi)
    {
        SceneManager.LoadScene(SahneIsmi);
    }
    public void IndexleSahneCagirma(int sahneIndexi)
    {
        SceneManager.LoadScene(sahneIndexi);
    }
}
