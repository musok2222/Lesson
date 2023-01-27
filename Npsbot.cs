using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npsbot : MonoBehaviour
{

    public float health;
    public float level;
    public float speed;
    public GameObject player;
   

     

    
    void Start()
    {
        health += 5;
        level += 5;
        speed = 5;
        player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.transform.position = new Vector3(5,0,0);
        player.transform.position = new Vector3(0, 2, 0);
    }
    



    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.x += speed *Time.deltaTime;
        transform.position = newPosition;

        Vector3 newPositionplayer;
        newPositionplayer = player.transform.position;
        newPositionplayer.x += speed * Time.deltaTime;
        player.transform.position = newPositionplayer;

    }
}
