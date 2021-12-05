using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;

    bool firstScore = true;
    bool firstHealth = true;
    //public GameObject bossPrefabs;
    //public int bossHealth = 30;

    public GameObject levelText;
    public float timeValue = 120;
    public Text timerText;

    public GameObject resultPane_1;
    public GameObject resultPane_2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ShowLevel", 1);
        //StartCoroutine("SpawnBoss", 1);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (EnvManager.Instance.score > 200 && firstScore != false)
        {
            firstScore = false;
            Vector3 spawnPos = new Vector3(0, 17, 0);
            Instantiate(bossPrefabs, spawnPos, bossPrefabs.transform.rotation);
        }
        */

        if (EnvManager.Instance.health_1 <= 0 && firstHealth != false)
        {
            isGameActive = false;
            firstHealth = false;
            EnvManager.Instance.score_2 += 500;
            resultPane_1.SetActive(true);
        }

        if (EnvManager.Instance.health_2 <= 0 && firstHealth != false)
        {
            isGameActive = false;
            firstHealth = false;
            EnvManager.Instance.score_1 += 500;
            resultPane_2.SetActive(true);
        }

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        ShowTime(timeValue);

        if (timeValue < 0)
        {
            isGameActive = false;
            if (EnvManager.Instance.score_1 < EnvManager.Instance.score_2)
            {
                resultPane_1.SetActive(true);
            }
            else
            {
                resultPane_2.SetActive(true);
            }
        }
    }

    void ShowTime(float time)
    {
        if (time < 0)
        {
            time = 0;
        }

        float min = Mathf.FloorToInt(time / 60);
        float sec = Mathf.FloorToInt(time % 60);

        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }

    IEnumerator ShowLevel()
    {
        levelText.SetActive(true);
        yield return new WaitForSeconds(3);
        levelText.SetActive(false);
    }

    /*IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(20);
        Vector3 spawnPos = new Vector3(0, 17, 0);
        Instantiate(bossPrefabs, spawnPos, bossPrefabs.transform.rotation);
    }*/
}
