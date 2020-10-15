using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // public float barSpeed = 1.0f;
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    private Vector3 playerPos;
    public float barSpeed = 1.0f;
    Vector3 preMousePos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            preMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosDiff = Input.mousePosition - preMousePos;
            preMousePos = Input.mousePosition;
            Vector3 newPos = this.gameObject.transform.position + new Vector3(mousePosDiff.x / Screen.width, 0, 0 / Screen.height) * barSpeed;
            this.transform.position = newPos;
            if(this.transform.position.x < -4.7f)
            {
                Vector3 leftLimitPos = this.transform.position;
                leftLimitPos.x = -4.6f;//初期値右端
                this.transform.position = leftLimitPos;
            } 
            else if(this.transform.position.x > 4.7f)
            {
                Vector3 rightLimitPos = this.transform.position;
                rightLimitPos.x = 4.6f;//初期値右端
                this.transform.position = rightLimitPos;
            }
        }
    }

}
