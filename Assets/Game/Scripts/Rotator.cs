using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _gameObject.transform.Rotate(0, _speed, 0);
    }
}
