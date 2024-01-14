using UnityEngine;
using UnityEngine.UI;
using TMPro;

using System.Collections.Generic;

public class DropDown : MonoBehaviour
{
    public TMP_Dropdown firstDropdown;
    public TMP_Dropdown secondDropdown;

    private Dictionary<string, List<string>> optionsForSecondDropdown = new Dictionary<string, List<string>>()
    {
        {"None", new List<string>{"None"}},
        {"1971", new List<string>{"None","April 17", "May 20", "July 11"}},
        {"1972", new List<string>{"None","January 2", "September 17","December 6", "December 9"}},
        {"1973", new List<string>{"None","February 8", "March 13", "June 20", "October 1"}},
        {"1974", new List<string>{"None","February 23", "March 27", "April 19", "May 29", "July 11"}},
        {"1975", new List<string>{"None","January 3", "January 12", "January 13", "February 13", "May 7", "May 27", "November 10"}},
        {"1976", new List<string>{"None","January 4", "January 12", "March 6", "March 8", "May 16"}},
        // Add more options as needed.
    };

    void Start()
    {
        firstDropdown.onValueChanged.AddListener(OnFirstDropdownValueChanged);
        OnFirstDropdownValueChanged(firstDropdown.value);
    }

    void OnFirstDropdownValueChanged(int index)
    {
        string selectedOption = firstDropdown.options[index].text;
        
        List<string> secondDropdownOptions;
        if (optionsForSecondDropdown.TryGetValue(selectedOption, out secondDropdownOptions))
        {
            secondDropdown.ClearOptions();
            
            // Instead of secondDropdown.AddOptions(), use this for TextMeshPro Dropdowns:
            secondDropdown.AddOptions(secondDropdownOptions);
        }
    }


}