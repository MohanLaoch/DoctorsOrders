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

    public Sprite Patient1;
    public Sprite Patient2;
    public Sprite Patient3;
    public Sprite Patient4;
    public Sprite Patient5;

    public int imgNumberCount;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = Patient1;
        rectTransform = GetComponent<RectTransform>();
        Vector2 position = rectTransform.anchoredPosition;

        position.x = minHorizontal;
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
    void Update()
    {

        Vector2 position = rectTransform.anchoredPosition;

        position.x += speed * Time.deltaTime;

        if (position.x > maxHorizontal)
        {
            position.x = minHorizontal;

            ImageSwap();
            

        }

        rectTransform.anchoredPosition = position;
    }
}
