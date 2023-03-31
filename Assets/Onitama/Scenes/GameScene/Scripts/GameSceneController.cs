using GFramework.Scene;
using Zenject;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif

// ReSharper disable once CheckNamespace
namespace Onitama.Scenes.GameScene
{
	public class GameSceneController : SceneController
	{
	    [Inject] private GameSceneLogic _logic;
		//This function call when our scene is being loaded
		public override void OnSceneLoaded (object data)
		{
			base.OnSceneLoaded (data);
		}

		//This function call when our scene is being removed/unloaded
		public override void OnSceneUnloaded ()
		{
			base.OnSceneUnloaded ();
		}

		
#if UNITY_EDITOR
		[MenuItem("GFramework/Open Scene/GameScene")]
		public static void OpenSceneGameScene()
		{
			if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
			{
				EditorSceneManager.OpenScene(@"Assets/Onitama/Scenes/GameScene/Scenes/GameScene.unity");
			}
		}
#endif
	}
}

