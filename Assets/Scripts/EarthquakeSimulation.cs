using UnityEngine;
using TMPro;


public class EarthquakeSimulation : MonoBehaviour
{
    public float maxIntensity = 10.0f; // Maximum force intensity
    private float timer = 0.0f;
    private bool isFalling = false;
    private bool isTimerActive = false; // New boolean flag to control the timer

    public TMP_Dropdown firstDropdown;
    public TMP_Dropdown secondDropdown;
    public float delayTime = 5.0f; // Time delay in seconds

    // Reference to the parent GameObject containing all the Rigidbody components
    public Transform parentRigidbodyContainer;
    private void Update()
    {
        string firstDropdownValue = firstDropdown.options[firstDropdown.value].text;
        string secondDropdownValue = secondDropdown.options[secondDropdown.value].text;

        if (secondDropdownValue == "None") isFalling = false;
        if (firstDropdownValue == "1971" && secondDropdownValue == "April 17") isFalling = true;
        if (firstDropdownValue == "1971" && secondDropdownValue == "May 20") isFalling = false;
        if (firstDropdownValue == "1971" && secondDropdownValue == "July 11") isFalling = true;
        if (firstDropdownValue == "1972" && secondDropdownValue == "January 2") isFalling = true;
        if (firstDropdownValue == "1972" && secondDropdownValue == "September 17") isFalling = false;
        if (firstDropdownValue == "1972" && secondDropdownValue == "December 6") isFalling = false;
        if (firstDropdownValue == "1972" && secondDropdownValue == "December 9") isFalling = false;
        if (firstDropdownValue == "1973" && secondDropdownValue == "February 8") isFalling = false;
        if (firstDropdownValue == "1973" && secondDropdownValue == "March 13") isFalling = true;
        if (firstDropdownValue == "1973" && secondDropdownValue == "June 20") isFalling = true;
        if (firstDropdownValue == "1973" && secondDropdownValue == "October 1") isFalling = false;
        if (firstDropdownValue == "1974" && secondDropdownValue == "February 23") isFalling = false;
        if (firstDropdownValue == "1974" && secondDropdownValue == "March 27") isFalling = true;
        if (firstDropdownValue == "1974" && secondDropdownValue == "April 19") isFalling = false;
        if (firstDropdownValue == "1974" && secondDropdownValue == "May 29") isFalling = false;
        if (firstDropdownValue == "1974" && secondDropdownValue == "July 11") isFalling = true;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 3") isFalling = true;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 12") isFalling = true;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 13") isFalling = false;
        if (firstDropdownValue == "1975" && secondDropdownValue == "February 13") isFalling = false;
        if (firstDropdownValue == "1975" && secondDropdownValue == "May 7") isFalling = false;
        if (firstDropdownValue == "1975" && secondDropdownValue == "May 27")isFalling = false;
        if (firstDropdownValue == "1975" && secondDropdownValue == "November 10") isFalling = true;
        if (firstDropdownValue == "1976" && secondDropdownValue == "January 4") isFalling = true;
        if (firstDropdownValue == "1976" && secondDropdownValue == "January 12") isFalling = false;
        if (firstDropdownValue == "1976" && secondDropdownValue == "March 6") isFalling = true;
        if (firstDropdownValue == "1976" && secondDropdownValue == "March 8") isFalling = true;
        if (firstDropdownValue == "1976" && secondDropdownValue == "May 16") isFalling = true;

        if (isFalling)
        {
            isTimerActive = true;
        }

        if (isTimerActive)
        {
            // Increment the timer
            timer += Time.deltaTime;

            if (timer >= delayTime)
            {
                // Access all Rigidbody components under the parent container and disable isKinematic
                Rigidbody[] rigidbodies = parentRigidbodyContainer.GetComponentsInChildren<Rigidbody>();
                foreach (Rigidbody rb in rigidbodies)
                {
                    rb.isKinematic = false;
                }

                // Reset the timer and disable the timer
                timer = 0.0f;
                isTimerActive = false;
            }
        }
    }
}
