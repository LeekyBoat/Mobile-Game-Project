using Unity.ProjectAuditor.Editor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PanMovement : MonoBehaviour
{
    [SerializeField] private Areas screenBounds;
    [SerializeField] private int movedirection;

    private Camera cam;
    private Rigidbody rb;
    private Vector3 targetPosition;

    private void Awake()
    {
        cam = GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
    }


    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void Movement()
    {

    }

    private void OnDrawGizmosSelected()
    {
       // Gizmos.DrawWireCube(screenBounds.center, screenBounds.size);
    }
}
 