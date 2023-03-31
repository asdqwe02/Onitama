using UnityEngine;
using Zenject;

namespace Onitama.Scripts.Configs
{
    [CreateAssetMenu(menuName = "Onitama/GameSceneConfigInstaller", fileName = "GameSceneConfigInstaller.asset")]
    public class GameSceneConfigInstaller : ScriptableObjectInstaller
    {
        public override void InstallBindings()
        {
        }
    }
}