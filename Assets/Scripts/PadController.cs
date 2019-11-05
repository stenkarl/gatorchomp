using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadController : MonoBehaviour
{

    public GameObject[] numbers;

    private GameObject current;

    // Start is called before the first frame update
    void Start()
    {
        GenerateNext();
    }

    private void OnMouseDown() {
        Debug.Log("Clicked ");
    }


    private void GenerateNext() {
        float x = transform.position.x;
        current = Instantiate(numbers[Random.Range(0, numbers.Length)], new Vector3(x, 10f, 0f), Quaternion.identity);
    }
}
