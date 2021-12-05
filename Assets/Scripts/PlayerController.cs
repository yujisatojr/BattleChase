using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerNum;
    public GameObject bullet;
    public GameObject obstacle;

    void Update()
    {
        if (playerNum == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 newPos = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z + 2f);
                Instantiate(bullet, newPos, transform.rotation);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Instantiate(obstacle, transform.position, bullet.transform.rotation);
            }
        }
    }
}
