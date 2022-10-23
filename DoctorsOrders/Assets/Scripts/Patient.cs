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
    public Sprite Patient4;
    public Sprite Patient5;

    public int imgNumberCount;
    public int PillNumberCount;



    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Image>().sprite = Patient1;
        Pills.sprite = Patient3;
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
            case 2:
                GetComponent<Image>().sprite = Patient4;
                imgNumberCount++;
                break;
            case 3:
                GetComponent<Image>().sprite = Patient5;
                imgNumberCount++;
                break;

        }


       
       
    }
    void PillSwap()
    {
        switch (PillNumberCount)
        {
            case 0:
                Pills.sprite = Patient3;
                PillNumberCount++;
                break;
            case 1:
                Pills.sprite = Patient2;
                PillNumberCount++;
                break;
            case 2:
                Pills.sprite = Patient5;
                PillNumberCount++;
                break;
            case 3:
                Pills.sprite = Patient3;
                PillNumberCount++;
                break;

        }


    }
}
