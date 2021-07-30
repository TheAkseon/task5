using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _template = new GameObject[4];
    [SerializeField] private Transform[] _spawnPoints =  new Transform[4];

    private void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            Instantiate(_template[0], _spawnPoints[0].position, Quaternion.identity);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            Instantiate(_template[1], _spawnPoints[1].position, Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            Instantiate(_template[2], _spawnPoints[2].position, Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            Instantiate(_template[3], _spawnPoints[3].position, Quaternion.identity);
        }
    }
}
