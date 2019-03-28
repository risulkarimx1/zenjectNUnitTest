using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    [SerializeField] private GameSettings gameSettings;

    public override void InstallBindings()
    {
        // creating an instance of GameSettings, then making a singleton out of it
        Container.BindInterfacesAndSelfTo<GameSettings>().FromInstance(gameSettings).AsSingle();
    }
}