using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patient : MonoBehaviour
{
    public float speed = 10f;
    public RectTransform rectTransform;
    public float maxHorizontal = 600;
    public float minHorizontal = -600;

    public Image Pills;

    public Sprite Patient1;
    public Sprite Patient2;
    public Sprite Patient3;
    

    public Sprite Pill1;
    public Sprite Pill2;
    public Sprite Pill3;
    public Sprite Pill4;
    public Sprite Pill5;
    public Sprite Pill6;
    public Sprite Pill7;
    public Sprite Pill8;
    public Sprite Pill9;
    public Sprite Pill10;

    public int imgNumberCount;
    public int PillNumberCount;



    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Image>().sprite = Patient1;
        Pills.sprite = Pill1;
        rectTransform = GetComponent<RectTransform>();
        Vector2 position = rectTransform.anchoredPosition;

        position.x = minHorizontal;
    }
    void Update()
    {

        Vector2 position = rectTransform.anchoredPosition;

        position.x += speed * Time.deltaTime;

        if (position.x > maxHorizontal)
        {
            position.x = minHorizontal;

            ImageSwap();
            PillSwap();


        }

        rectTransform.anchoredPosition = position;
    }


    void ImageSwap()
    {
        switch (imgNumberCount)
        {
            case 0:
                GetComponent<Image>().sprite = Patient2;
                imgNumberCount++;
                break;
            case 1:
                GetComponent<Image>().sprite = Patient3;
                imgNumberCount++;
                break;
    
        }


       
       
    }
    void PillSwap()
    {
        switch (PillNumberCount)
        {
            case 0:
                Pills.sprite = Pill2;
                PillNumberCount++;
                speed += 50;
                break;
            case 1:
                Pills.sprite = Pill3;
                PillNumberCount++;
                speed += 50;

                break;
            case 2:
                Pills.sprite = Pill4;
                PillNumberCount++;
                speed += 50;

                break;
            case 3:
                Pills.sprite = Pill5;
                PillNumberCount++;
                speed += 50;

                break;
            case 4:
                Pills.sprite = Pill6;
                PillNumberCount++;
                speed += 50;

                break;
            case 5:
                Pills.sprite = Pill7;
                PillNumberCount++;
                speed += 50;

                break;
            case 6:
                Pills.sprite = Pill8;
                PillNumberCount++;
                speed += 50;

                break;
            case 7:
                Pills.sprite = Pill9;
                PillNumberCount++;
                speed += 50;

                break;
            case 8:
                Pills.sprite = Pill10;
                PillNumberCount++;
                speed += 50;

                break;

        }


    }
}
