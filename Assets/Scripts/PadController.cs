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

        GenerateNext();
        GameManager manager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Animator gator = GameObject.Find("Gator1").GetComponent<Animator>();

        Debug.Log("gator " + gator);

        gator.SetTrigger("GatorChompActivate");
    }


    private void GenerateNext() {
        float x = transform.position.x;
        current = Instantiate(numbers[Random.Range(0, numbers.Length)], new Vector3(x, 10f, 0f), Quaternion.identity);
    }
}
