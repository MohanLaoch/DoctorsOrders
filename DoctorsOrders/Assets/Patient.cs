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

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = rectTransform.anchoredPosition;

        position.x += speed * Time.deltaTime;

        if (position.x > maxHorizontal)
        {
            position.x = minHorizontal;
        }

        rectTransform.anchoredPosition = position;
    }
}
