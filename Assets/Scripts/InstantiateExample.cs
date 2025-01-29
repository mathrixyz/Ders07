using UnityEngine;

public class InstantiateExample: MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private Transform _parentObject;

    private void Start()
    {
        Instantiate( _spawnObject,_parentObject );
    }
}
