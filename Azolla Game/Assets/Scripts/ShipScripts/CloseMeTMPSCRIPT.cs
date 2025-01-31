using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class CloseMeTMPSCRIPT : MonoBehaviour
{
    [SerializeField]
    private Button close;

    [SerializeField]
    private ShipSoundManScript sMan;

    // Start is called before the first frame update
    void Start()
    {
        Button closeMe = close.GetComponent<Button>();
        closeMe.onClick.AddListener(closeMePress);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeMePress()
    {
        this.gameObject.SetActive(false);
        TheCloud.uiMenuOpen = false;
        sMan.audioSource.PlayOneShot(sMan.click2, 0.5f);
    }
}
