using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private Vector3[] ballSpawnLocation;
    private List<GameObject> ballList;
    private float timer;

    public float spawnInterval;
    public List<GameObject> ballListTemplate;

    private void Start()
    {
        ballSpawnLocation = new [] {new Vector3(5, -0.25f, 5), new Vector3(5, -0.25f, -5), new Vector3(-5, -0.25f, 5), new Vector3(-5, -0.25f, -5)};
        ballList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnInterval)
        {
            GenerateBall();
            timer -= spawnInterval;
        }
    }

  
    public void GenerateBall()
    {
        //fungsi remove balllist belum dibikin
        if (ballList.Count >= 5)
        {
            return; 
        }
        else
        {
            int randomIndex = Random.Range(0, ballListTemplate.Count);
            int randomRange = Random.Range(0, 4);

            GameObject ball = Instantiate(ballListTemplate[randomIndex], ballSpawnLocation[randomRange], Quaternion.identity);

            ball.SetActive(true);
            ballList.Add(ball);
        }
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}
