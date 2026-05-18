using UnityEngine;

public class MoverCube : MonoBehaviour
{
    [SerializeField] private Cube _cube;
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _cube.transform.Rotate(0, _speed, 0);
    }
}
