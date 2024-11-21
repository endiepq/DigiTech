using UnityEngine;

public class HighlightController : MonoBehaviour
{
    [SerializeField] 
    private Color _highlightColor;

    private Color _originalColor;
    private Renderer _objectRenderer;
    private bool _isActive;

    private void Start()
    {
        _objectRenderer = GetComponent<Renderer>();
        _originalColor = _objectRenderer.material.color;
    }

    private void OnMouseEnter()
    {
        _objectRenderer.material.color = _highlightColor;
        _isActive = true;
    }

    private void OnMouseExit()
    {
        _objectRenderer.material.color = _originalColor;
        _isActive = false;
    }
    public bool GetActive() { return _isActive; }
}
