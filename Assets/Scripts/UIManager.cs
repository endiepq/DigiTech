using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultText;
    [SerializeField] private TMP_Text _resistanceText;
    [SerializeField] private TMP_Text _ACVoltageText;
    [SerializeField] private TMP_Text _DCVoltageText;
    [SerializeField] private TMP_Text _currentStrength;

    private MultimeterLogic _multimeterLogic;

    private void Start()
    {
        _multimeterLogic = GetComponent<MultimeterLogic>();
    }

    public void ChangeParametres(float _modeIndex)
    {
        switch (_modeIndex)
        {
            case 1:
                _resultText.text = _DCVoltageText.text = _multimeterLogic.GetDCVoltage().ToString("F2");
                _resistanceText.text = _ACVoltageText.text = _currentStrength.text = "0,00";
                break;
            case 3:
                _resultText.text = _ACVoltageText.text = _multimeterLogic.GetACVoltage().ToString("F2");
                _resistanceText.text = _DCVoltageText.text = _currentStrength.text = "0,00";
                break;
            case 5:
                _resultText.text = _currentStrength.text = _multimeterLogic.GetCurrentStrength().ToString("F2");
                _resistanceText.text = _ACVoltageText.text = _DCVoltageText.text = "0,00";
                break;
            case 7:
                _resultText.text = _resistanceText.text = _multimeterLogic.GetResistance().ToString("F2");
                _ACVoltageText.text = _DCVoltageText.text = _currentStrength.text = "0,00";
                break;
            default:
                _resultText.text = _resistanceText.text = _ACVoltageText.text = _DCVoltageText.text = _currentStrength.text = "0,00";
                break;
        }
    }
}
