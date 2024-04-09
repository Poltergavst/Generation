using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Mover _prefab;

    private float _spawnRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), _spawnRate, _spawnRate);
    }

    private void SpawnEnemy()
    {
        Mover enemy;
        Transform instanceTransform = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

        enemy = Instantiate(_prefab, instanceTransform.position, instanceTransform.rotation);

        enemy.ChangeDirection(Vector3.up);
    }
}
