using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtTracker : MonoBehaviour
{
    
    public Dictionary<string, bool> artStatus = new Dictionary<string, bool>();
    //For sound feature
    public AudioSource audioSource; 
    public AudioClip[] targetClips;
    public Button playButton;
    public Sprite playSprite; 
    public Sprite stopSprite;

    private Image playButtonImage;

    [Header("Canadian Forest")]
    public TMPro.TextMeshProUGUI panelText_CanadianForest;
    public GameObject mapMarker_CanadianForest;

    [Header("Turkish Forest")]
    public TMPro.TextMeshProUGUI panelText_TurkishForest;
    public GameObject mapMarker_TurkishForest;

    [Header("Winter Cat")]
    public TMPro.TextMeshProUGUI panelText_WinterCat;
    public GameObject mapMarker_WinterCat;

    [Header("Mona Lisa")]
    public TMPro.TextMeshProUGUI panelText_MonaLisa;
    public GameObject mapMarker_MonaLisa;

    [Header("Starry Night")]
    public TMPro.TextMeshProUGUI panelText_StarryNight;
    public GameObject mapMarker_StarryNight;

    [Header("Pearl Earring")]
    public TMPro.TextMeshProUGUI panelText_PearlEarring;
    public GameObject mapMarker_PearlEarring;

    [Header("Map Marker")]
    // String of Focused Art
    public string focusedArt;

    
    void Start()
    {
        
        artStatus.Add("Canadian Forest", false);
        artStatus.Add("Turkish Forest", false);
        artStatus.Add("Winter Cat", false);
        artStatus.Add("Mona Lisa", false);
        artStatus.Add("Starry Night", false);
        artStatus.Add("Pearl Earring", false);
        UpdatePanels();
        focusedArt = "";
        playButtonImage = playButton.GetComponent<Image>();
    }

    
    void Update()
    {
        
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
            // get its image component and set the color to green and semitransparent
            mapMarker_CanadianForest.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            // if not set the color to white and semitransparent
            mapMarker_CanadianForest.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        if (focusedArt == "Turkish Forest")
            mapMarker_TurkishForest.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            mapMarker_TurkishForest.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        if (focusedArt == "Winter Cat")
            mapMarker_WinterCat.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            mapMarker_WinterCat.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        if (focusedArt == "Mona Lisa")
            mapMarker_MonaLisa.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            mapMarker_MonaLisa.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        if (focusedArt == "Starry Night")
            mapMarker_StarryNight.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
            mapMarker_StarryNight.GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
        if (focusedArt == "Pearl Earring")
            mapMarker_PearlEarring.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 1, 0, 0.5f);
        else
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

        if (CheckArtStatus("Turkish Forest"))
        {
            panelText_TurkishForest.text = "Seen";
        }
        else
        {
            panelText_TurkishForest.text = " ";
        }

        if (CheckArtStatus("Winter Cat"))
        {
            panelText_WinterCat.text = "Seen";
        }
        else
        {
            panelText_WinterCat.text = " ";
        }

        if (CheckArtStatus("Mona Lisa"))
        {
            panelText_MonaLisa.text = "Seen";
        }
        else
        {
            panelText_MonaLisa.text = " ";
        }

        if (CheckArtStatus("Starry Night"))
        {
            panelText_StarryNight.text = "Seen";
        }
        else
        {
            panelText_StarryNight.text = " ";
        }

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
        if (artStatus.ContainsKey(artName))
        {
            artStatus[artName] = true;
        }
        else
        {
            artStatus.Add(artName, true);
        }
        focusedArt = artName;
        UpdateMapMarker();
        UpdatePanels();
    }

    public void RemoveArt(string artName)
    {
        if (artStatus.ContainsKey(artName))
        {
            artStatus[artName] = false;
        }
        else
        {
            artStatus.Add(artName, false);
        }
        UpdatePanels();
    }

    public void ResetArtList()
    {
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
            return false;
        }
    }

    
    public void ToggleSound()
    {
        
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            playButtonImage.sprite = playSprite;
        }
        else
        {
            switch (focusedArt)
            {
                case "Canadian Forest":
                    audioSource.clip = targetClips[0]; 
                    break;

                case "Turkish Forest":
                    audioSource.clip = targetClips[1]; 
                    break;

                case "Winter Cat":
                    audioSource.clip = targetClips[2]; 
                    break;

                case "Mona Lisa":
                    audioSource.clip = targetClips[3]; 
                    break;

                case "Starry Night":
                    audioSource.clip = targetClips[4]; 
                    break;

                case "Pearl Earring":
                    audioSource.clip = targetClips[5];
                    break;

                default:
                    audioSource.clip = null; 
                    break;
            }

            if (audioSource.clip != null)
            {
                audioSource.Play();
                playButtonImage.sprite = stopSprite;
            }
        }
    }

}
