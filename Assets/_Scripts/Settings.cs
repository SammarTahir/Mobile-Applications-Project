using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Settings : MonoBehaviour {

 public Button SettingBtn;
	// Use this for initialization
	void Start () {
		SettingBtn.onClick.AddListener(ChangeScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
void ChangeScene(){ 
	SceneManager.LoadSceneAsync("SettingsMenu");
	}

}
