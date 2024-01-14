using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform;
    public float baseShakeMagnitude = 0f; // A base magnitude
    private Vector3 originalPosition;
    // private DropDown dropDown; // Reference to the DropDown script
    public TMP_Dropdown firstDropdown;
    public TMP_Dropdown secondDropdown;


    void Awake()
    {
        if (cameraTransform == null)
        {
            cameraTransform = Camera.main.transform;
        }


        // Get the DropDown script component
        // dropDown = GetComponent<DropDown>();
    }

    void OnEnable()
    {
        originalPosition = cameraTransform.localPosition;
    }

    void Update()
    {
        // Get the selected values from the DropDown script
        // (string firstDropdownValue, string secondDropdownValue) = dropDown.GetSelectedDropdownValues();

        string firstDropdownValue = firstDropdown.options[firstDropdown.value].text;
        string secondDropdownValue = secondDropdown.options[secondDropdown.value].text;
        if (secondDropdownValue == "None") baseShakeMagnitude = 0;
        if (firstDropdownValue == "1971" && secondDropdownValue == "April 17") baseShakeMagnitude = 28;
        if (firstDropdownValue == "1971" && secondDropdownValue == "May 20") baseShakeMagnitude = 2;
        if (firstDropdownValue == "1971" && secondDropdownValue == "July 11") baseShakeMagnitude = 19;
        if (firstDropdownValue == "1972" && secondDropdownValue == "January 2") baseShakeMagnitude = 19;
        if (firstDropdownValue == "1972" && secondDropdownValue == "September 17") baseShakeMagnitude = 1;
        if (firstDropdownValue == "1972" && secondDropdownValue == "December 6") baseShakeMagnitude = 14;
        if (firstDropdownValue == "1972" && secondDropdownValue == "December 9") baseShakeMagnitude = 12;
        if (firstDropdownValue == "1973" && secondDropdownValue == "February 8") baseShakeMagnitude = 8;
        if (firstDropdownValue == "1973" && secondDropdownValue == "March 13") baseShakeMagnitude = 32;
        if (firstDropdownValue == "1973" && secondDropdownValue == "June 20") baseShakeMagnitude = 22;
        if (firstDropdownValue == "1973" && secondDropdownValue == "October 1") baseShakeMagnitude = 11;
        if (firstDropdownValue == "1974" && secondDropdownValue == "February 23") baseShakeMagnitude = 7;
        if (firstDropdownValue == "1974" && secondDropdownValue == "March 27") baseShakeMagnitude = 16;
        if (firstDropdownValue == "1974" && secondDropdownValue == "April 19") baseShakeMagnitude = 9;
        if (firstDropdownValue == "1974" && secondDropdownValue == "May 29") baseShakeMagnitude = 6;
        if (firstDropdownValue == "1974" && secondDropdownValue == "July 11") baseShakeMagnitude = 27;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 3") baseShakeMagnitude = 32;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 12") baseShakeMagnitude = 17;
        if (firstDropdownValue == "1975" && secondDropdownValue == "January 13") baseShakeMagnitude = 11;
        if (firstDropdownValue == "1975" && secondDropdownValue == "February 13") baseShakeMagnitude = 14;
        if (firstDropdownValue == "1975" && secondDropdownValue == "May 7") baseShakeMagnitude = 13;
        if (firstDropdownValue == "1975" && secondDropdownValue == "May 27") baseShakeMagnitude = 14;
        if (firstDropdownValue == "1975" && secondDropdownValue == "November 10") baseShakeMagnitude = 18;
        if (firstDropdownValue == "1976" && secondDropdownValue == "January 4") baseShakeMagnitude = 18;
        if (firstDropdownValue == "1976" && secondDropdownValue == "January 12") baseShakeMagnitude = 11;
        if (firstDropdownValue == "1976" && secondDropdownValue == "March 6") baseShakeMagnitude = 23;
        if (firstDropdownValue == "1976" && secondDropdownValue == "March 8") baseShakeMagnitude = 18;
        if (firstDropdownValue == "1976" && secondDropdownValue == "May 16") baseShakeMagnitude = 15;


        cameraTransform.localPosition = originalPosition + Random.insideUnitSphere * baseShakeMagnitude * 0.1f * 0.2f;
    }
}
