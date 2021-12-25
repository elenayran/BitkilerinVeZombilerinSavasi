using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldiranlar : MonoBehaviour
{
    //[Range(0f,2f)]
    private float SuankiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody2D rigidbody = gameObject.AddComponent<Rigidbody2D>();
        //rigidbody.isKinematic = true;
        objeninAnimatoru = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * SuankiHiz * Time.deltaTime);
        if (!mevcutHedef)
        {
            objeninAnimatoru.SetBool("SaldiriVarMi", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + collision.name + "trigger gerceklestirilmistir.");
    }
    public void SuankiHiziAyarla(float hiz)
    {
        SuankiHiz = hiz;
    }
    public void ZararVer(float zararMiktari)
    {
        if (mevcutHedef)
        {
            Saglik saglik = mevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAl(zararMiktari);
            }
        }
    }
    public void HedefiBelirle(GameObject hedefimiz)
    {
        mevcutHedef = hedefimiz;
    }
}
