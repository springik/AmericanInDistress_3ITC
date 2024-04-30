using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/Enemy")]
public class Enemy : ScriptableObject
{
    [field: SerializeField]
    public string name { get; private set; }

    [field: SerializeField]
    public int hp { get; private set; }
    [field: SerializeField]
    public float speed { get; private set; } = 1f;
    [field: SerializeField]
    public LayerMask attackMask { get; private set; }
}
