using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeshSwapper : MonoBehaviour
{

    public Sprite[] currentSprite;
    public Sprite[] males = new Sprite[4];
    public Sprite[] females = new Sprite[4];
    public Button generateButton;

    void Start()
    {
        Button btn = generateButton.GetComponent<Button>();
        btn.onClick.AddListener(Generate);
    }

    void Update()
    {
        switch (ControllerManager.controllerManager.currentGender)
        {
            case true:
                currentSprite = males;
                break;
            case false:
                currentSprite = females;
                break;
            default:
                Debug.LogWarning("Unknown gender");
                break;
        }

    }

    public void Generate()
    {
        try
        {
            ControllerManager.controllerManager.arrayCount++;

            if (ControllerManager.controllerManager.arrayCount >= males.Length || ControllerManager.controllerManager.arrayCount >= females.Length)
            {
                ControllerManager.controllerManager.arrayCount = 0;
            }

            GetComponent<SpriteRenderer>().sprite = currentSprite[(int)UnityEngine.Random.Range(0, (float)currentSprite.Length)];
        }
        catch (Exception e)
        {
            Debug.Log("You need to initialize first: " + e);
        }

    }

}
