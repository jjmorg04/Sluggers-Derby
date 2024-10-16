using UnityEngine;

public class PitchingMachine : MonoBehaviour
{
    public GameObject baseballPrefab;  // Reference to the baseball prefab
    public Transform shootPoint;       // Point from which the baseball will be shot
    public float shootForce = 500f;    // Force applied to the baseball
    public float timeBetweenPitches = 2f; // Time between each pitch

    private float timer;

    void Update()
    {
        // Track time and shoot baseball at intervals
        timer += Time.deltaTime;
        if (timer >= timeBetweenPitches)
        {
            ShootBaseball();
            timer = 0f;
        }
    }

    void ShootBaseball()
    {
        // Instantiate a new baseball at the shoot point
        GameObject baseball = Instantiate(baseballPrefab, shootPoint.position, shootPoint.rotation);

        // Apply force to shoot the baseball
        Rigidbody rb = baseball.GetComponent<Rigidbody>();
        rb.AddForce(shootPoint.forward * shootForce); // Adjust direction and force based on your setup
    }
}
