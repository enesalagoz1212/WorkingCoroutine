using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(Move());
    }

    void Update()
    {
        
    }
    public float number;
    public IEnumerator Move()
    {
      

        yield return new WaitForSeconds(2f);
       
        while (number<=25f)
        {
            number += Time.deltaTime * 2f;
            yield return null;

        }
        yield return new WaitForSeconds(3f);
        float timer = 0f;
        while (timer<=5f)
        {
          
            timer += Time.deltaTime;
            transform.position += new Vector3(0f, 0f, 1f)*Time.deltaTime*2f;
           
            yield return null;
        }
        Debug.Log("Bitti");
    }
    
}
