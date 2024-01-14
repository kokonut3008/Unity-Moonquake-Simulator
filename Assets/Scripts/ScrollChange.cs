using UnityEngine;
using UnityEngine.UI;

public class ScrollChange : MonoBehaviour
{

    public Scrollbar scrollbar;

    [Range(0.01f, 0.1f)]
    public float scrollSpeed = 0.05f;
    public float scrollballValue;


    private void Start()
    {
        // Get the Scrollbar component attached to this GameObject.
        scrollbar = GetComponent<Scrollbar>();

        // Initialize scrollballValue after obtaining the reference to scrollbar.
        scrollballValue = scrollbar.value;
    }

    private void Update()
    {
        scrollballValue = scrollbar.value;

        // Check if the mouse wheel is being scrolled.
        float scrollDelta = Input.GetAxis("Mouse ScrollWheel");

        if (Mathf.Abs(scrollDelta) > 0.01f)
        {
            // Adjust the scrollbar's value based on the mouse wheel input.
            scrollbar.value = Mathf.Clamp01(scrollbar.value - scrollDelta * scrollSpeed);
            scrollballValue = scrollbar.value;
        }
    }
}
