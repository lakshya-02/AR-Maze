using UnityEngine;
using Vuforia;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    private GameObject spawnedBall;
    private ObserverBehaviour observer;

    private void Start()
    {
        observer = GetComponent<ObserverBehaviour>();

        if (observer)
            observer.OnTargetStatusChanged += OnTrackingChanged;
    }

    private void OnDestroy()
    {
        if (observer)
            observer.OnTargetStatusChanged -= OnTrackingChanged;
    }

    private void OnTrackingChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            SpawnBall();
        }
        else
        {
            DespawnBall();
        }
    }

    private void SpawnBall()
    {
        if (spawnedBall == null && ballPrefab != null)
        {
            spawnedBall = Instantiate(ballPrefab, transform); // child of ImageTarget
            spawnedBall.transform.localPosition = new Vector3(0f, 0.5f, 0f); // or wherever your maze starts
            spawnedBall.transform.localRotation = Quaternion.identity;

            Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    private void DespawnBall()
    {
        if (spawnedBall != null)
        {
            Destroy(spawnedBall);
        }
    }
}
