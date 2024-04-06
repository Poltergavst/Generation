using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _prefab;

    private float _spawnRate = 2f;
    private float _spawnDelay = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), _spawnDelay, _spawnRate);
    }

    private void SpawnEnemy()
    {
        GameObject enemy;
        Mover mover;
        Transform instanceTransform = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        


        enemy = Instantiate(_prefab, instanceTransform.position, instanceTransform.rotation);
        mover = enemy.AddComponent<Mover>();

        mover.ChangeDirection(Vector3.up);
    }
}
