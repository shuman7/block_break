using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float ballSpeed = 30.0f;
    private Rigidbody myRigid;
    public AudioClip wallSound;
    public AudioClip blockSound;
    public AudioClip gameOverSound;
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * ballSpeed, ForceMode.VelocityChange);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.tag == "Wall") || (collision.gameObject.tag == "Player"))   
        {
            audioSource.PlayOneShot(wallSound);
        }
        if(collision.gameObject.tag == "Block")   
        {
            audioSource.PlayOneShot(blockSound);
        }
        if(collision.gameObject.tag == "GameOver")   
        {
            audioSource.PlayOneShot(gameOverSound);
        }
    }
}
