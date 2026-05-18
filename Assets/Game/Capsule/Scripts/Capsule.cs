using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _sizeX = 1f;
    [SerializeField] private float _sizeY = 1f;
    [SerializeField] private float _sizeZ = 1f;

    public float SizeX => transform.localScale.x;
    public float SizeY => transform.localScale.y;
    public float SizeZ => transform.localScale.z;
    public Vector3 Size => transform.localScale;

    private void Awake()
    {
        transform.localScale = new Vector3(_sizeX, _sizeY, _sizeZ);
    }
}
