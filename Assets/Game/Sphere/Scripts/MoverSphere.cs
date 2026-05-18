using UnityEngine;
using DG.Tweening;

public class MoverSphere : MonoBehaviour
{
    [SerializeField] private float _distance = 3f;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private Sphere _sphere;

    public Vector3 StartPosition => _sphere.transform.position;
    public Vector3 EndPosition => StartPosition + Vector3.forward * _distance;

    private void Awake()
    {
        Move();
    }

    private void Move()
    {
        _sphere.transform.DOMove(EndPosition, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}