using JetBrains.Annotations;
using GFramework.Runner;
using GFramework.Logger;
using Zenject;

namespace Onitama.Scenes.GameScene
{
    [UsedImplicitly]
    public class GameSceneLogic
    {
        [Inject] private ILogger _logger;
        [Inject] private IRunner _runner;
    }
}