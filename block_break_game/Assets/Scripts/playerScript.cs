using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float barSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > -4.7)
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.position += Vector3.left * barSpeed * Time.deltaTime;
            }
        }
        if(this.transform.position.x < 4.7)
        {
            if(Input.GetKey(KeyCode.RightArrow)){
                this.transform.position += Vector3.right * barSpeed * Time.deltaTime;
            }
        }
    }
}
