using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillBox : MonoBehaviour
{
    public List<string> pillsInBox = new List<string>();

    private int numberOfPills;
    public int pillsNeeded;

    public GameObject pillBox;

    private ScoreManager scoreManager;

    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfPills == pillsNeeded)
        {
            Instantiate(pillBox, new Vector3(7, 5, -5), Quaternion.identity);

            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pill")
        {
            numberOfPills++;
            pillsInBox.Add(other.gameObject.name);
            Destroy(other.gameObject);
        }
    }
}

/* Put pills into PillBox
 * PillBox needs to detect what pills have been put in (string/ list)
 * When three pills have been added those pills need to be checked to see if they match what was asked by the doctor 
 */