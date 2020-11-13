using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    public GameObject[] objects;

    private int direction;
    public float moveAmount;

    private float timeBtwRooms;
    public float startTimeBtwRoom = 0.25f;


    void Start()
    {
        InstantiateRandom();
        direction = Random.Range(1, 5);

    }

    private void Update()
    {
        if (timeBtwRooms <= 0)
        {
            Move();
            timeBtwRooms = startTimeBtwRoom;
        }
        else
        {
            timeBtwRooms -= Time.deltaTime;
        }

    }

    private void Move()
    {
        // Right
        if(direction == 1)
        {
            Vector2 newPos = new Vector2(transform.position.x + moveAmount, transform.position.y);
            transform.position = newPos; 
        }

        // Left
        if (direction == 2)
        {
            Vector2 newPos = new Vector2(transform.position.x - moveAmount, transform.position.y);
            transform.position = newPos;

        }

        // Up
        //if (direction == 3)
        //{
         //   Vector2 newPos = new Vector2(transform.position.x, transform.position.y + moveAmount);
          //  transform.position = newPos;
        //}

        // Down
        if (direction == 4)
        {
            Vector2 newPos = new Vector2(transform.position.x, transform.position.y - moveAmount);
            transform.position = newPos;
        }

        InstantiateRandom();
        direction = Random.Range(1, 5);

    }

    public void InstantiateRandom()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }


}
