using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float unfreezeDelay = 2f;
    
    private bool isUnfrozen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Freeze position initially and KEEP IT FROZEN until target is detected
        if (rb)
        {
            //rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    // Call this method from your AR tracking script when target is detected
    public void OnTargetDetected()
    {
        if (!isUnfrozen)
        {
            StartCoroutine(UnfreezeAfterDelay());
        }
    }

    private System.Collections.IEnumerator UnfreezeAfterDelay()
    {
        yield return new WaitForSeconds(unfreezeDelay);

        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.None; // Unfreeze completely
            isUnfrozen = true;
            Debug.Log("Ball unfrozen after target detection.");
        }
    }
    
    // Call this when AR target is lost
    public void OnTargetLost()
    {
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            isUnfrozen = false;
        }
    }
}
