using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINavigation : MonoBehaviour
{
    public GameObject welcomePage;
    public GameObject artListPage;
    public GameObject cameraPage;
    public GameObject mapPage;
    public GameObject donationPage;

    
    void Start()
    {
        
        HideAllPages();
        welcomePage.SetActive(true);
    }

    
    void Update()
    {
        
    }

    public void HideAllPages()
    {
        welcomePage.SetActive(false);
        artListPage.SetActive(false);
        cameraPage.SetActive(false);
        mapPage.SetActive(false);
        donationPage.SetActive(false);
    }

    public void ShowWelcomePage()
    {
        
        HideAllPages();
        // Show welcome page
        welcomePage.SetActive(true);
    }

    public void ShowArtListPage()
    {
        
        HideAllPages();
        // Show art list page
        artListPage.SetActive(true);
    }

    public void ShowCameraPage()
    {
        
        HideAllPages();
        // Show camera page
        cameraPage.SetActive(true);
    }

    public void ShowMapPage()
    {
        
        HideAllPages();
        // Show map page
        mapPage.SetActive(true);
    }

    public void ShowDonationPage()
    {
        
        HideAllPages();
        // Show donation page
        donationPage.SetActive(true);
    }


}
