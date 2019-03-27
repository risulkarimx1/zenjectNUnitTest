using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

public class GreetingSpawner : MonoBehaviour
{
    public GreetingConsumer consumerPrefab;

    [Inject] private GreetingConsumer.Factory greetingfactFactory;

    private Bounds bounds;

    public Vector3 boundsSize = new Vector3(1,1,0);
    public float timeBetweenSpawns = 1.0f;
    private float timeSinceSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        bounds=new Bounds(Vector3.zero, boundsSize);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > timeBetweenSpawns)
        {
            GreetingConsumer consumer = greetingfactFactory.Create();//Instantiate(consumerPrefab.gameObject);
            consumer.transform.position = GetRandomSpawnPositions();
            timeSinceSpawn = 0;
        }
    }

    private Vector3 GetRandomSpawnPositions()
    {
        float xPos = (Random.value - 0.5f) * bounds.size.x;
        float yPos = (Random.value - 0.5f) * bounds.size.y;
        float zPos = (Random.value - 0.5f) * bounds.size.z;

        return new Vector3(xPos,yPos,zPos);
    }
}
