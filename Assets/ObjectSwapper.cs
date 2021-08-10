using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwapper : MonoBehaviour
{
    public GameObject[] characters = new GameObject[4];
    int arrayCount = 0;

    Vector3 currentPos;
    Vector3 currentVel;

    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.position;

        for (int i = 0; i<characters.Length; i++)
        {
            if (i == 0)
            {
                characters[i].SetActive(true);
            }
            else
                characters[i].SetActive(false);
       
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            currentPos = characters[arrayCount].transform.position;
            currentVel = characters[arrayCount].GetComponent<Rigidbody>().velocity;

            characters[arrayCount].SetActive(false);
            arrayCount++;

            if (arrayCount >= characters.Length)
            {
                arrayCount = 0;
            }

            characters[arrayCount].transform.position = currentPos;
            characters[arrayCount].GetComponent<Rigidbody>().velocity = currentVel;
            characters[arrayCount].SetActive(true);
        }
    }
}
