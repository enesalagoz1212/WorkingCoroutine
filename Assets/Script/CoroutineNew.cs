using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineNew : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
   private IEnumerator Start()
    {
        Debug.Log("Start Worked");
        var target = (a + b) * 2;
        c = a + b;
        while (c<=target)
        {
            a += Time.deltaTime * 1f;
            b += Time.deltaTime * 1f;
            c = a + b;
            Debug.Log($"c: {c}");

            yield return null;

        }
        Debug.Log($"Final c: {c}");
        yield return null;
        StartCoroutine(CoroutineOne());
    }

  private IEnumerator CoroutineOne()
    {
        Debug.Log("Coroutine Calýþtý.");
        yield return null;

    }
    void Update()
    {
        
    }
}
