using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public int playerNum;
    public GameObject resultPane_1;
    public GameObject resultPane_2;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Player 1 collision
        if (playerNum == 1)
        {
            if (other.gameObject.CompareTag("Cone"))
            {
                //Debug.Log("Collision with cone");
                EnvManager.Instance.health_1 -= 30;
                EnvManager.Instance.score_2 += 30;
            }
            if (other.gameObject.CompareTag("Goal"))
            {
                resultPane_2.SetActive(true);
                //Debug.Log("Winner!");

            }
        }
        // Player 2 collision
        else
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
                Instantiate(explosion, transform.position, transform.rotation);
                //Debug.Log("Collision with bullet");
                EnvManager.Instance.health_2 -= 30;
                EnvManager.Instance.score_1 += 30;
            }
            if (other.gameObject.CompareTag("Goal"))
            {
                resultPane_1.SetActive(true);
                //Debug.Log("Winner!");
            }
        }
    }
}
