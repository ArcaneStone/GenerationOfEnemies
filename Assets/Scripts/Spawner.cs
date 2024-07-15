using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private List<Transform> _spawnPoint;
    [SerializeField] private float _spawnInterval = 2f;

    private float _lastSpawnTime;

    private void Update()
    {
        if (Time.time - _lastSpawnTime >= _spawnInterval )
        {
            Spawn();
            _lastSpawnTime = Time.time;
        }
    }

    private void Spawn()
    {
        int randomSpawnIndex = Random.Range(0, _spawnPoint.Count);
        Transform spawnPoint = _spawnPoint[randomSpawnIndex];

        GameObject enemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);

        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();

        if(enemyMovement != null)
        {
            enemyMovement.SetMovementDirection(spawnPoint.forward);
        }
    }
}
