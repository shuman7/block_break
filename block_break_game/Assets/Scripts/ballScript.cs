using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float ballSpeed = 30.0f;
    private Rigidbody myRigid;
    public AudioClip sound;
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
        audioSource.PlayOneShot(sound);
    }
}
