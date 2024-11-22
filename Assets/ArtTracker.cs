using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtTracker : MonoBehaviour
{
    // Dictionary of string and boolean
    public Dictionary<string, bool> artStatus = new Dictionary<string, bool>();

    // Canadian Forest Fields
    [Header("Canadian Forest")]
    public TMPro.TextMeshProUGUI panelText_CanadianForest;
    public GameObject mapMarker_CanadianForest;

    // Turkish Forest Fields
    [Header("Turkish Forest")]
    public TMPro.TextMeshProUGUI panelText_TurkishForest;
    public GameObject mapMarker_TurkishForest;

    // Winter Cat Fields
    [Header("Winter Cat")]
    public TMPro.TextMeshProUGUI panelText_WinterCat;
    public GameObject mapMarker_WinterCat;

    // Mona Lisa Fields
    [Header("Mona Lisa")]
    public TMPro.TextMeshProUGUI panelText_MonaLisa;
    public GameObject mapMarker_MonaLisa;

    // Starry Night Fields
    [Header("Starry Night")]
    public TMPro.TextMeshProUGUI panelText_StarryNight;
    public GameObject mapMarker_StarryNight;

    // Pearl Earring Fields
    [Header("Pearl Earring")]
    public TMPro.TextMeshProUGUI panelText_PearlEarring;
    public GameObject mapMarker_PearlEarring;

    [Header("Map Marker")]
    // String of Focused Art
    public string focusedArt;

    // Start is called before the first frame update
    void Start()
    {
        // Create entries for each art piece ("Astronaut", "Drone", "Fissure", "Oxygen")
        artStatus.Add("Canadian Forest", false);
        artStatus.Add("Turkish Forest", false);
        artStatus.Add("Winter Cat", false);
        artStatus.Add("Mona Lisa", false);
        artStatus.Add("Starry Night", false);
        artStatus.Add("Pearl Earring", false);
        UpdatePanels();
        focusedArt = "";
    }

    // Update is called once per frame
    void Update()
    {
        // Display dictionary in the console
        foreach (KeyValuePair<string, bool> art in artStatus)
        {
            Debug.Log(art.Key + " " + art.Value);
        }
    }

    void UpdateMapMarker()
    {
        // if focused art is Canadian Forest
        if (focusedArt == "Canadian Forest")
            // mapMarker_CanadianForest is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_CanadianForest.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_CanadianForest.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        // if focused art is Turkish Forest
        if (focusedArt == "Turkish Forest")
            // mapMarker_TurkishForest is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_TurkishForest.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_TurkishForest.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        // if focused art is Winter Cat
        if (focusedArt == "Winter Cat")
            // mapMarker_WinterCat is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_WinterCat.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_WinterCat.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        // if focused art is Mona Lisa
        if (focusedArt == "Mona Lisa")
            // mapMarker_MonaLisa is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_MonaLisa.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_MonaLisa.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        // if focused art is Starry Night
        if (focusedArt == "Starry Night")
            // mapMarker_StarryNight is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_StarryNight.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_StarryNight.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        // if focused art is Pearl Earring
        if (focusedArt == "Pearl Earring")
            // mapMarker_PearlEarring is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_PearlEarring.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_PearlEarring.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
    }

    // for each paneltext, check if art is in the dictionary and 
    void UpdatePanels()
    {   
        // Update Seen Status for Canadian Forest
        if (CheckArtStatus("Canadian Forest"))
        {
            panelText_CanadianForest.text = "Seen";
        }
        else
        {
            panelText_CanadianForest.text = " ";
        }

        // Update Seen Status for Turkish Forest
        if (CheckArtStatus("Turkish Forest"))
        {
            panelText_TurkishForest.text = "Seen";
        }
        else
        {
            panelText_TurkishForest.text = " ";
        }

        // Update Seen Status for Winter Cat
        if (CheckArtStatus("Winter Cat"))
        {
            panelText_WinterCat.text = "Seen";
        }
        else
        {
            panelText_WinterCat.text = " ";
        }

        // Update Seen Status for Mona Lisa
        if (CheckArtStatus("Mona Lisa"))
        {
            panelText_MonaLisa.text = "Seen";
        }
        else
        {
            panelText_MonaLisa.text = " ";
        }

        // Update Seen Status for Starry Night
        if (CheckArtStatus("Starry Night"))
        {
            panelText_StarryNight.text = "Seen";
        }
        else
        {
            panelText_StarryNight.text = " ";
        }

        // Update Seen Status for Pearl Earring
        if (CheckArtStatus("Pearl Earring"))
        {
            panelText_PearlEarring.text = "Seen";
        }
        else
        {
            panelText_PearlEarring.text = " ";
        }
        
    }


    public void AddArt(string artName)
    {
        // check if the art is already in the dictionary
        if (artStatus.ContainsKey(artName))
        {
            // if it is, set the value to true
            artStatus[artName] = true;
        }
        else
        {
            // if it is not, add the art to the dictionary
            artStatus.Add(artName, true);
        }
        // set focused art to the art that was added
        focusedArt = artName;
        UpdateMapMarker();
        UpdatePanels();
    }

    public void RemoveArt(string artName)
    {
        // check if the art is already in the dictionary
        if (artStatus.ContainsKey(artName))
        {
            // if it is, set the value to false
            artStatus[artName] = false;
        }
        else
        {
            // if it is not, add the art to the dictionary
            artStatus.Add(artName, false);
        }
        UpdatePanels();
    }

    public void ResetArtList()
    {
        // set all values in the dictionary to false
        foreach (KeyValuePair<string, bool> art in artStatus)
        {
            artStatus[art.Key] = false;
        }
        UpdatePanels();
    }

    public bool CheckArtStatus(string artName)
    {
        if (artStatus.ContainsKey(artName))
        {
            // check if the art is true in the dictionary
            if (artStatus[artName] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            // if the art is not in the dictionary, return false
            return false;
        }
    }

}
