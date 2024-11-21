using UnityEngine;

public class MultimeterLogic : MonoBehaviour
{
    private float _resistance = 1000f;
    private float _power = 400f;
    private float _current;
    private float _voltage;
    private float _ACvoltage = 0.01f;
    private void Start()
    {
        CalculateValues();
    }

    private void CalculateValues()
    {
        _current = Mathf.Sqrt(_power / _resistance);
        _voltage = Mathf.Sqrt(_power * _resistance);
    }

    public float GetResistance() { return _resistance; }
    public float GetCurrentStrength() { return _current; }
    public float GetDCVoltage() { return _voltage; }
    public float GetACVoltage() { return _ACvoltage; }
}
