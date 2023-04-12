using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineHomework : MonoBehaviour
{
    public float number;
    public float timer = 0f;
    private void Start()
    {      
        StartCoroutine(Move());
    }
   public IEnumerator Move()
    {
        number = 10;
        while (number<=13)
        {
            number += Time.deltaTime * 0.5f;
           
            yield return null;
            Debug.Log($"Number: {Time.time}");
        }
        yield return new WaitForSeconds(2f);
        transform.position = new Vector3(0f, 0f, 10f);
        while (timer<=5f)
        {
           
            timer += Time.deltaTime * 1f;
            transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime*2f;
            yield return null;
        }
        Debug.Log("Hareket Bitmiþtir");


    } 

}
