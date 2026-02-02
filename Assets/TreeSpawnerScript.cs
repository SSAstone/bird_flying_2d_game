using UnityEngine;

public class TreeSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject treePrefab;
    public float spawnInterval = 2.0f;
    private float timeSinceLastSpawn = 0f;

    void Start()
    {
        spawnTree();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastSpawn < spawnInterval)
        {
            timeSinceLastSpawn += Time.deltaTime;
        } else
        {
            spawnTree();
            timeSinceLastSpawn = 0f;
        }
    }

    void spawnTree()
    {
        Instantiate(treePrefab, new Vector3(transform.position.x, Random.Range(-0.8f, 0.8f), transform.position.z), transform.rotation);
    }
}
