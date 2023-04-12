using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineHomeworkTest : MonoBehaviour
{
    public GameObject cube;
    private float number;
    public float maxNumber;
   

    private void Start()
    {
        StartCoroutine(RandomCube());
    }
   


    public IEnumerator RandomCube()
    {

        while (number < maxNumber)
        {
            Vector3 position = new Vector3(Random.Range(-10, 15), Random.Range(10, 45), Random.Range(-5, 25));
            Instantiate(cube, position, transform.rotation);
            yield return new WaitForSeconds(2f);
            number++;

            yield return null;
        }
        Debug.Log($"Toplam {maxNumber} adet prefab oluþturuldu");


    }
}
