using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float barSpeed = 1.0f;
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        // Flick();
        // if(this.transform.position.x > -4.7)
        // {
        //     if(Input.GetKey(KeyCode.LeftArrow))
        //     {
        //         this.transform.position += Vector3.left * barSpeed * Time.deltaTime;
        //     }
        // }
        // if(this.transform.position.x < 4.7)
        // {
        //     if(Input.GetKey(KeyCode.RightArrow)){
        //         this.transform.position += Vector3.right * barSpeed * Time.deltaTime;
        //     }
        // }
    }

    // void Flick(){
    //     if (Input.GetKeyDown(KeyCode.Mouse0)){
    //         // マウスをクリックした座標
    //         this.startPos = Input.mousePosition;
    //     }
        
    //     // if(this.transform.position.x > -4.7)
    //     // {
    //     //     playerPos = new Vector3(touchStartPos.x,
    //     //                             Input.mousePosition.y,
    //     //                             Input.mousePosition.z);
    //     // }
    //     // if(this.transform.position.x < 4.7)
    //     // {
    //     //     if(Input.GetKey(KeyCode.RightArrow)){
    //     //         this.transform.position += Vector3.right * barSpeed * Time.deltaTime;
    //     //     }
    //     // }
    // }

    float speed = 10.0f;
    Vector3 preMousePos;


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
            Vector3 newPos = this.gameObject.transform.position + new Vector3(mousePosDiff.x / Screen.width, 0, 0 / Screen.height) * speed;

            this.transform.position = newPos;
        }
    }
    
}
