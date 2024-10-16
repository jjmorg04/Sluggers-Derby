using UnityEngine;

public class BaseballBat : MonoBehaviour
{
    private Vector3 batPosition;

    void Start()
    {
        // Set the initial position of the bat
        batPosition = transform.position;
    }

    void Update()
    {
        MoveBat();
    }

    void MoveBat()
    {
        // Get mouse position in world coordinates
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(Camera.main.transform.position.z); // Use camera's distance from the plane (Z-axis)

        // Convert screen point to world point
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Clamp bat movement to stay within screen bounds (optional)
        worldPosition.x = Mathf.Clamp(worldPosition.x, -8f, 8f); // Adjust limits as needed
        worldPosition.y = Mathf.Clamp(worldPosition.y, -4.5f, 4.5f); // Adjust limits as needed

        // Instantly update bat's position based on mouse position
        transform.position = new Vector3(worldPosition.x, worldPosition.y, 0f); // Z-axis is fixed for 2D
    }
}

