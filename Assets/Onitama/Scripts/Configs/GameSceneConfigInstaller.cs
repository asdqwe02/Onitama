using UnityEngine;
using Zenject;

namespace Onitama.Scripts.Configs
{
    [CreateAssetMenu(menuName = "Onitama/GameSceneConfigInstaller", fileName = "GameSceneConfigInstaller.asset")]
    public class GameSceneConfigInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private BoardGridConfig _boardGridConfig;
        public override void InstallBindings()
        {
            Container.BindInstance(_boardGridConfig).AsSingle();
        }
    }
}