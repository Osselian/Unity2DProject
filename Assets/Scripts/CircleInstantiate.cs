using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnTime;

    private int _index;
    private float _spawnTimer;

    private void Update()
    {
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer > _spawnTime )
        {
            _index = Random.Range(0, _spawnPoints.Length);
            GameObject gameObject = Instantiate(_template, _spawnPoints[_index]);
            _spawnTimer = 0;
        }
        
    }
}
