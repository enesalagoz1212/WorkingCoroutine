using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trial : MonoBehaviour
{
    private Coroutine _startMethodCoroutine;
    private IEnumerator StartMethod()
    {
        var timer = 0f;
        while (true)
        {
            timer += Time.deltaTime * 1f;
            if (timer > 2f)
            {
                timer = 0f;
                Debug.Log('a');
            }
            yield return null;
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _startMethodCoroutine = StartCoroutine(StartMethod());
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            StopCoroutine(_startMethodCoroutine);
        }
    }
}
