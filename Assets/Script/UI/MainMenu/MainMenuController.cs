using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI characterDescriptionTextBox;

    [SerializeField] private SelectedBundle selectedSettings;

    #region Default
    [Header("Default Values")]
    [SerializeField] private CharacterSkills defaultCharacter;
    [SerializeField] private WeaponStats defaultWeapon;

    #endregion
    
    #region WeaponStats
    [Header("Weapon Stats TextBox")]
    [SerializeField] private TextMeshProUGUI weaponNameTextBox;
    [SerializeField] private TextMeshProUGUI weaponDamageTextBox;
    [SerializeField] private TextMeshProUGUI weaponMagazineSizeTextBox;
    [SerializeField] private TextMeshProUGUI weaponReloadTimeTextBox;
    #endregion

    private void Awake()
    {
        OnCharacterSelectedChanged(defaultCharacter);
        OnWeaponSelectedChanged(defaultWeapon);
        
    }
    private void OnEnable()
    {
        SelectCharacter.OnCurrentCharacterSelectedChanged += OnCharacterSelectedChanged;
        SelectWeapon.OnCurrentWeaponSelectedChanged += OnWeaponSelectedChanged;
    }

    private void OnDisable()
    {
        SelectCharacter.OnCurrentCharacterSelectedChanged -= OnCharacterSelectedChanged;
        SelectWeapon.OnCurrentWeaponSelectedChanged -= OnWeaponSelectedChanged;
    }

    public void OnCharacterSelectedChanged(CharacterSkills currenteSelectedCharacter)
    {
        characterDescriptionTextBox.text = currenteSelectedCharacter.Description;

        selectedSettings.characterSelected = currenteSelectedCharacter;
    }

    public void OnWeaponSelectedChanged(WeaponStats currentWeaponSelected)
    {
        weaponNameTextBox.text = currentWeaponSelected.WeaponName;
        weaponDamageTextBox.text = "Damage: " + currentWeaponSelected.BaseDamage.ToString();
        weaponMagazineSizeTextBox.text = "Magazine Size: " + currentWeaponSelected.MagazineSize.ToString();
        weaponReloadTimeTextBox.text = "Reload Time: " + currentWeaponSelected.ReloadTime.ToString();

        selectedSettings.weaponSelected = currentWeaponSelected;
    }


    public void StartGame()
    {
        SceneManager.LoadSceneAsync("InGame", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
