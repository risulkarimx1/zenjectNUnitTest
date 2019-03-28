using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingInstaller : MonoInstaller<GreetingInstaller>
{
    // injecting a settings from SettingsInstaller
    [Inject] private GameSettings settings;

    public override void InstallBindings()
    {
       // creating a singletop from IGreetings by instantiating Greetings
       Container.Bind<IGreetings>().To<Greetings>().AsSingle();

       // created a factory of GreetingConsumer from the prefab
        Container.BindFactory<GreetingConsumer, GreetingConsumer.Factory>().FromComponentInNewPrefab(settings.greetingConsumerPrefab);

        // next task is to add more stuff for NUnit testing
    }
}
