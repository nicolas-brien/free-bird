using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject menuCanvas;
    bool showMenu = false;

    public GameObject optionsPanel;
    public Slider speedSlider;
    public InputField speedSliderInput;

	// Use this for initialization
	void Start() {
        menuCanvas.SetActive(showMenu);
        optionsPanel.SetActive(false);
        speedSliderInput.text = "10";
    }

    // Update is called once per frame
    void Update() {
		if (Input.GetKeyDown("escape"))
        {
            showMenu = ToggleMenu();
        }
	}

    bool ToggleMenu()
    {
        menuCanvas.SetActive(!showMenu);
        return !showMenu;
    }

    public void ResumeGame()
    {
        showMenu = false;
        menuCanvas.SetActive(showMenu);
        optionsPanel.SetActive(false);
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void UpdateSliderInput()
    {
        speedSliderInput.text = speedSlider.value.ToString();
    }

    public void UpdateSliderValue()
    {
        speedSlider.value = float.Parse(speedSliderInput.text);
    }

    public void CancelOptions()
    {
        speedSlider.value = Movement.GetSpeed();
        optionsPanel.SetActive(false);
    }

    public void SaveAndExitOptions()
    {
        Movement.SetSpeed(speedSlider.value);
        ResumeGame();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
