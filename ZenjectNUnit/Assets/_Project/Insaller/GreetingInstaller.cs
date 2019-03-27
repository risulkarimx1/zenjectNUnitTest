using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingInstaller : MonoInstaller<GreetingInstaller>
{
    public GreetingConsumer greetingConsumerPrefab;

    public override void InstallBindings()
    {
       Container.Bind<IGreetings>().To<Greetings>().AsSingle();

        Container.BindFactory<GreetingConsumer, GreetingConsumer.Factory>().FromComponentInNewPrefab(greetingConsumerPrefab);

        // next task is to add more stuff for NUnit testing
    }
}
