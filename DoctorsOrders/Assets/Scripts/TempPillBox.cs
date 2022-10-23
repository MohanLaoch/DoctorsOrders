using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPillBox : MonoBehaviour
{
    private int based = 0;
    public GameObject PillBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (based == 3)
        {
            Instantiate(PillBox, new Vector3(7, 5, -5), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pill")
        {
            based++;
            Destroy(other.gameObject);
        }
    }
}
