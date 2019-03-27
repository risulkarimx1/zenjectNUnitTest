using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour
{
    private  IGreetings greeting;
    public float timeBetweenMessage = 1.0f;
    private float timeSinceMessage = 0;

    [Inject]
    public void Construct(IGreetings greeting)
    {
        this.greeting = greeting;
    }

    void Update()
    {
        timeSinceMessage += Time.deltaTime;
        if (timeSinceMessage > timeBetweenMessage)
        {
            Debug.Log($"From Greeting: {greeting.Message}");
            timeSinceMessage = 0;
        }
    }


    // <list of input types, last one is output>
    public class Factory : PlaceholderFactory<GreetingConsumer>
    {

    }

}
