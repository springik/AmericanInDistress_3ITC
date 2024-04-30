using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [field: SerializeField] Enemy _enemy;
    int currHp;
    // Start is called before the first frame update
    void Start()
    {
        currHp = _enemy.hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
