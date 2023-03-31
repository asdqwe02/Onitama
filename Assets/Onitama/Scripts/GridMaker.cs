using System;
using Onitama.Scripts.Configs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Onitama.Scripts
{
    public class GridMaker : MonoBehaviour
    {
        [Inject] private BoardGridConfig _boardGridConfig;

        private void Start()
        {
            CreateGrid();
        }

        private void CreateGrid()
        {
            for (int i = 0; i < _boardGridConfig.Size.x; i++)
            {
                for (int j = 0; j < _boardGridConfig.Size.x; j++)
                {
                    Vector2 pos = transform.position + new Vector3(i, -j, 0) * _boardGridConfig.Spacing;
                    Instantiate(_boardGridConfig.BoardGridCellPrefab, pos, quaternion.identity);
                }
            }
        }
    }
}