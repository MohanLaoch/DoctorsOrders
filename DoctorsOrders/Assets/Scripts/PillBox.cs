using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillBox : MonoBehaviour
{
    private int numberOfPills;

    public GameObject pillBox;

    private ScoreManager scoreManager;

    void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfPills == 1)
        {
            Instantiate(pillBox, new Vector3(0, 5, 0), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pill")
        {
            numberOfPills++;
            scoreManager.pillsChosen.Add(other.gameObject.name);
            scoreManager.CheckPill();
            scoreManager.currentPill++;
            Destroy(other.gameObject);
        }
    }
}

/* Put pills into PillBox
 * PillBox needs to detect what pills have been put in (string/ list)
 * When three pills have been added those pills need to be checked to see if they match what was asked by the doctor 
 */