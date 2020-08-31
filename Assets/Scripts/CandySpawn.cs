using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    [SerializeField]
    float Maxx;
    
    public GameObject[] candies;

    [SerializeField]
    float SpawnInterval;
    public static CandySpawn Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawnCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomCandies()
    {
       
       int RandomNumbers = Random.Range(0, candies.Length);
       float RandomX = Random.Range(-Maxx, Maxx);
       Vector3 RandomPos = new Vector3(RandomX, transform.position.y, transform.position.z);
       Instantiate(candies[RandomNumbers],RandomPos , transform.rotation);
        
    }
    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while(true)
        {
            RandomCandies();

            yield return new WaitForSeconds(SpawnInterval);
        }
        
    }
    public void StartSpawnCandies()
    {
        StartCoroutine("SpawnCandies");
    }
    public void StopSpawnCandies()
    {
        StopCoroutine("SpawnCandies");
    }
}
