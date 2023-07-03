using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipeCopy;
    public Transform spawnPositon;
    public float delayTime;
    private float currentTime = 0;
    [SerializeField] float minY = -2f;
    [SerializeField] float maxY = 4f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameOver) return;
        if(currentTime > delayTime)
        {
            currentTime = 0;
            GameObject pipe = Instantiate(pipeCopy);
            pipe.transform.position = new Vector2(spawnPositon.position.x, Random.Range(minY, maxY));
        }
        currentTime += Time.deltaTime; 
    }
}
