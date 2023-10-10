using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;

    //NPC Speed
    public float speed = 1.2f;


    void Start()
    {
        health = health + level;
        print("Lives: " + health);
    }

    void Update()
    {
        //krijimi i vektorit3
        Vector3 newPosition = transform.position;

        //ndryshimi i pozicionit rreth z
        newPosition.z += speed * Time.deltaTime;

        //krijimi i pozicionit npc
        transform.position = newPosition;
    }
}