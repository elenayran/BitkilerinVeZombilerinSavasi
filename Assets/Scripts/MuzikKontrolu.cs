using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikKontrolu : MonoBehaviour
{
    static MuzikKontrolu muzikOynaticisi;   // statik bizim ram de yer  bulmamýzý saglýyor

    private void Awake()
    {
        if (muzikOynaticisi != null) //ramdeki muzik oynaticisi bos degil ise yaratmak istedigimiz muzik objesi kendini yok edecek
        {
            Destroy(gameObject);

        }
        else //ramde bulunan muzikoynaticisi obje bossa thise yani muzik kontrolu objesinde tutabilicek
        {
            muzikOynaticisi = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
