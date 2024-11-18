using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtTracker : MonoBehaviour
{
    // Dictionary of string and boolean
    public Dictionary<string, bool> artStatus = new Dictionary<string, bool>();

    // Panels TMP text (astronaut, drone, fissure, oxygen)
    public TMPro.TextMeshProUGUI panelText_astronaut;
    public TMPro.TextMeshProUGUI panelText_drone;
    public TMPro.TextMeshProUGUI panelText_fissure;
    public TMPro.TextMeshProUGUI panelText_oxygen;

    // Map Marker GameObjects (astronaut, drone, fissure, oxygen)
    public GameObject mapMarker_astronaut;
    public GameObject mapMarker_drone;
    public GameObject mapMarker_fissure;
    public GameObject mapMarker_oxygen;

    // String of Focused Art
    public string focusedArt;

    // Start is called before the first frame update
    void Start()
    {
        // Create entries for each art piece ("Astronaut", "Drone", "Fissure", "Oxygen")
        artStatus.Add("Astronaut", false);
        artStatus.Add("Drone", false);
        artStatus.Add("Fissure", false);
        artStatus.Add("Oxygen", false);
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
        // if focused art is astronaut
        if (focusedArt == "Astronaut")
            // mapMarker_astronaut is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_astronaut.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white and semi-transparent
            mapMarker_astronaut.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);

        // if focused art is drone
        if (focusedArt == "Drone")
            // mapMarker_drone is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_drone.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white
            mapMarker_drone.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);


        // if focused art is fissure
        if (focusedArt == "Fissure")
            // mapMarker_fissure is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_fissure.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white
            mapMarker_fissure.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);


        // if focused art is oxygen
        if (focusedArt == "Oxygen")
            // mapMarker_oxygen is a panel
            // get it's image component and set the color to green and semi-transparent
            mapMarker_oxygen.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not, set the color to white
            mapMarker_oxygen.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);


    }

    // for each paneltext, check if art is in the dictionary and 
    void UpdatePanels()
    {   

        if (artStatus.ContainsKey("Astronaut"))
        {
            if (CheckArtStatus("Astronaut"))
            {
                panelText_astronaut.text = "Seen";
            }
            else
            {
                panelText_astronaut.text = " ";
            }
        }
        if (artStatus.ContainsKey("Drone"))
        {
            if (CheckArtStatus("Drone"))
            {
                panelText_drone.text = "Seen";
            }
            else
            {
                panelText_drone.text = " ";
            }
        }
        if (artStatus.ContainsKey("Fissure"))
        {
            if (CheckArtStatus("Fissure"))
            {
                panelText_fissure.text = "Seen";
            }
            else
            {
                panelText_fissure.text = " ";
            }
        }
        if (artStatus.ContainsKey("Oxygen"))
        {
            if (CheckArtStatus("Oxygen"))
            {
                panelText_oxygen.text = "Seen";
            }
            else
            {
                panelText_oxygen.text = " ";
            }
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

}
