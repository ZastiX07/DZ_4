using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _distance = 3f;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private GameObject _gameObject;

    public Vector3 StartPosition => _gameObject.transform.position;
    public Vector3 EndPosition => StartPosition + Vector3.forward * _distance;

    private void Awake()
    {
        Move();
    }

    private void Move()
    {
        _gameObject.transform.DOMove(EndPosition, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}