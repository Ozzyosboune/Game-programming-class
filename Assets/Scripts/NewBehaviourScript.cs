using UnityEngine;
using System.Collections;

public class NewBehaviourScript: MonoBehaviour
{
    //use this to drag the bullet emitter onto it
    public GameObject Bullet_Emitter;

    //Use this to drag the bullet prefab onto it
    public GameObject Bullet;

    public float Bullet_Forward_Force;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Bullet instantiate
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;


            Temporary_Bullet_Handler.transform.Rotate(Vector3.forward * 90);

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Set the bullet force
            Temporary_RigidBody.AddForce(-transform.up * Bullet_Forward_Force);

            Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}