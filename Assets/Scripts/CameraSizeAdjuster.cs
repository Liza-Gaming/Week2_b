using UnityEngine;

// Make objects will look the same size when you rotate the phone

// Chat GPT code

public class CameraSizeAdjuster : MonoBehaviour
{
    private Camera _camera;
    private float _initialOrthographicSize;

    void Start()
    {
        _camera = GetComponent<Camera>();
        _initialOrthographicSize = _camera.orthographicSize;
    }

    void Update()
    {
        AdjustCameraSize();
    }

    private void AdjustCameraSize()
    {
        float aspectRatio = (float)Screen.width / Screen.height;
        // If in landscape mode (width > height)
        if (aspectRatio >= 1)
        {
            _camera.orthographicSize = _initialOrthographicSize;
        }
        else // In portrait mode (height > width)
        {
            _camera.orthographicSize = _initialOrthographicSize / aspectRatio;
        }
    }
}