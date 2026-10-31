using UnityEngine;

public class CameraFit : MonoBehaviour
{
    [SerializeField] private float targetWidth;
    [SerializeField] private float targetHeight;
    private Camera targetCamera;

    private int lastWidth;
    private int lastHeight;

    void Awake()
    {
        targetCamera = GetComponent<Camera>();
    }
    private void Start()
    {
        Fit();
        lastWidth = Screen.width;
        lastHeight = Screen.height;
    }
    private void Fit()
    {
        float aspect = (float)Screen.width / (float)Screen.height;
        float soonToBeHeight = targetHeight / 2;
        float soonToBeWidth = targetWidth / (2 * aspect);

        targetCamera.orthographicSize = Mathf.Max(soonToBeHeight, soonToBeWidth);
    }
    private void Update()
    {
        if (Screen.width != lastWidth || Screen.height != lastHeight)
        {
            Fit();
            lastWidth = Screen.width;
            lastHeight = Screen.height;
        }
    }
}
