using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
   
    void Start()
    {
        RandomTest();
    }

    void Update()
    {
        
    }
    void RandomTest()
    {
        int random = Random.Range(1, 5);
        switch (random)
        {
            case 1:
                Debug.Log($"Sayýnýz : {random}");
                break;
            case 2:
                Debug.Log($"Sayýnýz : {random}");
                break;
            case 3:
                Debug.Log($"Sayýnýz : {random}");
                break;
            case 4:
                Debug.Log($"Sayýnýz : {random}");
                break;

            default:
                break;
        }
    }
}
