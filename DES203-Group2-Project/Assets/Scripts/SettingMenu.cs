using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public TMPro.TMP_Dropdown resolutionDropdown;

    public TMPro.TMP_Dropdown GraphicsDropdown;

    public void Start()
    {
        resolutions = Screen.resolutions;

        GraphicsDropdown.value = QualitySettings.GetQualityLevel();

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentresolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if ( resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentresolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentresolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolutiion (int resolutionIndex)
    {
       Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        //control audio of master mixer
        audioMixer.SetFloat("Volume", volume); 
    }

    public void SetQuality(int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);
    }

    public void SetFullscreen( bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
