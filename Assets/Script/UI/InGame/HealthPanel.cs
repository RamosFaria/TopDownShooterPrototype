using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HealthPanel : MonoBehaviour
{
    private List<Image> heartList = new List<Image>();

    [SerializeField] private Image heartImage;

    [SerializeField] private Sprite fullHeart; //get online sprite
    [SerializeField] private Sprite emptyHeart; //get online sprite

    private void OnEnable()
    {
        Entity.OnTakeHit += HandleHealthChange;

        for(int i =0; i<3;i++)
        {
            Instantiate(heartImage, transform);
            heartList.Add(heartImage);
        }

        //UpdateHeartAmount(SetSelectedBundle.Instance.selectedBundle.characterSelected.MaxHealth);

    }

    private void OnDisable()
    {
        Entity.OnTakeHit -= HandleHealthChange;
    }

    public void HandleHealthChange(Entity entity, int damage)
    {
        entity.TakeDamage(damage);

        Character character = entity.GetComponent<Character>();
        if (character != null)
        {
            UpdateHeartAmount(character.Health);
        }
    }

    private void UpdateHeartAmount(int currentCharacterHealth)
    {
        for(int i=0; i< SetSelectedBundle.Instance.selectedBundle.characterSelected.MaxHealth; i++)
        {
            if(i< currentCharacterHealth)
            {
                //heartList[i].sprite = fullHeart;
            }
            else
            {
                //heartList[i].sprite = emptyHeart;
            }

        }
    }


}
