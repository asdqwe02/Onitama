using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

namespace Onitama.Scripts.Configs
{
    [CreateAssetMenu(menuName = "Onitama/BoardGridConfig", fileName = "BoardGridConfig.asset")]
    public class BoardGridConfig : ScriptableObject
    {
        public float Spacing;
        public Vector2Int Size;
        public GameObject BoardGridCellPrefab;
    }
}