using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControllerManager : MonoBehaviour
{

    public static ControllerManager controllerManager = null;

    MeshSwapper meshSwapper = new MeshSwapper();
    public bool currentGender = true;
    public GameObject[] bodyParts;
    public int arrayCount = 0;

    public Button generateButton;

    private void Awake()
    {
        if (controllerManager == null)
        {
            controllerManager = this;
        } else if (controllerManager != null)
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        FaceOffsets();
    }

    void FaceOffsets()
    {

        if (currentGender)
        {
            bodyParts[0].transform.position = new Vector3(0, 0.7f, -0.02f);
            bodyParts[1].transform.position = new Vector3(0, 0, 0);
            bodyParts[2].transform.position = new Vector3(-1, 0, -1);
            bodyParts[3].transform.position = new Vector3(0f, 0f, -0.05f);
            bodyParts[4].transform.position = new Vector3(-1.2f, 0.1f, -0.05f);
            bodyParts[5].transform.position = new Vector3();
            bodyParts[6].transform.position = new Vector3();
            bodyParts[7].transform.position = new Vector3();
            bodyParts[8].transform.position = new Vector3();
            bodyParts[9].transform.position = new Vector3();
        }
        else
        {
            bodyParts[0].transform.position = new Vector3(0, -0.8f, -0.01f);
            bodyParts[1].transform.position = new Vector3(0, 0, 0);
            bodyParts[2].transform.position = new Vector3(0.05f, 0.04f, -0.32f);
            bodyParts[3].transform.position = new Vector3(0, -0.01f, -0.01f);
            bodyParts[4].transform.position = new Vector3();
            bodyParts[5].transform.position = new Vector3();
            bodyParts[6].transform.position = new Vector3();
            bodyParts[7].transform.position = new Vector3();
            bodyParts[8].transform.position = new Vector3();
            bodyParts[9].transform.position = new Vector3();
        }
    }

    public void SwitchGender()
    {
       currentGender = !currentGender;
    }

    public void SpriteSwapper(GameObject gameObject, Sprite[] sprites, int index)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
        //Sprite[] male = bodyParts[0].GetComponent<MeshSwapper>().males;
        int male = bodyParts[0].GetComponent<MeshSwapper>().males.Length;
    }

}
