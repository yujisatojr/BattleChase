using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    private Animator playerAnim;
    public GameObject target;
    public Transform player;
    private Vector3 targetPos;
    private float speed = 4.0f;

    public float distance;
    private bool inRange;

    private bool isDead = false;

    void Start ()
    {
        playerAnim = GetComponent<Animator>();
    }

    void Update ()
    {
        transform.LookAt(player);
        playerAnim.SetBool("running", false);
        playerAnim.SetBool("shooting", false);
        distance = Vector3.Distance(transform.position, target.transform.position);
        inRange = distance < 50 && distance > 10;
        if (inRange && !isDead)
        {
            playerAnim.SetBool("running", true);
            playerAnim.SetBool("shooting", false);
            targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
        if (distance <= 10)
        {
            playerAnim.SetBool("running", false);
            playerAnim.SetBool("shooting", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerAnim.SetBool("running", false);
            playerAnim.SetBool("shooting", false);
            playerAnim.SetBool("crashed", true);
            isDead = true;
        }
    }
}
