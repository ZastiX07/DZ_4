using UnityEngine;

public class MoverCapsule : MonoBehaviour
{
    [SerializeField] private Capsule _capsule;
    [SerializeField] private float _valueIncreasedSize = 2f;
    [SerializeField] private float _magnificationLimit = 5f;

    private bool _isGrowing = true;

    private void Update()
    {
        if (_isGrowing)
            ChangeSize(_valueIncreasedSize);

        if (!_isGrowing)
            ChangeSize(-_valueIncreasedSize);

        SwitchMode();
    }

    private void ChangeSize(float changeValue)
    {
        float change = changeValue * Time.deltaTime;
        float newSize = _capsule.SizeX + change;

        newSize = Mathf.Clamp(newSize, 0, _magnificationLimit);

        _capsule.transform.localScale = new Vector3(newSize, newSize, newSize);
    }

    private void SwitchMode()
    {
        if (_capsule.SizeX >= _magnificationLimit)
            _isGrowing = false;
        else if (_capsule.SizeX <= 0.1f)
            _isGrowing = true;
    }
}
