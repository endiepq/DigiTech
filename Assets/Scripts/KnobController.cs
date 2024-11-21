using UnityEngine;

public class KnobController : MonoBehaviour
{
    private float _minRotationAngle = 90f;
    private float _maxRotationAngle = 450f;
    private float _rotationStep = 45f;
    private float _currentRotationAngle;
    private HighlightController _highlightController;
    private UIManager _manager;
    private float _modeIndex = 0;

    private void Start()
    {
        _currentRotationAngle = transform.localEulerAngles.z;
        _highlightController = GetComponent<HighlightController>();
        _manager = GetComponent<UIManager>();
    }

    private void Rotation(float scroll)
    {
        _currentRotationAngle += scroll > 0 ? _rotationStep : -_rotationStep;
        _currentRotationAngle = Mathf.Clamp(_currentRotationAngle, _minRotationAngle, _maxRotationAngle);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, _currentRotationAngle);
    }
    private void UpdateMode()
    {
        _modeIndex = _currentRotationAngle / _rotationStep - 2;
    }

    private void Update()
    {
        if (_highlightController.GetActive())
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            if (scroll != 0)
            {
               Rotation(scroll);
               UpdateMode();
               _manager.ChangeParametres(_modeIndex);
            }
        }
    }
}
