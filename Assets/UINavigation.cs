using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINavigation : MonoBehaviour
{
    // Welcome Page GameObject
    public GameObject welcomePage;
    // Art List Page GameObject
    public GameObject artListPage;
    // Camera Page GameObject
    public GameObject cameraPage;
    // Map Page GameObject
    public GameObject mapPage;
    //Donation Page GameObject
    public GameObject donationPage;

    // Start is called before the first frame update
    void Start()
    {
        // Hide all pages
        HideAllPages();
        welcomePage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAllPages()
    {
        // Hide all pages
        welcomePage.SetActive(false);
        artListPage.SetActive(false);
        cameraPage.SetActive(false);
        mapPage.SetActive(false);
        donationPage.SetActive(false);
    }

    public void ShowWelcomePage()
    {
        // Hide all pages
        HideAllPages();
        // Show welcome page
        welcomePage.SetActive(true);
    }

    public void ShowArtListPage()
    {
        // Hide all pages
        HideAllPages();
        // Show art list page
        artListPage.SetActive(true);
    }

    public void ShowCameraPage()
    {
        // Hide all pages
        HideAllPages();
        // Show camera page
        cameraPage.SetActive(true);
    }

    public void ShowMapPage()
    {
        // Hide all pages
        HideAllPages();
        // Show map page
        mapPage.SetActive(true);
    }

    public void ShowDonationPage()
    {
        // Hide all pages
        HideAllPages();
        // Show donation page
        donationPage.SetActive(true);
    }


}
