using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineNewOne : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(StartMethod());
    }
    IEnumerator StartMethod()
    {
        Debug.Log("aa");
        yield return StartCoroutine(CoroutineOne());
        Debug.Log("bb");
        yield return StartCoroutine(CoroutineTwo());
        Debug.Log("cc");

    }

    IEnumerator CoroutineOne()
    {
        var timer = 0f;
        while (timer <= 4f)
        {
            timer += Time.deltaTime * 1f;
            yield return null;
        }
        yield return new WaitForSeconds(4f);
        Debug.Log($"CoroutineOne: {Time.time}");
    }
    IEnumerator CoroutineTwo()
    {
        var timer = 0f;
        while (timer <= 8f)
        {
            timer += Time.deltaTime * 1f;
            yield return null;
        }
        Debug.Log($"CoroutineTwo: {Time.time}");
    }
   
}
