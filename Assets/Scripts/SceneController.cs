using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] _spawnPoint;
    private GameObject _enemy;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if( _enemy == null)
        {
            int index = Random.Range(0, _spawnPoint.Length);
            _enemy = Instantiate(enemyPrefab, _spawnPoint[index].position, _spawnPoint[index].rotation);
            _enemy.transform.position = new Vector3(0, 1, 0);
            
            
        } 
    }
}
