using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutinex : MonoBehaviour
{
    //private void Start()
    //{
    //    Debug.Log("Start baþlangýç");

    //    //StartCoroutine( BallCoroutine() );
    //    StartCoroutine(Move());

    //    Debug.Log("Start bitiþ");
    //}
    //public IEnumerator BallCoroutine()
    //{
    //    Debug.Log("Ýlk frame");
    //    yield return null; // 1frame bekle
    //    Debug.Log("Ýkinci frame");
    //}


    //public IEnumerator BallCoroutine()
    //{
    //    Debug.Log("Zaman: " + Time.time);
    //    yield return new WaitForSeconds(2f);  // 2 sn bekle
    //    Debug.Log("Zaman: " + Time.time);
    //}


    //public IEnumerator Move()
    //{
    //    float hareketSuresi = 3f;
    //    float gecenSure = 0f;
    //    Vector3 mevcutKonum = transform.position;
    //    Vector3 hedefKonum = new Vector3(10, 10, 10);

    //    while (gecenSure<hareketSuresi)
    //    {
    //        gecenSure += Time.deltaTime;
    //        transform.position = Vector3.Lerp(mevcutKonum, hedefKonum, gecenSure / hareketSuresi);
    //        yield return null;
    //    }
    //    transform.position = hedefKonum;
    //}
    //private void Start()
    //{
    //    GetComponent<Renderer>().material.color = Color.green;
    //    StartCoroutine(BallCoroutine());

    //}

    //public IEnumerator BallCoroutine()
    //{
    //    float timer = 0f;
    //    while (timer<=5)
    //    {
    //        timer += Time.deltaTime * 1f;
    //        Debug.Log("Timer: " + timer);
    //    }
    //    yield return null;

    //}

    //private void Start()
    //{
    //    transform.position = new Vector3(0, 0, 0);
    //    StartCoroutine(Move());
    //}

    //public IEnumerator Move()
    //{
    //    var timer = 0f;

    //    while (timer <= 10f)
    //    {

    //        transform.position += new Vector3(0f, 0f, 1f)*Time.deltaTime*2f;
    //        timer += Time.deltaTime;
    //        yield return null;

    //    }
    //    transform.position = new Vector3(0f, 0f, 20);
    //    Debug.Log($"Timer: {timer}");

    //for (var i = 0; i < 11; i++)
    //{
    //    transform.position += new Vector3(0, 0, 1);
    //    yield return null;
    //}

    //}
    
  
   
}
