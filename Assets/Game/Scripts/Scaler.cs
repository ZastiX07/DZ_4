using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
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
        float newSize = _gameObject.transform.localScale.x + change;

        newSize = Mathf.Clamp(newSize, 0, _magnificationLimit);

        _gameObject.transform.localScale = new Vector3(newSize, newSize, newSize);
    }

    private void SwitchMode()
    {
        if (_gameObject.transform.localScale.x >= _magnificationLimit)
            _isGrowing = false;
        else if (_gameObject.transform.localScale.x <= 0.1f)
            _isGrowing = true;
    }
}
