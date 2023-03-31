using Zenject;

namespace Onitama.Scenes.GameScene
{
    public class GameSceneInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameSceneLogic>().AsSingle();
        }
    }
   
}